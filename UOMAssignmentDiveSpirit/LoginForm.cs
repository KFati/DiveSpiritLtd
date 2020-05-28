using AssignmentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UOMDiveSpirit.Business;
using UOMDiveSpirit.Common;
using WMPLib;
using System.Net.Mail;


namespace UOMAssignmentDiveSpirit
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        private MainMenu mainMenu;
        private ContextMenu popUpMenu;
        public LoginForm()
        {
            InitializeComponent();
            mainMenu = new MainMenu();
            popUpMenu = new ContextMenu();
            popUpMenu.MenuItems.Add("Hello", new EventHandler(pop_Clicked));
            this.ContextMenu = popUpMenu;
            MenuItem File = mainMenu.MenuItems.Add("&File");
            File.MenuItems.Add(new MenuItem("&New", new EventHandler(this.FileNew_clicked), Shortcut.CtrlN));
            File.MenuItems.Add(new MenuItem("-"));
            File.MenuItems.Add(new MenuItem("&Exit", new EventHandler(this.FileExit_clicked), Shortcut.CtrlX));
            this.Menu = mainMenu;
            MenuItem About = mainMenu.MenuItems.Add("&About");
            About.MenuItems.Add(new MenuItem("&About", new EventHandler(this.About_clicked), Shortcut.F1));
            this.Menu = mainMenu;


            //this is make the background of the following transparant when placing them in from of a picture
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;

            chkPassword.Parent = pictureBox2;
            chkPassword.BackColor = Color.Transparent;

            //Init skin (in ref to the material skin added as a NuGet package)
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.BLACK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add music when form is opened
            //Before adding that go to toolbox-->Chose Item ---> COM--->Windows Media Player
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\Users\Kaneez Fatima\Downloads\huawei_sms.mp3";
            wplayer.controls.play();

        }

        public string UserType;
        private void FileExit_clicked(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FileNew_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Please start by logging into our system", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pop_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Popupmenu", "MENU_CREATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void About_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Send your queries on : diveSpirit@infomail.com", "Dive Spirit Ltd welcomes you");
        }


        private clsUser objUser;
        private void SendSMS() //NOTIFIES ADMIN WHENEVER A USER LOGS IN THE SYSTEM
        {
            try
            {
                WebClient client = new WebClient();
                Stream s = client.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=9rmFpHLCSYexIIRjCxWRxg==&to=23058280243&content=" + txtUsername.Text + " logged in at " + DateTime.Now.ToShortTimeString() + " on " + DateTime.Now.ToShortDateString() + ""));

                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var objLoginBL = new clsLogInBL();
                var objLogInData = new clsLogInData();

                objLogInData.Username = txtUsername.Text;
                objLogInData.Password = txtPassword.Text;
                objLogInData.UserType = txtUserType.Text;

                objUser = objLoginBL.Login(objLogInData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
                return;
            }
            MessageBox.Show("Login succeeded");

            if (objUser.UserType.Equals("Admin"))
            {
                SendSMS(); //Send admin notif on mobile
                this.Hide();
                AdminMenu MyAdmin = new AdminMenu();
                MyAdmin.Show();
            }
            else if (objUser.UserType == "Employee")
            {
                SendSMS();
                this.Hide();
                EmployeeMenu MyEmployee = new EmployeeMenu();
                MyEmployee.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUserType_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserType.Text == string.Empty)
            {
                errorProvider1.SetError(txtUserType, "Please Enter UserType");
            }
            else
            {
                errorProvider1.SetError(txtUserType, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsername, "Please Enter Username");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Please Enter Password");
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUsername.Text != "")
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("jowaheerkf@gmail.com");
                mail.To.Add("kaneez.jowaheer@umail.uom.ac.mu");
                mail.Subject = $"Password change request {txtUsername.Text}";
                mail.Body += " <html>";
                mail.Body += "<body>";
                mail.Body += "<table>";
                mail.Body += "<tr>";
                mail.Body += "<td>Dear Admin,</td><br><br>";
                mail.Body += "</tr>";
                mail.Body += "<tr>";
                mail.Body += $"Please reset password for user {txtUsername.Text}<br><br>Thanks,<br>Kind regards,<br>Dive SpiritLTD<br><br><br><i><p style='color: gray'>This is an auto-generated email, please do not reply</p></i>";
                mail.Body += "</tr>";
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("jowaheerkf@gmail.com", "Theemojimovie21200");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Request for password reset sent to system administrator", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Please enter username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
