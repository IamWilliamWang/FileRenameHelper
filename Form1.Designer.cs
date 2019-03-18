namespace 重命名助手
{
    partial class Form1
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
            if (disposing && ( components != null ))
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox文件名 = new System.Windows.Forms.TextBox();
            this.textBox内容 = new System.Windows.Forms.TextBox();
            this.button提交 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置后缀名过滤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelExtension = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹名：";
            // 
            // textBox文件名
            // 
            this.textBox文件名.AllowDrop = true;
            this.textBox文件名.Location = new System.Drawing.Point(83, 28);
            this.textBox文件名.Name = "textBox文件名";
            this.textBox文件名.Size = new System.Drawing.Size(395, 21);
            this.textBox文件名.TabIndex = 1;
            this.textBox文件名.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox文件名.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // textBox内容
            // 
            this.textBox内容.Location = new System.Drawing.Point(14, 55);
            this.textBox内容.Multiline = true;
            this.textBox内容.Name = "textBox内容";
            this.textBox内容.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox内容.Size = new System.Drawing.Size(535, 348);
            this.textBox内容.TabIndex = 2;
            // 
            // button提交
            // 
            this.button提交.Location = new System.Drawing.Point(484, 26);
            this.button提交.Name = "button提交";
            this.button提交.Size = new System.Drawing.Size(65, 23);
            this.button提交.TabIndex = 3;
            this.button提交.Text = "提交修改";
            this.button提交.UseVisualStyleBackColor = true;
            this.button提交.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加内容ToolStripMenuItem,
            this.替换内容ToolStripMenuItem,
            this.删除内容ToolStripMenuItem,
            this.批量删除ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.设置后缀名过滤ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加内容ToolStripMenuItem
            // 
            this.添加内容ToolStripMenuItem.Name = "添加内容ToolStripMenuItem";
            this.添加内容ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加内容ToolStripMenuItem.Text = "添加内容";
            this.添加内容ToolStripMenuItem.Click += new System.EventHandler(this.添加内容ToolStripMenuItem_Click);
            // 
            // 替换内容ToolStripMenuItem
            // 
            this.替换内容ToolStripMenuItem.Name = "替换内容ToolStripMenuItem";
            this.替换内容ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.替换内容ToolStripMenuItem.Text = "替换内容";
            this.替换内容ToolStripMenuItem.Click += new System.EventHandler(this.替换内容ToolStripMenuItem_Click);
            // 
            // 删除内容ToolStripMenuItem
            // 
            this.删除内容ToolStripMenuItem.Name = "删除内容ToolStripMenuItem";
            this.删除内容ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.删除内容ToolStripMenuItem.Text = "删除内容";
            this.删除内容ToolStripMenuItem.Click += new System.EventHandler(this.删除内容ToolStripMenuItem_Click);
            // 
            // 批量删除ToolStripMenuItem
            // 
            this.批量删除ToolStripMenuItem.Name = "批量删除ToolStripMenuItem";
            this.批量删除ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.批量删除ToolStripMenuItem.Text = "批量删除";
            this.批量删除ToolStripMenuItem.Click += new System.EventHandler(this.批量删除ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.粘贴ToolStripMenuItem.Text = "粘贴文件夹";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // 设置后缀名过滤ToolStripMenuItem
            // 
            this.设置后缀名过滤ToolStripMenuItem.Name = "设置后缀名过滤ToolStripMenuItem";
            this.设置后缀名过滤ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.设置后缀名过滤ToolStripMenuItem.Text = "设置后缀名过滤";
            this.设置后缀名过滤ToolStripMenuItem.Click += new System.EventHandler(this.设置后缀名过滤ToolStripMenuItem_Click);
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(466, 9);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(0, 12);
            this.labelExtension.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 415);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.button提交);
            this.Controls.Add(this.textBox内容);
            this.Controls.Add(this.textBox文件名);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "批量重命名助手";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox文件名;
        private System.Windows.Forms.TextBox textBox内容;
        private System.Windows.Forms.Button button提交;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置后缀名过滤ToolStripMenuItem;
        private System.Windows.Forms.Label labelExtension;
    }
}

