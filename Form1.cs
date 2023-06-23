using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace TCVatandaslıkSorgulama
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            long TCKN = long.Parse (textBoxTCKN.Text);
            string İsim = textBoxİsim.Text;
            string Soyisim = textBoxSoyisim.Text;
            int DogumTarih =int.Parse (textBoxDTarih.Text);

            TCdogrulamaService.KPSPublicSoapClient sorgu = new TCdogrulamaService.KPSPublicSoapClient();
            bool DönenDeğer = sorgu.TCKimlikNoDogrula(TCKN, İsim, Soyisim, DogumTarih);

            if (DönenDeğer == true)
                MessageBox.Show("Girilen kimlik bilgileri dogrulandı","Kayıt Bulundu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Girilen kimlik bilgileri dogrulanmadı !!!", "Kayıt Bulunamadı !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
