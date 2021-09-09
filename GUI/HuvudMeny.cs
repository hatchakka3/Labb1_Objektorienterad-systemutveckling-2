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
    public partial class HuvudMeny : Form
    {
        private Expedit Expedit { get; set; }
        Bibliotek Bibliotek { get; set; }
        public HuvudMeny(Expedit expedit, Bibliotek bibliotek)
        {
            InitializeComponent();
            Expedit = expedit;
            Bibliotek = bibliotek;
        }
        // Repsektive form laddas upp vid knapptryck
        private void btnBokaBok_Click(object sender, EventArgs e)
        {
            this.Hide();
            BokaBok bokabok = new BokaBok(Expedit, Bibliotek);
            bokabok.ShowDialog();
        }

        private void btnLoggaUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoggaIn li = new LoggaIn(Bibliotek);
            li.ShowDialog();
        }
    }
}
