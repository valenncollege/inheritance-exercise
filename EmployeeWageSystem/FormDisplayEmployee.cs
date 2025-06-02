using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWageSystem
{
    public partial class FormDisplayEmployee : Form
    {
        public FormDisplayEmployee()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void FormDisplayEmployee_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (TemporaryEmployee i in formUtama.listTemporary)
            {
                listBoxInfo.Items.AddRange(i.Display().Split('\n'));
            }
            foreach (RegularEmployee i in formUtama.listRegular)
            {
                listBoxInfo.Items.AddRange(i.Display().Split('\n'));
            }
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (RegularEmployee i in formUtama.listRegular)
            {
                listBoxInfo.Items.AddRange(i.Display().Split('\n'));
            }
        }

        private void radioButtonTemporary_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (TemporaryEmployee i in formUtama.listTemporary)
            {
                listBoxInfo.Items.AddRange(i.Display().Split('\n'));
            }
        }
    }
}
