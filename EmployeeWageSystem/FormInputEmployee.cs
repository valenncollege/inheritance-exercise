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
    public partial class FormInputEmployee : Form
    {
        public FormInputEmployee()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxId.Text;
                string name = textBoxName.Text;
                int basicSal = int.Parse(textBoxBasicSalary.Text);

                if (radioButtonRegular.Checked)
                {
                    int child = (int)numericUpDownNumberOfChildren.Value;
                    RegularEmployee newRegEmployee = new RegularEmployee(name, id, basicSal, child);
                    formUtama.listRegular.Add(newRegEmployee);
                    listBoxInfo.Items.AddRange(newRegEmployee.Display().Split('\n'));
                    formUtama.SaveReg(formUtama.defaultRegularName);
                }
                else
                {
                    DateTime start = dateTimePickerStartDate.Value;
                    DateTime end = dateTimePickerEndDate.Value;
                    TemporaryEmployee newTempEmployee = new TemporaryEmployee(end, start, basicSal, id, name);
                    formUtama.listTemporary.Add(newTempEmployee);
                    listBoxInfo.Items.AddRange(newTempEmployee.Display().Split('\n'));
                    formUtama.SaveTemp(formUtama.defaultTempName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputEmployee_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTemporary.Enabled = false;
            groupBoxRegular.Enabled = true;
        }

        private void radioButtonTemporary_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRegular.Enabled = false;
            groupBoxTemporary.Enabled = true;
        }
    }
}
