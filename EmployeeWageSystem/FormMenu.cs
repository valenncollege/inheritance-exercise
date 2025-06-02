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
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeeWageSystem
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public string defaultRegularName = "RegEmployee.dat";
        public string defaultTempName = "TempEmployee.dat";
        public List<RegularEmployee> listRegular = new List<RegularEmployee>();
        public List<TemporaryEmployee> listTemporary = new List<TemporaryEmployee>();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SaveReg(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listRegular);
            myFile.Close();
        }
        public void OpenReg(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listRegular = (List<RegularEmployee>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }
        public void SaveTemp(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listTemporary);
            myFile.Close();
        }
        public void OpenTemp(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listTemporary = (List<TemporaryEmployee>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            OpenReg(defaultRegularName);
            OpenTemp(defaultTempName);
        }

        private void inputEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputEmployee formInput = new FormInputEmployee();
            formInput.Owner = this;
            formInput.ShowDialog();
        }

        private void displayEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayEmployee formDisplay = new FormDisplayEmployee();
            formDisplay.Owner = this;
            formDisplay.ShowDialog();
        }
    }
}
