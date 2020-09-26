using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Windows实验2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(od.FileName !=""&& richTextBox1_TextChanged==true &&MessageBox.Show("文本内容已更改\n是否保存修改？","信息提示",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(od.FileName,RichTextBoxStreamType.PlainText)
            }
            od.FileName = "";
            this.Text = "记事本";
            this.richTextBox1.Clear();
            this.richTextBox1_TextChanged = false;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                Color color = colorDialog.Color;
                test.SelectionColor = color;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog FiLO = new SaveFileDialog();
            FiLO.Filter = "文本文件(*.txt)|*.txt";
            FiLO.RestoreDirectory = true;
            if(FiLO.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(FiLO.FileName, true);
                sw.WriteLine(text)
            }
        }
    }
}
