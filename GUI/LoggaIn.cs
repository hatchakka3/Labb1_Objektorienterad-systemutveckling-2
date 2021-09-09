using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Affärslager;

namespace GUI
{
    public partial class LoggaIn : Form
    {
        Bibliotek Bibliotek { get; set; }
        public LoggaIn(Bibliotek bibliotek)
        {
            InitializeComponent();
            Bibliotek = bibliotek;
            //Bibliotek.Kontext.ExpeditRepository.LaddaData();
        }
        string aNummer;
        string lösen;

        //kontrollerar att expeditens inloggningsuppgifter stämmer överens med de lagrade uppgifterna
        //Om uppgifterna inte stämmer visas ett felmeddelande
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Expedit expedit;
            expedit = Bibliotek.LoggaIn(aNummer, lösen);

            if(expedit == null)
            {
                MessageBox.Show("Wrong credentials!");
            }
            else
            {
                this.Hide();
                HuvudMeny hm = new HuvudMeny(expedit, Bibliotek);
                hm.ShowDialog();
            }
        }
        //Användaren får mata in inloggningsuppgifter
        private void txtANummer_TextChanged(object sender, EventArgs e)
        {
            aNummer = this.txtANummer.Text;
        }

        private void txtLösen_TextChanged(object sender, EventArgs e)
        {
            lösen = this.txtLösen.Text;
        }
    }
}

