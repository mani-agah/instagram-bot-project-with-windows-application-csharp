using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class EditProfile : Form
    {
        public IInstaApi api;
        public EditProfile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var edit = await Context.api.AccountProcessor
            .EditProfileAsync(txtName.Text, txtBio.Text,
            txtWebUrl.Text, txtEmail.Text, txtMobile.Text,
            (radMale.Checked) ? InstaGenderType.Male : InstaGenderType.Female,
            txtUserName.Text);
            if (edit.Succeeded)
            {
                MessageBox.Show("done successfully");
                this.Close();
            }
        }

        private async void EditProfile_Load(object sender, EventArgs e)
        {
            var editProfile = await api.AccountProcessor.GetRequestForEditProfileAsync();
            if (editProfile.Succeeded)
            {
                txtBio.Text = editProfile.Value.Biography;
                txtEmail.Text = editProfile.Value.Email;
                txtMobile.Text = editProfile.Value.PhoneNumber;
                txtName.Text = editProfile.Value.FullName;
                txtWebUrl.Text = editProfile.Value.ExternalUrl;
                txtUserName.Text = editProfile.Value.Username;
                if (editProfile.Value.Gender == InstagramApiSharp.Enums.InstaGenderType.Male)
                {
                    radMale.Checked = true;
                }
                else
                {
                    radMale.Checked = true;
                }
            }
        }
    }
}