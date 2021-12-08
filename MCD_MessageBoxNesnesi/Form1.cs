using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_MessageBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesajGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcıya göstermek istediğiniz bilgi","Başlık Bilgisi",MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void btnSoruSor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Yeniden denemek ister misiniz?", "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res==DialogResult.Yes )
            {

            }

            if (res == DialogResult.No )
            {

            }

            if (res == DialogResult.Cancel )
            {

            }

        }
    }
}
