namespace PictureIdertifyExp
{
    partial class SinglePictureIdentify
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.openFilePicture = new System.Windows.Forms.OpenFileDialog();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lalShowResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listFileIdentifyResult = new System.Windows.Forms.ListBox();
            this.btSelectFiles = new System.Windows.Forms.Button();
            this.fileSelct = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFiles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(54, 65);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(182, 171);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectPic.Location = new System.Drawing.Point(84, 265);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(127, 36);
            this.btnSelectPic.TabIndex = 1;
            this.btnSelectPic.Text = "选择图片";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // openFilePicture
            // 
            this.openFilePicture.Filter = "图片文件(*.bmp)|*.bmp";
            // 
            // btnIdentify
            // 
            this.btnIdentify.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIdentify.Location = new System.Drawing.Point(272, 265);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(127, 36);
            this.btnIdentify.TabIndex = 2;
            this.btnIdentify.Text = "识 别";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "原图：";
            // 
            // lalShowResult
            // 
            this.lalShowResult.AutoSize = true;
            this.lalShowResult.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalShowResult.Location = new System.Drawing.Point(304, 65);
            this.lalShowResult.Name = "lalShowResult";
            this.lalShowResult.Size = new System.Drawing.Size(53, 56);
            this.lalShowResult.TabIndex = 5;
            this.lalShowResult.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(296, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "识别结果：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 367);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnIdentify);
            this.tabPage1.Controls.Add(this.btnSelectPic);
            this.tabPage1.Controls.Add(this.picBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lalShowResult);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "识别单个图像";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.txtFiles);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btSelectFiles);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "识别文件夹图像";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listFileIdentifyResult);
            this.groupBox1.Location = new System.Drawing.Point(15, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "识别统计结果";
            // 
            // listFileIdentifyResult
            // 
            this.listFileIdentifyResult.FormattingEnabled = true;
            this.listFileIdentifyResult.HorizontalScrollbar = true;
            this.listFileIdentifyResult.ItemHeight = 14;
            this.listFileIdentifyResult.Location = new System.Drawing.Point(13, 24);
            this.listFileIdentifyResult.Name = "listFileIdentifyResult";
            this.listFileIdentifyResult.Size = new System.Drawing.Size(408, 214);
            this.listFileIdentifyResult.TabIndex = 0;
            // 
            // btSelectFiles
            // 
            this.btSelectFiles.Location = new System.Drawing.Point(13, 20);
            this.btSelectFiles.Name = "btSelectFiles";
            this.btSelectFiles.Size = new System.Drawing.Size(124, 34);
            this.btSelectFiles.TabIndex = 0;
            this.btSelectFiles.Text = "选择文件夹";
            this.btSelectFiles.UseVisualStyleBackColor = true;
            this.btSelectFiles.Click += new System.EventHandler(this.btSelectFiles_Click);
            // 
            // txtFiles
            // 
            this.txtFiles.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFiles.Location = new System.Drawing.Point(156, 27);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ReadOnly = true;
            this.txtFiles.Size = new System.Drawing.Size(280, 23);
            this.txtFiles.TabIndex = 2;
            // 
            // SinglePictureIdentify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 366);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "SinglePictureIdentify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图像识别";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.OpenFileDialog openFilePicture;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lalShowResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listFileIdentifyResult;
        private System.Windows.Forms.Button btSelectFiles;
        private System.Windows.Forms.FolderBrowserDialog fileSelct;
        private System.Windows.Forms.TextBox txtFiles;
    }
}

