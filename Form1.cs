using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_baitap10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want really want to close ?", "Ex1",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            String s;
            s = "My name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYearofbirth.Text);//Current Year - Enter year
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);

        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter your name");
            else
                this.errorProvider1.Clear();
 
        }

        private void txtYearofbirth_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not avalid number ");
            else
                this.errorProvider1.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear text 
            txtYourName.Clear();
            txtYearofbirth.Clear();
            //textbox your name reset focus 
            txtYourName.Focus();
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {

        }
    }
}
