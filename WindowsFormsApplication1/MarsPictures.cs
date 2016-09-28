using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MP.NasaMarsRoverPhotos;
using MP.Model;
using Newtonsoft.Json;
using Utilities;
using MP.Utilities.WinformPromptDialog;

namespace MP
{
    public partial class MarsPictures : Form
    {
        Data.Data data { get; set; }
            
        public MarsPictures()
        {
            InitializeComponent();
        }

        private async Task InitializeData()
        {
            if (MP.Utilities.AppConfiguration.AppConfiguration.ReadKey() != string.Empty)
            {
                data = new Data.Data();
                data.Curiosity_MaxSol = await NasaMarsRoverPhotos.NasaMarsRoverPhotos.GetRoverMaxSol("curiosity", MP.Utilities.AppConfiguration.AppConfiguration.ReadKey());
                data.Spirit_MaxSol = await NasaMarsRoverPhotos.NasaMarsRoverPhotos.GetRoverMaxSol("spirit", MP.Utilities.AppConfiguration.AppConfiguration.ReadKey());
                data.Opportunity_MaxSol = await NasaMarsRoverPhotos.NasaMarsRoverPhotos.GetRoverMaxSol("opportunity", MP.Utilities.AppConfiguration.AppConfiguration.ReadKey());
            }
        }

        private async Task SendQuery(int sol, string camera, string rover)
        {
            if (txtSelectedSol.Text.Trim() != string.Empty)
            {
                //get response
                string pictureResponse = await NasaMarsRoverPhotos.NasaMarsRoverPhotos.SendPictureRequest(sol, camera, rover, MP.Utilities.AppConfiguration.AppConfiguration.ReadKey());

                //deserialize response
                if (pictureResponse != null)
                {
                    Rootobject g = new Rootobject();
                    g = JsonConvert.DeserializeObject<Rootobject>(pictureResponse.ToString());

                    //use response
                    if (g != null)
                    {
                        if (g.photos.Count() > 0)
                        {
                            lstPictures.DataSource = g.photos;
                            lstPictures.ValueMember = "img_src";
                            lstPictures.DisplayMember = "id";
                        }
                        else
                        {
                            MessageBox.Show("No picture found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No picture found.");
                    }
                }
            }
        }

        private async void btnLoadPicture_Click(object sender, EventArgs e)
        {
            await TryToLoadPicture();
        }

        private async Task TryToLoadPicture()
        {
            string rover = string.Empty;
            if (radCuriosity.Checked)
                rover = "curiosity";
            if (radOpportunity.Checked)
                rover = "opportunity";
            if (radSpirit.Checked)
                rover = "spirit";

            if (rover != string.Empty)
            {
                if (barSol.Value != 0)
                {
                    if (cmbCamera.SelectedValue.ToString() != string.Empty)
                    {
                        await SendQuery(barSol.Value, cmbCamera.SelectedValue.ToString(), rover);
                    }
                    else
                    {
                        MessageBox.Show("Check all your inputs (rover, camera, sol).");
                    }
                }
            }

        }

        private void ResetCameraList()
        {
            if (data != null)
            {
                cmbCamera.DataSource = data.LoadData(null);
                cmbCamera.ValueMember = "ShortName";
                cmbCamera.DisplayMember = "Name";
            }
        }

        private void UpdateGraphic()
        {
            barSol.Minimum = 1;

            if (radCuriosity.Checked == true)
            {
                barSol.Maximum = data.Curiosity_MaxSol;
                txtMaxSol.Text = "Maximum SOL = " + data.Curiosity_MaxSol.ToString();
            }
            if (radSpirit.Checked == true)
            {
                barSol.Maximum = data.Spirit_MaxSol;
                txtMaxSol.Text = "Maximum SOL = " + data.Spirit_MaxSol.ToString();
            }
            if (radOpportunity.Checked == true)
            {
                barSol.Maximum = data.Opportunity_MaxSol;
                txtMaxSol.Text = "Maximum SOL = " + data.Opportunity_MaxSol.ToString();
            }

            txtMinSol.Text = "Minimum SOL = 1";
            txtSelectedSol.Text = "Selected SOL = " + barSol.Value.ToString();

            if (barSol.Maximum <= 1)
            {
                btnLoadPicture.Enabled = false;
            }
            else
            {
                btnLoadPicture.Enabled = true;
            }

            if (cmbCamera.SelectedItem != null)
            {
                txtCameraInfo.Text = ((Data.Camera)cmbCamera.SelectedItem).Description;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await InitializeData();
            CheckNasaKey();
        }

        private void CheckNasaKey()
        {
            //read from configuration
            string key = MP.Utilities.AppConfiguration.AppConfiguration.ReadKey();

            WinformPromptDialog keyDialog = new WinformPromptDialog(key);
            if (keyDialog.ShowDialog(this) == DialogResult.OK)
            {
                //save to configuration
                MP.Utilities.AppConfiguration.AppConfiguration.WriteKey(keyDialog.NasaKey);

                InitializeForm();
                keyDialog.Dispose();
            }
            else
            {
                this.Dispose();
            }
        }

        private void InitializeForm()
        {
            ResetCameraList();
            UpdateGraphic();
        }

        private void LoadData()
        {
            cmbCamera.DataSource = data.LoadData(null);
            cmbCamera.ValueMember = "ShortName";
            cmbCamera.DisplayMember = "Name";
            UpdateGraphic();
        }

        private void radCuriosity_CheckedChanged(object sender, EventArgs e)
        {
            cmbCamera.DataSource = data.LoadData("Curiosity");
            cmbCamera.ValueMember = "ShortName";
            cmbCamera.DisplayMember = "Name";
            UpdateGraphic();
        }

        private void radOpportunity_CheckedChanged(object sender, EventArgs e)
        {
            cmbCamera.DataSource = data.LoadData("Opportunity");
            cmbCamera.ValueMember = "ShortName";
            cmbCamera.DisplayMember = "Name";
            UpdateGraphic();
        }

        private void radSpirit_CheckedChanged(object sender, EventArgs e)
        {
            cmbCamera.DataSource = data.LoadData("Spirit");
            cmbCamera.ValueMember = "ShortName";
            cmbCamera.DisplayMember = "Name";
            UpdateGraphic();
        }

        private void barSol_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void lstPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load picture
            picPicture.Load(lstPictures.GetItemText(((Photo)lstPictures.SelectedItem).img_src));
        }

        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraphic();
        }

        private void barSol_ValueChanged(object sender, EventArgs e)
        {
            UpdateGraphic();
        }

        private void barSol_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateGraphic();
        }

        private void btnChangeNasaKey_Click(object sender, EventArgs e)
        {
            CheckNasaKey();
        }
    }
}
