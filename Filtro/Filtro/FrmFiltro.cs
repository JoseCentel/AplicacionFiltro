using System;
using System.Windows.Forms;
using Filtro.clases;

namespace Filtro
{
    public partial class FrmFiltro : Form
    {
        private readonly db bd = new db();
        clases.excel	ex = new excel	();
        private string bolsa;
        private string celular;
        private readonly clases.Filtro filt = new clases.Filtro();
        private string lonche;
        private string mochila;
        private string otro;
        private string lentes;
        private string gorra;
        private string laptop;

        public FrmFiltro()
        {
            InitializeComponent();
        }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            bd.conect();
            dtgVer.DataSource = bd.registros(dtVerFecha);
            lblRegNum.Text = "Numero de gente que dejo pertenencias:" + bd.nu_reg();
        }

        private void dtVerFecha_ValueChanged(object sender, EventArgs e)
        {
            dtgVer.DataSource = bd.registros(dtVerFecha);
        }

        private void btnRegGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkRegBolsa.Checked)
                {
                    bolsa = "Si";
                }
                else
                {
                    bolsa = "No";
                }
                if (chkRegLonc.Checked)
                {
                    lonche = "Si";
                }
                else
                {
                    lonche = "No";
                }
                if (chkRegMochila.Checked)
                {
                    mochila = "Si";
                }
                else
                {
                    mochila = "No";
                }
                if (chkRegOtro.Checked)
                {
                    otro = "Si";
                }
                else
                {
                    otro = "No";
                }
                if (chkRegLap.Checked)
                {
                    laptop = "Si";
                }
                else
                {
                    laptop = "No";
                }
                if (chkRegGorra.Checked)
                {
                    gorra = "Si";
                }
                else
                {
                    gorra = "No";
                }
                if (chkLentes.Checked)
                {
                    lentes = "Si";
                }
                else
                {
                    lentes = "No";
                }
                if(txtRegNoEmp.Text =="")
                {
                    MessageBox.Show("Por favor introduzca numero de empleado");
                }
                else
                {
                    
                    bd.insertarRegistro(filt.getNombre(), bd.nombre_Emp(txtRegNoEmp.Text), mochila, lonche, otro, bolsa,
                        cmbRegCel.Text, txtRegComent.Text, gorra, laptop, txtRegNoEmp.Text, lentes,comboBox1.Text);
                    txtRegNoEmp.Text = "";
                    txtRegComent.Text = "";
                    chkRegBolsa.Checked = false;
                    chkRegGorra.Checked = false;
                    chkRegLap.Checked = false;
                    chkLentes.Checked = false;
                    chkRegMochila.Checked = false;
                    chkRegOtro.Checked = false;
                    chkRegLonc.Checked = false;
                    cmbRegCel.Text = "Ninguno";
                    comboBox1.Text = "Ninguno";
                    dtgVer.DataSource = bd.registros(dtVerFecha);
                    lblRegNum.Text = "Numero de gente que dejo pertenencias:" + bd.nu_reg();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo realizar la operacion, por favor comunicate con sistemas");
            }
        }

        private void chkRegBolsa_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkRegCel_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkRegMochila_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkRegLonc_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkRegOtro_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkRegBolsa_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void btnGenExDia_Click(object sender, EventArgs e)
        {
            ex.generarexcel(dateTimePicker1);
        }

        private void cmbRegCel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}