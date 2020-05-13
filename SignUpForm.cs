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
    public partial class SignUpForm : Form
    {
        public static Akun akun = new Akun();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                
                akun.Email = tbEmail.Text;
                akun.Password = tbPassword.Text;
                akun.Nama = tbNama.Text;
                akun.TanggalLahir = dtpDateOfBirtf.Value.ToString();
                akun.JenisKelamin = cbGender.SelectedItem.ToString();
                akun.Alamat = rtbAddress.Text;

                context.Akuns.Add(akun);
                context.SaveChanges();
           

                if (akun.Email != null && akun.Password != null && akun.Nama != null && akun.TanggalLahir != null && akun.JenisKelamin != null && akun.Alamat != null)
                {
                    LoginForm loginForm = new LoginForm();
                    MessageBox.Show("Akun berhasil dibuat");
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data yang diisi belum lengkap");
                }
                
            }
           
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
