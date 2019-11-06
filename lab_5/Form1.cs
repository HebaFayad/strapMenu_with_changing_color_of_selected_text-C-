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

namespace lab_5
{
    public partial class Form1 : Form
    {
        StreamReader sReader;
        StreamWriter sWriter;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void men_font_Click(object sender, EventArgs e)
        {
            Font_D.Font = Rtxt_file.Font;

            if(Font_D.ShowDialog()!=DialogResult.Cancel)
            {
                Rtxt_file.Font = Font_D.Font;
            }
        }

        private void men_fontColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Rtxt_file.ForeColor;
            var selection = Rtxt_file.SelectionColor;
          /*  if (colorDialog1.ShowDialog()!=DialogResult.Cancel)
            {
                // Rtxt_file.ForeColor = colorDialog1.Color;
                if (!selection.IsEmpty)
                    selection = colorDialog1.Color;
                MessageBox.Show("select");

            }*/

            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                if (Rtxt_file.SelectedText != null)
                {
                    if (!string.IsNullOrEmpty(Rtxt_file.SelectedText))
                    {
                        Rtxt_file.SelectionColor = c.Color;
                    }
                }
            }
        }

        private void men_backColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Rtxt_file.BackColor;
            

            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Rtxt_file.BackColor = colorDialog1.Color;
 
            }

           
            
        }

        void tool_enable(bool b)
        {
            men_Save.Enabled = b;
            men_SaveAs.Enabled = b;
            men_Print.Enabled = b;
            men_PrintPer.Enabled = b;

            men_Undo.Enabled = b;
            men_Redo.Enabled = b;
            men_Cut.Enabled = b;
            men_Copy.Enabled = b;
            men_Past.Enabled = b;
            men_Selecall.Enabled = b;

            men_font.Enabled = b;
            men_Color.Enabled = b;

            Rtxt_file.Visible = b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tool_enable(false);
        }

        private void men_new_Click(object sender, EventArgs e)
        {
            Rtxt_file.Text = "";

            tool_enable(true);
        }

        private void men_open_Click(object sender, EventArgs e)
        {
            Rtxt_file.Text = "";

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "*.txt|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        tool_enable(true);
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            sReader = File.OpenText(openFileDialog1.FileName);
                            string txt_f;
                            while ((txt_f = sReader.ReadLine()) != null)
                            {
                                Rtxt_file.AppendText(txt_f + "\n");

                            }
                            TS_lblPath.Text = openFileDialog1.FileName;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error 004 : " + ex.Message);
                }
            }
        }

        private void men_SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.txt|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                if (saveFileDialog1.FileName != string.Empty)
                {
                    sWriter = new StreamWriter(saveFileDialog1.FileName);
                    string[] lines = Rtxt_file.Lines;
                    foreach (string l in lines)
                    {
                        sWriter.WriteLine(l);
                    }
                    sWriter.Close();
                    TS_lblPath.Text = saveFileDialog1.FileName;
                }
            }
        }

        private void men_Cut_Click(object sender, EventArgs e)
        {

        }

        private void men_Color_Click(object sender, EventArgs e)
        {

        }
    }
}
