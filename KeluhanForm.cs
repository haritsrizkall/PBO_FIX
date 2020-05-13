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
    public partial class KeluhanForm : Form
    {
        private string nama;
        public string _SetNama
        {
            set { nama = value; }
        }
        /*private string email;
        public string _GetEmail
        {
            set { email = value; }
        }*/
        public KeluhanForm()
        {
            InitializeComponent();
        }

        private void KeluhanForm_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                var pnykt1 = new Penyakit() { NamaPenyakit = "Penyakit Jantung" };
                context.Penyakits.Add(pnykt1);
                var pnykt2 = new Penyakit() { NamaPenyakit = "Penyakit Kulit" };
                context.Penyakits.Add(pnykt2);
                var pnykt3 = new Penyakit() { NamaPenyakit = "Penyakit THT" };
                context.Penyakits.Add(pnykt3);
                var pnykt4 = new Penyakit() { NamaPenyakit = "Penyakit Pencernaan" };
                context.Penyakits.Add(pnykt4);
                var pnykt5 = new Penyakit() { NamaPenyakit = "Penyakit Gigi" };
                context.Penyakits.Add(pnykt5);

                context.SaveChanges();
            }
        }

        private void btnInputKeluhan_Click(object sender, EventArgs e)
        {
            int indexPenyakit = cmbKeluhan.Items.IndexOf(cmbKeluhan.SelectedItem.ToString())+1;
            using (CekDokEntities context = new CekDokEntities())
            {
                AkunPenyakit akunPenyakit = new AkunPenyakit();
                Akun akun = context.Akuns.FirstOrDefault(a => a.Email == VariablePublic.memUserEmail);
                akunPenyakit.IdPenyakit = indexPenyakit;
                akunPenyakit.IdAkun = akun.Id;
                akunPenyakit.DeskripsiKeluhan = rtbKeluhan.Text;

                context.AkunPenyakits.Add(akunPenyakit);

                if (cb1Hari.Checked)
                {
                    akunPenyakit.LamaSakit = "1 Hari";
                }
                else if (cb2Hari.Checked)
                {
                    akunPenyakit.LamaSakit = "2-3 Hari";
                }
                else if (cb1Minggu.Checked)
                {
                    akunPenyakit.LamaSakit = "1 Minggu";
                }
                else if (cb2Minggu.Checked)
                {
                    akunPenyakit.LamaSakit = ">2 Minggu";
                }
               
                KeluhanBerhasilForm keluhanBerhasilForm = new KeluhanBerhasilForm();
                keluhanBerhasilForm.Show();
                this.Hide();
            }
        }
    }
}
