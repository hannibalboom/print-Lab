using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._16_PrintStudy
{
    public partial class Form1 : Form
    {
        public PrintFrm Printer { get; set; }//声明打印机

        public List<PictureBox> pictureboxes;
        public List<Image> uploadedImages;
        public List<string> selectedImagePaths;
        public Form1()
        {
            InitializeComponent();
            //用于图片预览
            pictureboxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            //存放图片
            uploadedImages = new List<Image>();
            selectedImagePaths = new List<string>();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintFrm frm = new PrintFrm(uploadedImages,tbox_Dignose.Text,patientRemark.Text);
            frm.uploadedImages = uploadedImages;
            frm.selectedImagePaths = selectedImagePaths;
            //传递个人信息
            frm.patientName = patientName.Text;
            frm.patientSex = patientSex.Text;
            frm.patientAge = patientAge.Text;
            frm.patientId = patientID.Text;
            frm.patientR_eye = rightSight.Text;
            frm.patientL_eye = leftSight.Text;
            frm.patientRemark = patientRemark.Text;
            frm.Show();
            //假定一个对象
            //String textToPrint = "Hello, this is a dynamic print object.";
            //PrintFrm frm = new PrintFrm("好好学习，天天向上!");
            //if (Printer == null || Printer.IsDisposed)//为空或已被释放
            //{
            //    Printer = new PrintFrm("好好学习，天天向上!");//实例化
            //    Printer.ShowInTaskbar = false;//窗体不会在任务栏中显示
            //    Printer.StartPosition = FormStartPosition.CenterScreen;//窗体起始位置为屏幕中央
            //    Printer.ShowDialog();//此时用户只能与该窗体交互
            //}
            //else
            //{
            //    Printer.Activate();//已经存在，则将窗体置于前台
            //}
            //frm.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbox_Dignose.Multiline = true;
            tbox_Dignose.Height = 60;
        }

        private void btn_UpdateImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //运行用户选择多个文件
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的所有图片文件路径
                selectedImagePaths.AddRange(openFileDialog.FileNames);
                string[] selectedImage = openFileDialog.FileNames;

                // 显示图片
                ShowImages(selectedImage);
            }
        }


        private void ShowImages(string[] imagePaths)
        {
            foreach (string imagePath in imagePaths)
            {
                //添加新上传的图片到列表
                Image newImage = Image.FromFile(imagePath);
                uploadedImages.Add(newImage);
                // 检查图片数量是否超过4，如果是，移除第一个元素
                while (uploadedImages.Count > 4)
                {
                    uploadedImages.RemoveAt(0);
                }
                // 遍历 PictureBox 数组，显示所有上传的图片
                for (int i = 0; i < pictureboxes.Count; i++)
                {
                    // 如果有足够的上传图片，则设置 PictureBox 的 Image 属性
                    if (i < uploadedImages.Count)
                    {
                        pictureboxes[i].Image = uploadedImages[i];
                    }
                    else
                    {
                        // 如果上传图片不足，可以清空 PictureBox
                        pictureboxes[i].Image = null;
                    }
                }
            }
        }
    }
}
