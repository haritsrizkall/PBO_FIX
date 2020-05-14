using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UASPBO
{
    public partial class BuatJadwalForm : Form
    {

        string connectionString = ConfigurationManager
.ConnectionStrings["UASPBO.Properties.Settings.ConnString"]
.ConnectionString;
        public BuatJadwalForm()
        {
            InitializeComponent();
        }

        private void BuatJadwal_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                AkunPenyakit akunPenyakit = context.AkunPenyakits.FirstOrDefault(a => a.IdAkun == VariablePublic.UserId);
                Dokter dokter = context.Dokters.FirstOrDefault(d => d.Id == VariablePublic.UserPenyakitId);
                lblNamaDokter.Text = dokter.NamaDokter;
                akunPenyakit.IdDokter = dokter.Id;
                context.SaveChanges();
            }


        }

        private void btnBuatJadwal_Click(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                AkunPenyakit akunPenyakit = context.AkunPenyakits.FirstOrDefault(a => a.IdAkun == VariablePublic.UserId);
                if (cbJadwal1.Checked)
                {
                    akunPenyakit.JadwalKonsul = cbJadwal1.Text ;
                    context.SaveChanges();
                }
                else if (cbJadwal2.Checked)
                {
                    akunPenyakit.JadwalKonsul = cbJadwal2.Text;
                    context.SaveChanges();
                }

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
           
        }
    }
}
