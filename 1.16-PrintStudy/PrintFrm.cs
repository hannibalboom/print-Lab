using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;//打印
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1._16_PrintStudy
{
    public partial class PrintFrm : Form
    {
        #region 变量
        private object printObject;
        PrintDocument pd = new PrintDocument();
        //选择打印设备和纸张大小
        string device_Chosen;
        string paperSize_Chosen;


        //接收form1的数据
        public List<Image> uploadedImages { get; set; }
        public List<string> selectedImagePaths { get; set; }
        public string patientName { get; set; }
        public string patientAge { get; set; }
        public string patientSex { get; set; }
        public string patientId { get; set; }
        public string patientR_eye { get; set; }
        public string patientL_eye { get; set; }

        public string patientRemark { get; set; }

        private List<Image> ImagesToPrint;
        private string Dignose_Information;



        #endregion

        public PrintFrm(List<Image> uploadedImages,string Dignose,string remark)
        {
            InitializeComponent();
            //接收的图片
            ImagesToPrint = uploadedImages;
            //接收的诊断信息
            Dignose_Information = Dignose;
            //接收的备注
            patientRemark = remark;
            //using (Graphics g = this.CreateGraphics())
            //{
            //    DrawContent(g, pd);  // 使用CreateGraphics获取Graphics对象
            //}
        }

        //窗口初始化内容
        private void PrintFrm_Shown(object sender, EventArgs e)
        {
            cBox_device.Text = "--请选择打印设备--";
            foreach (String d in PrinterSettings.InstalledPrinters) cBox_device.Items.Add(d);
            cBox_PaperSize.SelectedIndex = 2;//默认选中A4
            tBox_title.Text = "打印文件名称";
            pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            Preview(pd);
        }

        #region 绘制打印页面
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // 获取打印页面的高度和宽度
            int height = pd.DefaultPageSettings.PaperSize.Height;
            int width = pd.DefaultPageSettings.PaperSize.Width;

            // 创建一个Bitmap准备绘图
            Bitmap bitmap = new Bitmap(width, height);

            // 设置StringFormat以对齐文本
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;

            // 显示文本
            string name = "姓名：" + patientName;
            string age = "年龄：" + patientAge;
            string sex = "性别：" + patientSex;
            string Id = "ID：" + patientId;
            string r_eye = "右眼视力：" + patientR_eye;
            string l_eye = "左眼视力：" + patientL_eye;
            string dignose = "临床诊断：" + Dignose_Information;
            string remark = "备注：" + patientRemark;

            // 设置文本字体和颜色
            Font font = new Font("Arial", 18);
            Font font2 = new Font("Helvetica", 15);
            Font font3 = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush lightGrayBrush = new SolidBrush(Color.LightGray);
            SolidBrush darkGrayBrush = new SolidBrush(Color.DimGray);

            //起始横坐标
            float StartX = width * 0.01f;

            // 绘制线条
                //通过Graphics绘制文本和线条
            Pen pen = new Pen(Color.Black, 5);
            e.Graphics.DrawLine(pen, StartX, height * 0.02f, width * 0.99f, height * 0.02f);
            e.Graphics.DrawLine(pen, StartX, height * 0.09f, width * 0.99f, height * 0.09f);
            e.Graphics.DrawLine(pen, StartX, height * 0.30f, width * 0.99f, height * 0.30f);
            e.Graphics.DrawLine(pen, StartX, height * 0.93f, width * 0.99f, height * 0.93f);
            // 绘制文字
            //1.个人信息
            e.Graphics.DrawString(name, font, brush, new PointF(StartX, height * 0.03f));
            e.Graphics.DrawString(age, font, brush, new PointF(width * 0.4f, height * 0.03f));
            e.Graphics.DrawString(sex, font, brush, new PointF(width * 0.75f, height * 0.03f));
            e.Graphics.DrawString(Id, font, brush, new PointF(StartX, height * 0.06f));
            e.Graphics.DrawString(r_eye, font, brush, new PointF(width * 0.4f, height * 0.06f));
            e.Graphics.DrawString(l_eye, font, brush, new PointF(width * 0.75f, height * 0.06f));

            //2.临床诊断
            e.Graphics.DrawString(dignose, font2, brush, new PointF(StartX, height * 0.11f));

            //3.影像描述
            e.Graphics.DrawString("影像描述：", font2, brush, new PointF(StartX, height * 0.2f));

            //4.拍摄医生  医生
            e.Graphics.DrawString("拍摄医生：admin", font, brush, new PointF(StartX, height * 0.9f));
            e.Graphics.DrawString("医生：admin", font, brush, new PointF(width * 0.8f, height * 0.9f));

            //5.备注
            e.Graphics.DrawString(remark, font, brush, new PointF(StartX, height * 0.94f));



         //绘制图片
            //查找所有图片中的最大宽度和高度
            int maxWidth = 0;
            int maxHeight = 0;
            foreach (Image originalImage in uploadedImages)
            {
                maxWidth = Math.Max(maxWidth, originalImage.Width);
                maxHeight = Math.Max(maxHeight, originalImage.Height);
            }
            //设置目标图片大小
            float targetHeight = height * 0.23f;
            float targetWidth = width * 0.41f;

            //缩放每张原始图片
            List<Image> resizedImages = new List<Image>();

            //保存图片名称
            List<string> imageNames = new List<string>();
            foreach (string imagePath in selectedImagePaths)
            {
                string imageName = Path.GetFileName(imagePath);
                imageNames.Add(imageName);
            }
            //设置目标宽度和高度
            int intTargetWidth = Convert.ToInt32(targetWidth);
            int intTargetHeight = Convert.ToInt32(targetHeight);

            //缩放图片并计算偏移量
            foreach (Image originalImage in uploadedImages)
            {

                Bitmap resizedImage = new Bitmap(originalImage, new Size(intTargetWidth, intTargetHeight));
                resizedImages.Add(resizedImage);
                imageNames.Add("");
            }

            //设置绘制图片的位置和文本偏移量
            float[] offset = new float[resizedImages.Count];
            float[] positionsX = { 0.04f, 0.525f, 0.04f, 0.525f };
            float[] positionY = { 0.32f, 0.32f, 0.60f, 0.60f };
            float[] textOffsetY = { 0.57f, 0.57f, 0.85f, 0.85f };
            //循环绘制每张图片和相应的名称
            for (int i = 0; i < resizedImages.Count; i++)
            {
                offset[i] = (resizedImages[i].Width - e.Graphics.MeasureString(imageNames[i], font3).Width) / 2;
                e.Graphics.DrawImage(resizedImages[i], new PointF(width * positionsX[i], height * positionY[i]));
                e.Graphics.DrawString(imageNames[i], font3, darkGrayBrush, new PointF(width * positionsX[i] + offset[i], height * textOffsetY[i]));
            }
            //释放画刷
            lightGrayBrush.Dispose();
            darkGrayBrush.Dispose();
            brush.Dispose();
        }
        #endregion

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //  pd = printObject as PrintDocument;//利用as强制转换
            //将方法添加到每一页打印时的触发事件
            
            if (cBox_device.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择打印机！");
                return;  // 如果未选择打印机，返回上一步
            }
            //打印大小：传入选中的大小
            pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);
           
            pd.DocumentName = tBox_title.Text;
            Preview(pd);
            if (pd.PrinterSettings.IsValid == true)//检查打印机设备是否有效
            {
                pd.Print();//触发PrintPage事件PrintDocument_PrintPage函数
            }
        }


        //打印格式
        //private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    pd.PrinterSettings.PrinterName = cBox_device.Text;
        //    pd.DocumentName = tBox_title.Text;
        //    // using 语句创建一个 Font 对象，用于定义文本的字体
        //    using (Font font = new Font("Arial", 12))
        //    {
        //        //使用 Graphics 对象的 DrawString 方法来绘制文本
        //        e.Graphics.DrawString(yourString, font, Brushes.Black, new PointF(10, 10));
        //    }
            
        //    ////按收到的类别去处理
        //    //if (printObject is string)
        //    //{
        //    //    // 处理字符串类型的打印对象
        //    //    string textToPrint = (string)printObject;
        //    //    e.Graphics.DrawString(textToPrint, new Font("Arial", 10), Brushes.Black, new PointF(10, 10));
        //    //}
        //    //else if (printObject is DataTable)
        //    //{
        //    //    // 处理 DataTable 类型的打印对象
        //    //    DataTable dataTable = (DataTable)printObject;
        //    //    // 绘制表格内容...
        //    //}

        //}

        private void Preview(PrintDocument doc)
        {
            printPreviewControl1.Document = doc;

            printPreviewControl1.Show();
        }
        private void cBox_PaperSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            paperSize_Chosen = cBox_PaperSize.SelectedItem.ToString();
            switch (paperSize_Chosen)
            {
                case "A2":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("A2", 1654, 2339);
                    break;
                case "A3":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("A3", 1169, 1654);
                    break;
                case "A4":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
                    break;
                case "A5":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("A5", 583, 827);
                    break;
                case "A6":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("A6", 413, 583);
                    break;
                case "B2":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("B2", 1969, 2783);
                    break;
                case "B3":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("B3", 1390, 1969);
                    break;
                case "B4":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("B4", 984, 1390);
                    break;
                case "B5":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("B5", 693, 984);
                    break;
                case "B6":
                    pd.DefaultPageSettings.PaperSize = new PaperSize("B6", 492, 693);
                    break;
            }
        }

        private void cBox_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            pd.PrinterSettings.PrinterName = cBox_device.SelectedItem.ToString();
        }


        #region Close按钮
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void PrintFrm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
