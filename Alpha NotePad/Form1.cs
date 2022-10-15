using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alpha_NotePad
{
    
    public partial class Form1 : Form
    {
        int count;
        string trimmed_txt;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StreamReader OpenFile = new
            System.IO.StreamReader(openFileDialog1.FileName);
            richTextBox1.Text = OpenFile.ReadToEnd();
            OpenFile.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SaveFile = new
            System.IO.StreamWriter(openFileDialog1.FileName);
            SaveFile.WriteLine(richTextBox1.Text);
            SaveFile.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            System.IO.StreamWriter SaveFile = new
            System.IO.StreamWriter(saveFileDialog1.FileName);
            SaveFile.WriteLine(richTextBox1.Text);
            SaveFile.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Please Write Something";
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)

            {
                richTextBox1.Font = fontDialog1.Font;

            }
        }

        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown)
            {
                toolStripStatusLabel2.Text = "Moving Down";
            }
            else
            {
                toolStripStatusLabel2.Text = " ";
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                toolStripStatusLabel2.Text = "Moving Upwards";
            }
            else
            {
                toolStripStatusLabel2.Text = " ";
            }
        }

        private void richTextBox1_StyleChanged(object sender, EventArgs e)
        {   
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            
                toolStripStatusLabel3.Text = "Font Changed To - " + Font.Name;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_ForeColorChanged(object sender, EventArgs e)
        {
            if(ForeColor.IsKnownColor == true)
            {
                toolStripStatusLabel4.Text = ForeColor.Name.ToString();
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
