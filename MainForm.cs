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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                Akun akun = context.Akuns.FirstOrDefault(a => a.Id == VariablePublic.UserId);
                lblNama.Text = akun.Nama;
                AkunPenyakit akunPenyakit = context.AkunPenyakits.FirstOrDefault(b => b.IdAkun == VariablePublic.UserId);
               /* try
                {
                    lblJadwal1.Text = akunPenyakit.JadwalKonsul;
                }
                catch (Exception)
                {
                    lblJadwal1.Text = "Tidak Ada Jadwal";
                }*/
            }
                
        }

        private void btnBuatKeluhan_Click(object sender, EventArgs e)
        {
            KeluhanForm keluhanForm = new KeluhanForm();
            
            keluhanForm.Show();
            this.Hide();
        }

        private void lblJadwal1_Click(object sender, EventArgs e)
        {

        }

        private void btnCariDokter_Click(object sender, EventArgs e)
        {
            InfoJadwalForm infoJadwalForm = new InfoJadwalForm();
            infoJadwalForm.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            InfoProfile infoProfile = new InfoProfile();
            infoProfile.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Show();
            this.Close();
        }
    }
}
