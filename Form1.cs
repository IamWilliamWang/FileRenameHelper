using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 重命名助手
{
    public partial class Form1 : Form
    {
        DirectoryInfo folder = null;
        FileInfo[] files = null;
        StringBuilder log = new StringBuilder();
        String extension = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] newNames = this.textBox内容.Lines;
            if (newNames.Count() != files.Count())
            {
                MessageBox.Show("错误！文件数量被改变");
                return;
            }
            String nowTime = DateTime.Now.ToLocalTime().ToString();
            log.AppendLine("------------------- " + nowTime + " -------------------");
            log.AppendLine("文件夹:" + textBox文件名.Text);
            log.Append("--------------------");
            for (int i = 0; i < nowTime.Length; i++)
                log.Append("-");
            log.AppendLine("--------------------");
            for (int i = 0; i < files.Count(); i++)
            {
                if (files[i].Name == newNames[i])
                    continue;
                FileUtil.Rename(files[i], newNames[i]);
                log.AppendLine(files[i].Name + " --> " + newNames[i]);
            }
            this.textBox内容.Text = log.ToString();
            File.AppendAllText("log.txt", log.ToString());
            ClearAll();
        }

        private void ClearAll()
        {
            folder = null;
            files = null;
            log.Clear();
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            this.textBox文件名.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            DirectoryInfo directory = new DirectoryInfo(this.textBox文件名.Text);
            if (!directory.Exists)
            {
                this.textBox文件名.Text = "";
                this.textBox内容.Text = "提示：只能拖入文件夹！";
                return;
            }
            this.folder = directory;
            files = folder.GetFiles();
            ShowFilesInTextbox();
        }

        private void ShowFilesInTextbox()
        {
            StringBuilder maintext = new StringBuilder();
            foreach (FileInfo file in files)
                maintext.AppendLine(file.Name);
            this.textBox内容.Text = maintext.ToString().Trim();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox文件名.Text = Clipboard.GetText();
                folder = new DirectoryInfo(this.textBox文件名.Text);
                files = folder.GetFiles();
                ShowFilesInTextbox();
            }
            catch { }
        }

        private void 添加内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newContent = Microsoft.VisualBasic.Interaction.InputBox("请输入新字符串的内容，使用``代表源字符串", "输入");
            if (newContent == "")
                return;
            string[] lines = this.textBox内容.Lines;
            for (int i = 0; i < lines.Count(); i++)
            {
                if (this.PassFilter(lines[i]))
                    lines[i] = newContent.Replace("``", lines[i]);
            }
            this.textBox内容.Lines = lines;
        }

        private void 删除内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string delContent = Microsoft.VisualBasic.Interaction.InputBox("请输入要删除字符串中的内容", "输入");
            if (delContent == "")
                return;
            string[] lines = this.textBox内容.Lines;
            for (int i = 0; i < lines.Count(); i++)
            {
                if (this.PassFilter(lines[i]))
                    lines[i] = lines[i].Replace(delContent, "");
            }
            this.textBox内容.Lines = lines;
        }

        private void 替换内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string old = Microsoft.VisualBasic.Interaction.InputBox("要替换字符串的内容", "输入");
            if (old == "")
                return;
            string _new = Microsoft.VisualBasic.Interaction.InputBox("要替换字符串的新内容", "输入");
            string[] lines = this.textBox内容.Lines;
            for (int i = 0; i < lines.Count(); i++)
            {
                if (this.PassFilter(lines[i]))
                    lines[i] = lines[i].Replace(old, _new);
            }
            this.textBox内容.Lines = lines;
        }

        private void 批量删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string delContent = Microsoft.VisualBasic.Interaction.InputBox("警告，本操作将删除在下方输入的所有的字符内容。请输入要删除的所有字符内容：", "输入");
            if (delContent == "")
                return;
            string[] lines = this.textBox内容.Lines;
            for (int i = 0; i < lines.Count(); i++)
            {
                if (this.PassFilter(lines[i]))
                    foreach (char ch in delContent)
                        lines[i] = lines[i].Replace(ch + "", "");
            }
            this.textBox内容.Lines = lines;
        }

        private void 设置后缀名过滤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string extension = Microsoft.VisualBasic.Interaction.InputBox("请设置要修改文件的后缀名");
            if (extension == "")
            {
                this.extension = null;
                this.labelExtension.Text = "";
                return;
            }
            this.extension = extension;
            this.labelExtension.Text = "[." + extension.Replace(".", "") + "]";
            MessageBox.Show("设置成功！");
        }

        private bool PassFilter(string filename)
        {
            if (this.extension == null)
                return true;
            if (filename.EndsWith(this.extension))
                return true;
            return false;
        }
    }
}
