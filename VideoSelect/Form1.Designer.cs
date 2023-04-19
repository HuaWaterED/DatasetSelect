namespace VideoSelect
{
    partial class videoSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(videoSelect));
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datasetPath = new System.Windows.Forms.Label();
            this.readDatasetPath = new System.Windows.Forms.Button();
            this.infomation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(14, 49);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(768, 432);
            this.axWindowsMediaPlayer2.TabIndex = 1;
            this.axWindowsMediaPlayer2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.axWindowsMediaPlayer2_PreviewKeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 21);
            this.textBox1.TabIndex = 2;
            // 
            // datasetPath
            // 
            this.datasetPath.AutoSize = true;
            this.datasetPath.Location = new System.Drawing.Point(12, 17);
            this.datasetPath.Name = "datasetPath";
            this.datasetPath.Size = new System.Drawing.Size(77, 12);
            this.datasetPath.TabIndex = 3;
            this.datasetPath.Text = "数据集目录：";
            // 
            // readDatasetPath
            // 
            this.readDatasetPath.Location = new System.Drawing.Point(707, 12);
            this.readDatasetPath.Name = "readDatasetPath";
            this.readDatasetPath.Size = new System.Drawing.Size(75, 23);
            this.readDatasetPath.TabIndex = 4;
            this.readDatasetPath.Text = "读取";
            this.readDatasetPath.UseVisualStyleBackColor = true;
            this.readDatasetPath.Click += new System.EventHandler(this.readDatasetPath_Click);
            // 
            // infomation
            // 
            this.infomation.AutoSize = true;
            this.infomation.Location = new System.Drawing.Point(12, 493);
            this.infomation.Name = "infomation";
            this.infomation.Size = new System.Drawing.Size(65, 12);
            this.infomation.TabIndex = 5;
            this.infomation.Text = "infomation";
            // 
            // videoSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 588);
            this.Controls.Add(this.infomation);
            this.Controls.Add(this.readDatasetPath);
            this.Controls.Add(this.datasetPath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Name = "videoSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label datasetPath;
        private System.Windows.Forms.Button readDatasetPath;
        private System.Windows.Forms.Label infomation;
    }
}

