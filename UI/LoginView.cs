using LibraryApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Login;

namespace UI
{
    public partial class LoginController : Form
    {

        private IUserService service = UserService.GetInstence();

        public LoginController()
        {
       
            InitializeComponent();
        }

        private void Login()
        {

        }

   
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterView view = new RegisterView();
            view.Show();
            Hide();
        }
    }
}
