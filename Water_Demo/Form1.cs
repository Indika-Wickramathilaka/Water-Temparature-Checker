using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Water_Demo
{
    public partial class frmWaterDemo : Form
    {
        float num;
        string text;

        public frmWaterDemo()
        {
            InitializeComponent();
        }

        private void frmWaterDemo_Load(object sender, EventArgs e)
        {
            picWater.Visible = false;
            picGas.Visible = false;
            picIce.Visible = false;
            picTemparatureText.Visible = true;
        }

        private void btnFormofWater_Click(object sender, EventArgs e)
        {

           num = float.Parse(txtEnterTemparature.Text);
           //text = txtEnterTemparature.Text;

            if (num > 100)
            {
                picGas.Visible = true;
                picTemparatureText.Visible = false;
                picIce.Visible = false;
                picWater.Visible = false;
            }

            else if (num>=1)
            {
                picWater.Visible = true;
                picTemparatureText.Visible = false;
                picIce.Visible = false;
                picGas.Visible = false;
            }

            else if (num < 1)
            {
                picIce.Visible = true;
                picTemparatureText.Visible = false;
                picGas.Visible = false;
                picWater.Visible = false;
            }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

           /* txtEnterTemparature.Text = "";
            picWater.Visible = false;
            picGas.Visible = false;
            picIce.Visible = false;
            picTemparatureText.Visible = true;

            txtEnterTemparature.Select();*/
            
            if (MessageBox.Show("All Data Clear....", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                txtEnterTemparature.Text = "";
                picWater.Visible = false;
                picGas.Visible = false;
                picIce.Visible = false;
                picTemparatureText.Visible = true;

                txtEnterTemparature.Select();
            
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to Exit........", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtEnterTemparature_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
               // btnFormofWater.Select();
               
                num = float.Parse(txtEnterTemparature.Text);
            
                if (num > 100)
                {
                    picGas.Visible = true;
                    picTemparatureText.Visible = false;
                    picIce.Visible = false;
                    picWater.Visible = false;
                }

                else if (num > 1)
                {
                    picWater.Visible = true;
                    picTemparatureText.Visible = false;
                    picIce.Visible = false;
                    picGas.Visible = false;
                }

                else if (num < 1)
                {
                    picIce.Visible = true;
                    picTemparatureText.Visible = false;
                    picGas.Visible = false;
                    picWater.Visible = false;
                }                            
            }
        }       
    }
}
