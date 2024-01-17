
namespace _1._16_PrintStudy
{
    partial class PrintFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.cBox_device = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_PaperSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_title = new System.Windows.Forms.TextBox();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.btn_preview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Print.Location = new System.Drawing.Point(853, 12);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(94, 38);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.Location = new System.Drawing.Point(975, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 38);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 717);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1091, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // cBox_device
            // 
            this.cBox_device.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBox_device.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_device.FormattingEnabled = true;
            this.cBox_device.Location = new System.Drawing.Point(831, 131);
            this.cBox_device.Name = "cBox_device";
            this.cBox_device.Size = new System.Drawing.Size(248, 23);
            this.cBox_device.TabIndex = 4;
            this.cBox_device.SelectedIndexChanged += new System.EventHandler(this.cBox_device_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(828, 172);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "打印大小:";
            // 
            // cBox_PaperSize
            // 
            this.cBox_PaperSize.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.cBox_PaperSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBox_PaperSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_PaperSize.FormattingEnabled = true;
            this.cBox_PaperSize.Items.AddRange(new object[] {
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6"});
            this.cBox_PaperSize.Location = new System.Drawing.Point(906, 172);
            this.cBox_PaperSize.Name = "cBox_PaperSize";
            this.cBox_PaperSize.Size = new System.Drawing.Size(173, 23);
            this.cBox_PaperSize.TabIndex = 6;
            this.cBox_PaperSize.SelectedIndexChanged += new System.EventHandler(this.cBox_PaperSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(828, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件标题:";
            // 
            // tBox_title
            // 
            this.tBox_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBox_title.Location = new System.Drawing.Point(906, 209);
            this.tBox_title.Name = "tBox_title";
            this.tBox_title.Size = new System.Drawing.Size(173, 25);
            this.tBox_title.TabIndex = 7;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Location = new System.Drawing.Point(0, 33);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(821, 808);
            this.printPreviewControl1.TabIndex = 1;
            this.printPreviewControl1.Zoom = 1D;
            // 
            // btn_preview
            // 
            this.btn_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_preview.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preview.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_preview.Location = new System.Drawing.Point(853, 72);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(94, 38);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 739);
            this.Controls.Add(this.tBox_title);
            this.Controls.Add(this.cBox_PaperSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_device);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_Print);
            this.Name = "PrintFrm";
            this.Text = "PrintFrm";
            this.Load += new System.EventHandler(this.PrintFrm_Load);
            this.Shown += new System.EventHandler(this.PrintFrm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ComboBox cBox_device;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_PaperSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_title;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button btn_preview;
    }
}