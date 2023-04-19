using AxWMPLib;
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

namespace VideoSelect
{
    public partial class videoSelect : Form
    {
        public videoSelect()
        {
            InitializeComponent();
            infomation.Text = string.Empty;
        }
        string[] fileNames;
        string currentFile;
        int currentIndex = 0;
        private void readDatasetPath_Click(object sender, EventArgs e)
        {
            fileNames = Directory.GetFiles(textBox1.Text);
            Directory.CreateDirectory(textBox1.Text + "\\Selected");
            currentFile = fileNames[currentIndex];
            axWindowsMediaPlayer2.URL = currentFile;
            infomation.Text += $"读取成功！一共找到{fileNames.Length}个文件！\n";
        }

        private void axWindowsMediaPlayer2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                File.Copy(currentFile, textBox1.Text + "\\Selected\\" + Path.GetFileName(currentFile));
                currentFile = fileNames[++currentIndex];
                axWindowsMediaPlayer2.URL = currentFile;
            }
            else if (e.KeyCode == Keys.Down)
            {
                currentFile = fileNames[++currentIndex];
                axWindowsMediaPlayer2.URL = currentFile;
            }
        }
    }
}
