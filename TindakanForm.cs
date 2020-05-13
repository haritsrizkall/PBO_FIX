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
    public partial class TindakanForm : Form
    {
        public TindakanForm()
        {
            InitializeComponent();
        }

        private void TindakanForm_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                AkunPenyakit akunPenyakit = context.AkunPenyakits.FirstOrDefault(a => a.IdAkun == VariablePublic.UserId );
                //Penyakit penyakit = context.Penyakits.FirstOrDefault(p => p.Id == akunPenyakit.IdPenyakit);
                lblNamaPenyakit.Text = akunPenyakit.Penyakit.NamaPenyakit;
            }
        }
    }
}
