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
    public partial class BokaBok : Form
    {
        Bibliotek Bibliotek { get; set; }
        private Expedit Expedit { get; set; }
        string mNummer;

        public BokaBok(Expedit expedit, Bibliotek bibliotek)
        {
            InitializeComponent();
            Expedit = expedit;
            Bibliotek = bibliotek;
            UpdateUI();
        }

        //metod för att uppdatera datagridviewen
        public void UpdateUI()
        {
            dataGridTillgängligaBöcker.DataSource = null;
            dataGridTillgängligaBöcker.DataSource = Bibliotek.HämtaTillgängligaBöcker();
        }

        //Här hämtas ett ISBN-nummer från den rad som är vald i datagridviewen
        //ISBN:et skickas därefter in i en lista. Denna lista kommer skickas vidare till BokaBok metoden
        private void btnBoka_Click(object sender, EventArgs e)
        {
            if (dataGridTillgängligaBöcker.CurrentRow != null)
            {
                if(string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Skriv in ett medlemsnummer");
                }
                else
                {
                    Bok bok = (Bok)dataGridTillgängligaBöcker.CurrentRow.DataBoundItem;
                    Bibliotek.BokaBok(bok, mNummer, Expedit);
                }
            }
            UpdateUI();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mNummer = textBox1.Text;
        }

        private void dataGridTillgängligaBöcker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVisaBokningar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Skriv in ett medlemsnummer!");
            }
            else
            {
                dataGridBokadeBöcker.DataSource = null;
                dataGridBokadeBöcker.DataSource = Bibliotek.HämtaBokningar(mNummer);
            }
        }

        //Här hämtas ett bokningsnummer ut från vald rad i datagridviewen
        //Bokningsnumret skickas därefter vidare till ÅterlämnaBok metoden
        private void btnÅterlämna_Click(object sender, EventArgs e)
        {
            if(dataGridBokadeBöcker.CurrentRow != null)
            {
                Bibliotek.ÅterlämnaBok((Bokning)dataGridBokadeBöcker.CurrentRow.DataBoundItem);
            }
            dataGridBokadeBöcker.DataSource = null;
            dataGridBokadeBöcker.DataSource = Bibliotek.HämtaBokningar(mNummer);
            UpdateUI();
        }

        private void btnFakturor_Click(object sender, EventArgs e)
        {
            dataGridBokadeBöcker.DataSource = null;
            dataGridBokadeBöcker.DataSource = Bibliotek.HämtaFakturor();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Hide();
            HuvudMeny hm = new HuvudMeny(Expedit, Bibliotek);
            hm.ShowDialog();
        }
    }
}
