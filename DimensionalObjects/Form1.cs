using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W12A_Jevon_Valentino_160424066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
        }
        public List<Coord2D> list2D = new List<Coord2D>();
        public List<Coord3D> list3D = new List<Coord3D>();
        private void buttonSaveObject_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBoxX.Text);
                int y = int.Parse(textBoxY.Text);
                if (radioButton3D.Checked)
                {
                    int z = int.Parse(textBoxZ.Text);
                    Coord3D newCoord3D = new Coord3D(x, y, z);
                    list3D.Add(newCoord3D);
                    listBoxInfo.Items.Add(newCoord3D.Display());
                }
                else
                {
                    Coord2D newCoord2D = new Coord2D(x, y);
                    list2D.Add(newCoord2D);
                    listBoxInfo.Items.Add(newCoord2D.Display());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2D_CheckedChanged(object sender, EventArgs e)
        {
            textBoxZ.Enabled = false;
            textBoxZ1.Enabled = false;
            textBoxZ2.Enabled = false;
        }

        private void radioButton3D_CheckedChanged(object sender, EventArgs e)
        {
            textBoxZ.Enabled = true;
            textBoxZ1.Enabled = true;
            textBoxZ2.Enabled = true;
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Object in list 2D:");
            foreach (Coord2D i in list2D)
            {
                listBoxInfo.Items.Add(i.Display());
            }
            listBoxInfo.Items.Add("Object in list 3D:");
            foreach (Coord3D i in list3D)
            {
                listBoxInfo.Items.Add(i.Display());
            }
        }

        private void buttonCalculateDistance_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(textBoxX1.Text);
            int x2 = int.Parse(textBoxX2.Text);
            int y1 = int.Parse(textBoxY1.Text);
            int y2 = int.Parse(textBoxY2.Text);

            if (radioButton2D.Checked)
            {
                Coord2D Object1 = new Coord2D(x1, y1);
                Coord2D Object2 = new Coord2D(x2, y2);
                double result = Object1.CalculateDistance(Object2);
                listBoxInfo.Items.Add("Distance beetween " + Object1.Display() + " and " + Object2.Display() + " = " +
                    result);
            }
            else
            {
                int z1 = int.Parse(textBoxZ1.Text);
                int z2 = int.Parse(textBoxZ2.Text);
                Coord3D Object1 = new Coord3D(x1, y1, z1);
                Coord3D Object2 = new Coord3D(x2, y2, z2);
                double result = Object1.CalculateDistance(Object2);
                listBoxInfo.Items.Add("Distance beetween " + Object1.Display() + " and " + Object2.Display() + " = " +
                    result);
            }
        }
    }
}
