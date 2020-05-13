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
    public partial class InfoDokterForm : Form
    {
        public InfoDokterForm()
        {
            InitializeComponent();
        }

        private void InfoDokterForm_Load(object sender, EventArgs e)
        {
            
            using (CekDokEntities context = new CekDokEntities())
            {
               /* T[] InitializeArray<T>(int length) where T : new()
                {
                    T[] array = new T[length];
                    for (int i = 0; i < length; ++i)
                    {
                        array[i] = new T();
                    }

                    return array;
                }*/
                string[] dokterNama = new string[5];
                for (int i = 0; i < dokterNama.Length; i++)
                {
                    Dokter dokter = context.Dokters.FirstOrDefault(d => d.Id == i+1);
                    dokterNama[i] = dokter.NamaDokter;
                }
                label1.Text = dokterNama[0];
                label3.Text = dokterNama[1];
                label5.Text = dokterNama[2];
                label7.Text = dokterNama[3];
                label9.Text = dokterNama[4];

            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            TindakanForm tindakanForm = new TindakanForm();
            tindakanForm.Show();
            this.Close();
        }
    }
}
