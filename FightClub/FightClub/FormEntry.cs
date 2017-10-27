using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class FormEntry : Form
    {
        LoginPlayer lp = new LoginPlayer();
        public FormEntry(LoginPlayer lp)
        {
            InitializeComponent();
            this.lp = lp;
            lp.ResEntry = false;
        }

        private void FormEntry_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Trim() != String.Empty && cbHit.SelectedIndex != -1)
            {
                lp.NamePlayer = tbName.Text.Trim();
                lp.Hits = cbHit.SelectedIndex;
                lp.LogToFile = chbLog.Checked;
                lp.ResEntry = true;
                this.Close();
            }
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"Help.txt", Encoding.UTF8);
            MessageBox.Show(text);
        }
    }
}
