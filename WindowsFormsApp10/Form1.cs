using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using InstagramApiSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using InstagramApiSharp.API;
using System.Runtime.InteropServices;
using InstagramApiSharp.Classes.Models;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private static UserSessionData user;
        private static IInstaApi api;

        public Form1()
        {
            InitializeComponent();
        }


        private async void Form1_Load_1(object sender, EventArgs e)
        {
            GbCmd.Enabled = false;
            GbFollowers.Enabled = false;
            GbFollowing.Enabled = false;
            GbProfile.Enabled = false;
            GbDirect.Enabled = false;
            GbTools.Enabled = false;
            GbBlocked.Enabled = false;
        }

        private async void btnLgoin_Click(object sender, EventArgs e)
        {
            user = new UserSessionData();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                .Build();
            var loginReq = await api.LoginAsync();
            if (loginReq.Succeeded)
            {
                GbCmd.Enabled = true;
                GbFollowers.Enabled = true;
                GbFollowing.Enabled = true;
                GbTools.Enabled = true;
                GbDirect.Enabled = true;
                GbProfile.Enabled = true;
                GbBlocked.Enabled = true;
                pictureBox1.Load(api.GetLoggedUser().LoggedInUser.ProfilePicUrl);
            }
            else
            {
                MessageBox.Show(loginReq.Info.Message);
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                byte[] pic = System.IO.File.ReadAllBytes(op.FileName);
                var res = await api.AccountProcessor.ChangeProfilePictureAsync(pic);
                if (res.Succeeded)
                {
                    pictureBox1.ImageLocation = op.FileName;
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = await api.AccountProcessor.RemoveProfilePictureAsync();
            if (delete.Succeeded)
            {
                pictureBox1.Image = null;

            }
        }

        private async void btnFOllowers_Click(object sender, EventArgs e)
        {
            var followers = await api.UserProcessor.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(2));
            foreach (var f in followers.Value)
            {
                dgvFollowers.Rows.Add(f.UserName, f.FullName);

            }
        }

        private async void btnFollowing_Click_1(object sender, EventArgs e)
        {
            var CurentUserName = await api.UserProcessor.GetCurrentUserAsync();
            var following = await api.UserProcessor.GetUserFollowingAsync(CurentUserName.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            foreach (var f in following.Value)
            {
                dgvFollowing.Rows.Add(f.UserName, f.FullName);

            }
        }

        private async void btnFollow_Click(object sender, EventArgs e)
        {
            var user = await api.UserProcessor.GetUserAsync(txtUserNameForFollow.Text);
            var follow = await api.UserProcessor.FollowUserAsync(user.Value.Pk);
            if (follow.Succeeded)
            {
                btnFollowing.PerformClick();
            }
        }

        private async void btnUnfllow_Click(object sender, EventArgs e)
        {
            var user = await api.UserProcessor.GetUserAsync(txtUserNameForFollow.Text);
            var unfollow = await api.UserProcessor.UnFollowUserAsync(user.Value.Pk);
            if (unfollow.Succeeded)
            {
                btnFollowing.PerformClick();
            }
        }

        private async void btnBlock_Click(object sender, EventArgs e)
        {
            var users = await api.UserProcessor.GetBlockedUsersAsync(PaginationParameters.MaxPagesToLoad(2));
            foreach (var f in users.Value.BlockedList)
            {
                dgvBlocked.Rows.Add(f.UserName, f.FullName);
            }
        }

        private async void btnUblock_Click(object sender, EventArgs e)
        {
            var users = await api.UserProcessor.GetUserAsync(txtUserNameForFollow.Text);
            var block = api.UserProcessor.BlockUserAsync(users.Value.Pk);
            btnBlock.PerformClick();
        }

        private void dgvBlocked_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvBlocked.CurrentRow.Cells[0].Value;
            txtUserNameForFollow.Text = id.ToString();
        }

        private async void txtUserNameForFollow_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var user = await api.UserProcessor.GetUserAsync(txtUserNameDirect.Text);
            var direct = await api.MessagingProcessor.SendDirectTextAsync(user.Value.Pk.ToString(), null, txtMessage.Text);
            if (direct.Succeeded)
            {
                MessageBox.Show("message sended...");
            }
        }

        private async void txtSendImage_Click(object sender, EventArgs e)
        {
            var inbox = await api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(2));
            var threedID = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == txtUserNameDirect.Text).ThreadId;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            var imagee = new InstaImage
            {
                Uri = dialog.FileName
            };
            var image = await api.MessagingProcessor.SendDirectPhotoAsync(imagee, threedID);
            if (image.Succeeded)
            {
                MessageBox.Show("image sended...");
            }
            else
            {
                MessageBox.Show(image.Info.Message);
            }
        }

        private async void btnSendVideo_Click(object sender, EventArgs e)
        {
            var inbox = await api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(2));

            var threedID = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == txtUserNameDirect.Text).ThreadId;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            var videoo = new InstaVideo
            {
                Uri = dialog.FileName
            };
            var videoUpload = new InstaVideoUpload()
            {
                Video = videoo
            };
            var video = await api.MessagingProcessor.SendDirectVideoAsync(videoUpload, threedID);
            if (video.Succeeded)
            {
                MessageBox.Show("image sended...");
            }
            else
            {
                MessageBox.Show(video.Info.Message);
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new EditProfile()).ShowDialog();
        }

        private void btnResentEvents_Click(object sender, EventArgs e)
        {
            (new Activity()).ShowDialog();
        }
    }
}
