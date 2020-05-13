using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;


namespace UASPBO
{
    public partial class KeluhanForm : Form
    {
        string connectionString = ConfigurationManager
.ConnectionStrings["UASPBO.Properties.Settings.ConnString"]
.ConnectionString;
        private string nama;
       /* public string _SetNama
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
                T[] InitializeArray<T>(int length) where T : new()
                {
                    T[] array = new T[length];
                    for (int i = 0; i < length; ++i)
                    {
                        array[i] = new T();
                    }

                    return array;
                }
                Penyakit[] pnykt = InitializeArray<Penyakit>(5);
                string[] namaPenyakit = new string[5];
                //Penyakit[] pnykt = new Penyakit[5];
                string queryString = "SELECT Penyakit FROM DataPenyakit";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                DataSet dataSet = new DataSet();
                dbConnection.Open();
                OleDbDataAdapter dbAdapter = new OleDbDataAdapter(queryString, dbConnection);
                dbAdapter.Fill(dataSet, "Data Penyakit");
                dbConnection.Close();
                DataTable dataTable = dataSet.Tables["Data Penyakit"];
                int maxRow = dataTable.Rows.Count;
               //enyakit penyakit = new Penyakit();
                for (int i = 0; i < maxRow; i++)
                {
                    cmbKeluhan.Items.Add(dataTable.Rows[i].Field<string>("Penyakit"));                 
                    namaPenyakit[i] = dataTable.Rows[i].Field<string>("Penyakit");
                    pnykt[i].NamaPenyakit = namaPenyakit[i];
                    context.Penyakits.Add(pnykt[i]);
                    context.SaveChanges();
                }
                
                
                /*var pnykt1 = new Penyakit() { NamaPenyakit = "Penyakit Jantung" };
                context.Penyakits.Add(pnykt1);
                var pnykt2 = new Penyakit() { NamaPenyakit = "Penyakit Kulit" };
                context.Penyakits.Add(pnykt2);
                var pnykt3 = new Penyakit() { NamaPenyakit = "Penyakit THT" };
                context.Penyakits.Add(pnykt3);
                var pnykt4 = new Penyakit() { NamaPenyakit = "Penyakit Pencernaan" };
                context.Penyakits.Add(pnykt4);
                var pnykt5 = new Penyakit() { NamaPenyakit = "Penyakit Gigi" };
                context.Penyakits.Add(pnykt5);

                context.SaveChanges();*/
            }
        }

        private void btnInputKeluhan_Click(object sender, EventArgs e)
        {
            int indexPenyakit = cmbKeluhan.Items.IndexOf(cmbKeluhan.SelectedItem.ToString())+1;
            using (CekDokEntities context = new CekDokEntities())
            {
                Penyakit penyakit = context.Penyakits.FirstOrDefault(p => p.Id == indexPenyakit);
                AkunPenyakit akunPenyakit = new AkunPenyakit();
                Akun akun = context.Akuns.FirstOrDefault(a => a.Id == VariablePublic.UserId);
                akunPenyakit.IdPenyakit = penyakit.Id ;
                akunPenyakit.IdAkun = akun.Id;
                akunPenyakit.DeskripsiKeluhan = rtbKeluhan.Text;

                

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
                context.AkunPenyakits.Add(akunPenyakit);
                context.SaveChanges();
                KeluhanBerhasilForm keluhanBerhasilForm = new KeluhanBerhasilForm();
                keluhanBerhasilForm.Show();
                this.Hide();
            }
        }
    }
}
