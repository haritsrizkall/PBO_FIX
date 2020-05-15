using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPBO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                Akun akun = context.Akuns.FirstOrDefault(a => a.Email == tbEmail.Text);
                if (akun == null)
                {
                    MessageBox.Show("Email tidak ada");
                }
                else
                {
                     if (akun.Password == tbPassword.Text)
                    {
                        
                        MainForm mainForm = new MainForm();
                        //VariablePublic.memUserEmail = tbEmail.Text;
                        VariablePublic.UserId = akun.Id;
                        //mainForm._textBox = _textBoxEmail;

                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password Salah");
                    }
                }
               
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
