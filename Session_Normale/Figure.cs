using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_Normale
{
    public partial class Figure : Form
    {
        public Figure()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Figure_Load(object sender, EventArgs e)
        {

        }

        private void btnenreg_Click(object sender, EventArgs e)
        {
            if ((txtId.Text == "") || (txtcoul.Text == "") || (txtEp.Text == ""))
            {

                MessageBox.Show("Veuillez Compléter tous les Champs ");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtEp.Text = "";
            txtcoul.Text = "";
            txtlarg.Text = "";
            txtVal.Text = "";
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RadioCercle_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCercle.Checked == true)
            {
                lbllong.Visible = true;
                lbllong.Text = "Rayon";
                txtVal.Visible = true;
            }
            if (RadioCercle.Checked == false)
            {
                if (RadioRectangle.Checked == true)
                {
                    lbllong.Visible = true;
                    lbllong.Text = "Longueur";
                    lbllarg.Visible = true;
                    txtVal.Visible = true;
                    txtlarg.Visible = true;
                }
                else
                {
                    lbllong.Visible = false;
                    lbllong.Text = "Longueur";
                    lbllarg.Visible = false;
                    txtVal.Visible = false;
                    txtlarg.Visible = false;
                }
            }
        }

        private void lbllong_Click(object sender, EventArgs e)
        {

        }

        private void RadioRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioRectangle.Checked == true)
            {
                lbllong.Visible = true;
                lbllong.Text = "Longueur";
                lbllarg.Visible = true;
                txtVal.Visible = true;
                txtlarg.Visible = true;
            }
            if (RadioRectangle.Checked == false)
            {
                if (RadioCercle.Checked == true)
                {
                    lbllong.Visible = true;
                    lbllong.Text = "Rayon";
                    txtVal.Visible = true;
                    lbllarg.Visible = false;
                    txtlarg.Visible = false;
                }
                else
                {
                    lbllong.Visible = false;
                    lbllarg.Visible = false;
                    txtVal.Visible = false;
                    txtlarg.Visible = false;
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Hide();
            //Close();
        }
    }
}
