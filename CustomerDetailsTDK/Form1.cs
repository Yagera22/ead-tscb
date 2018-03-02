using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Tariq Kellyman #1600197760
//Sachell Anderson #
//Cleon Whittick #
//Brandon Chan #

namespace CustomerDetailsTDK
{
    public partial class formMovie : Form
    {
        public formMovie()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = String.Empty;
            txtLName.Text = String.Empty;
            txtStreet.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtTotVid.Text = String.Empty;
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
            rdbNo.Checked = false;
            rdbYes.Checked = false;
            cboxPackage.Text = String.Empty;
            cboxParish.Text = String.Empty;

           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = "Name:\t" + txtFName.Text + " " + txtLName.Text;
            String address = "Address:\t" + txtStreet.Text + ", " + txtCity.Text + ", " + cboxParish.Text;
            String package = "Package & Videos:\t" + cboxPackage.Text + ", " +  txtTotVid.Text;

            String vod = "";
            bool isCheckedVOD = rdbYes.Checked;
            if (isCheckedVOD)
                vod = rdbYes.Text;
            else
                vod = rdbNo.Text;

            String gender = "";
            bool isCheckedGen = rdbMale.Checked;
            if (isCheckedGen)
                gender = rdbMale.Text;
            else
                gender = rdbFemale.Text;

            MessageBox.Show(name + "\n" + address + "\n" + "Gender:\t" + gender + "\n" + package + "\n" + "VOD:\t" + vod);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
