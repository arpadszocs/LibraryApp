using LibraryApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Login
{
    public partial class RegisterView : Form
    {


        private IUserService service = UserService.GetInstence();

        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            String username = nameBox.Text;
            String pass = passBox.Text;
            String repPass = repeatPassBox.Text;

            if (!pass.Equals(repPass))
            {
                MessageBox.Show("Passwords must match!");
            }
         //   else if (!Regex.Match(pass, "[A-Z]{3}[a-z]{5}[0-9]{5}").Success)  
           // {
           //
            //}
            else
            {
                UserDto userToRegsiter = new UserDto(username, pass);
                try
                {
                    service.RegisterUser(userToRegsiter);
                    Hide();
                    LoginController login = new LoginController();
                    login.Show();
                }
                catch (DuplicateUserException ex)
                {
                    MessageBox.Show("User allready exists");
                }
            }

         

        }
    }
}
