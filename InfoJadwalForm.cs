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
    public partial class InfoJadwalForm : Form
    {
        public InfoJadwalForm()
        {
            InitializeComponent();
        }

        private void lblJadwal1_Click(object sender, EventArgs e)
        {

        }

        private void InfoJadwalForm_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                AkunPenyakit akunPenyakit = context.AkunPenyakits.FirstOrDefault(a => a.IdAkun == VariablePublic.UserId);
                

                if (akunPenyakit != null)
                {
                    lblJadwal1.Text = akunPenyakit.JadwalKonsul;
                    lblNamaDokter.Text = akunPenyakit.Dokter.NamaDokter;
                }
                else
                {
                    lblJadwal1.Text = "Tidak ada Jadwal";
                    lblNamaDokter.Text = "";
                }
            }
           
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
