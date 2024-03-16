using PictureBox_using_comboBox.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_using_comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Boy":
                    pictureBox1.Image = Resources.Boy;
                    lbTitle.Text = "Boy";
                    break;
             case "Girl":
                    pictureBox1.Image = Resources.Girl;
                    lbTitle.Text = "Girl";
                    break;
             case "Pen":
                    pictureBox1.Image = Resources.Pen;
                    lbTitle.Text = "Pen";
                    break;
             case "Book":
                    pictureBox1.Image = Resources.Book;
                    lbTitle.Text = "Book";
                    break;
            
            
            
            
            
            
            
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

        }
    }
}
