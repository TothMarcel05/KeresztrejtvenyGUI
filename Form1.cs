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
using static System.Net.Mime.MediaTypeNames;

namespace KeresztrejtvenyGUI
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        public static int sorok = 15;
        public static int oszlopok = 15;


        private void Form1_Load(object sender, EventArgs e)
        {
            //10. a.
            for (int i = 6; i < 16; i++)
            {
                this.sor.Items.Add(i);
                this.oszlop.Items.Add(i);
            }
            this.sor.SelectedItem = 15;
            this.oszlop.SelectedItem = 15;

            for (int i = 1; i < 11; i++)
            {
                this.index.Items.Add(i);
            }
            this.index.SelectedItem = 3;


        }

        //10. b.
        private void letrehozasButton_Click(object sender, EventArgs e)
        {
            mentesButton.Enabled = true;

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {

                    this.Controls.Remove(this.Controls[$"txt_{i}_{j}"]);

                }
            }
            
            int x = 20;
            int y = 90;

            sorok = Convert.ToInt32(this.sor.SelectedItem);
            oszlopok = Convert.ToInt32(this.oszlop.SelectedItem);

            int height = this.Height - y - 10;
            int width = this.Width - x * 2;

            int tablaheight = sorok * 26;
            int tablawidth = oszlopok * 26;

            int a = (width - tablawidth) / 2;
            int b = (height - tablaheight) / 2;



            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Location = new Point(a + j * 26, y + b + i * 26);
                    txt.Size = new Size(25, 25);
                    txt.Text = "-";
                    txt.Name = $"txt_{i}_{j}";

                    txt.MaxLength = 1; 
                    txt.TextAlign = HorizontalAlignment.Center;



                    txt.DoubleClick += textboxChange_DoubleClick;
                    Controls.Add(txt);
                }
            }


        //10. c.
        }
        private void textboxChange_DoubleClick(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "-") txt.Text = "#";
            else txt.Text = "-";
        }


        //10. d.
        private void mentesButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter($"kr{index.SelectedItem}.txt");
                for (int i = 0; i < sorok; i++)
                {
                    for (int j = 0; j < oszlopok; j++)
                    {
                   
                       sw.Write(this.Controls[$"txt_{i}_{j}"].Text);
   
                    }
                    sw.WriteLine();
                }
                sw.Close();

                MessageBox.Show("A keresztrejtvény mentése sikeres!");
            }
            catch (Exception hiba) 
            {
                MessageBox.Show(hiba.ToString()); 
            }
            
        }
    }
}
