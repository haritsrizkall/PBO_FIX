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
using System.Runtime.Remoting.Contexts;

namespace UASPBO
{
    public partial class KeluhanForm : Form
    {
        string connectionString = ConfigurationManager
.ConnectionStrings["UASPBO.Properties.Settings.ConnString"]
.ConnectionString;
        
       
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
                
                string queryString = "SELECT Penyakit FROM DataPenyakit";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                DataSet dataSet = new DataSet();
                dbConnection.Open();
                OleDbDataAdapter dbAdapter = new OleDbDataAdapter(queryString, dbConnection);
                dbAdapter.Fill(dataSet, "Data Penyakit");
                dbConnection.Close();
                DataTable dataTable = dataSet.Tables["Data Penyakit"];
                int maxRow = dataTable.Rows.Count;
               
                for (int i = 0; i < maxRow; i++)
                {
                    cmbKeluhan.Items.Add(dataTable.Rows[i].Field<string>("Penyakit"));                 
                    namaPenyakit[i] = dataTable.Rows[i].Field<string>("Penyakit");
                    pnykt[i].NamaPenyakit = namaPenyakit[i];
                    context.Penyakits.Add(pnykt[i]);
                    context.SaveChanges();
                }
                
                
                
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

                              
                if (akunPenyakit.IdPenyakit != null && akunPenyakit.IdAkun != null && akunPenyakit.LamaSakit != null)
                {
                    VariablePublic.UserPenyakitId = indexPenyakit;
                    KeluhanBerhasilForm keluhanBerhasilForm = new KeluhanBerhasilForm();
                    keluhanBerhasilForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data yang diisikan masih kosong");
                }
                

            }
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
                Dokter[] dokter = InitializeArray<Dokter>(5);
                string[] namaDokter = new string[5];
           
                string queryString = "SELECT NamaDokter FROM DataDokter";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                DataSet dataSet = new DataSet();
                dbConnection.Open();
                OleDbDataAdapter dbAdapter = new OleDbDataAdapter(queryString, dbConnection);
                dbAdapter.Fill(dataSet, "Data Dokter");
                dbConnection.Close();
                DataTable dataTable = dataSet.Tables["Data Dokter"];
                int maxRow = dataTable.Rows.Count;
               
                for (int i = 0; i < maxRow; i++)
                {
                    namaDokter[i] = dataTable.Rows[i].Field<string>("NamaDokter");
                    dokter[i].NamaDokter = namaDokter[i];
                    context.Dokters.Add(dokter[i]);
                    context.SaveChanges();
                }
                
            }
           
        }
    }
}
