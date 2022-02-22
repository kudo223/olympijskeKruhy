using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Kunc
{
    public partial class Form1 : Form
    {
        List<Kruhy> kruhyList;
        public Form1()
        {
            InitializeComponent();
            kruhyList = new List<Kruhy>();
        }

        private void pBox1_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pBox1.BackColor;
            colorDialog.ShowDialog();
            pBox1.BackColor = colorDialog.Color;
        }

        private void pBox2_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pBox2.BackColor;
            colorDialog.ShowDialog();
            pBox2.BackColor = colorDialog.Color;
        }

        private void pBox3_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pBox3.BackColor;
            colorDialog.ShowDialog();
            pBox3.BackColor = colorDialog.Color;
        }

        private void pBox4_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pBox4.BackColor;
            colorDialog.ShowDialog();
            pBox4.BackColor = colorDialog.Color;
        }

        private void pBox5_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pBox5.BackColor;
            colorDialog.ShowDialog();
            pBox5.BackColor = colorDialog.Color;
        }

        private void pBox_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                Random random = new Random();
                Kruhy kruhy = new Kruhy(pBox1.BackColor, pBox2.BackColor, pBox3.BackColor, pBox4.BackColor, pBox5.BackColor, Convert.ToInt32(numeric1.Value), Convert.ToInt32(numeric2.Value), Convert.ToInt32(numeric3.Value));
                kruhy.Lokace = new Point(random.Next(0, pBox.Width), random.Next(0, pBox.Height));
                kruhyList.Add(kruhy);
            }
            else
            {
                Kruhy kruhy = new Kruhy(pBox1.BackColor, pBox2.BackColor, pBox3.BackColor, pBox4.BackColor, pBox5.BackColor, Convert.ToInt32(numeric1.Value), Convert.ToInt32(numeric2.Value), Convert.ToInt32(numeric3.Value));
                kruhy.Lokace = new Point(numeric2.Width, numeric3.Height);
                kruhyList.Add(kruhy);
            }
            pBox.Refresh();
        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            foreach(var kruhy in kruhyList)
            {
                kruhy.Draw(e.Graphics);
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
