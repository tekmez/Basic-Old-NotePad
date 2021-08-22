using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();//Starting Timer
            
        }

        private void new_opn(object sender, EventArgs e)
        {
            // Open File
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }
        private void new_prc(object sender, EventArgs e)
        {
            // New file
            this.Text = "Text File -> Unsave";
            richTextBox1.Text = "";
        }

        private void save_as(object sender, EventArgs e)
        {
            // Save As
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void save(object sender, EventArgs e)
        {
            // Save
            if (openFileDialog1.FileName != "")
            {
                richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            else
                if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Date
            toolStripStatusLabel1.Text = "Date: " + Convert.ToString(DateTime.Now).Substring(0, 10);
            //Time
            toolStripStatusLabel2.Text = "Time: " + Convert.ToString(DateTime.Now).Substring(9, 8);
        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new_opn(sender, e);//Open
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            new_prc(sender, e);//New
        }

        private void yeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new_prc(sender, e);//New
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            new_opn(sender, e);//Open
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            save_as(sender, e);//Save As
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save_as(sender, e);//Save as
        }

        private void farklıKaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save_as(sender, e);//Save as
        }

        private void kaydetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            save_as(sender, e);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_as(sender, e);
            this.Close();
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save_as(sender, e);
            this.Close();
        }

        private void yazdırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();//Print
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();//Print
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();//Undo
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();//Cut
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();//Copy
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//Paste
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();//Delete
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void yardımKonularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();
            helpForm.Show();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();
            helpForm.Show();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//Paste
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();//Cut
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();//Copy
        }
    }
}
