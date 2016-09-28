using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP.Utilities.WinformPromptDialog
{
    public partial class WinformPromptDialog : Form
    {
        public string NasaKey { get; set; }

        public WinformPromptDialog(string nasaKey)
        {
            InitializeComponent();

            if (nasaKey != string.Empty)
            {
                labTitle.Text = "Confirm your NASA API key *";
                txtNASAKey.Text = nasaKey;
                btnInsertKey.Text = "Confirm";
            }
            else
            {
                labTitle.Text = "Insert your NASA API key *";
                txtNASAKey.Text = string.Empty;
                btnInsertKey.Text = "Insert";
            }
        }

        private void btnInsertKey_Click(object sender, EventArgs e)
        {
            NasaKey = txtNASAKey.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNASAKey_TextChanged(object sender, EventArgs e)
        {
            labTitle.Text = "Insert your NASA API key *";
            btnInsertKey.Text = "Insert";
        }
    }
}
