using System;
using System.Windows.Forms;
using Filtro.clases;

namespace Filtro
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        clases.Filtro filt = new clases.Filtro();
        clases.excel ex = new excel();
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Por favor ingrese nombre del encargado de filtro");
                }
                else
                {
                    filt.setNombre(textBox1.Text);
                    MessageBox.Show("Bienvenido/a " + filt.getNombre() + " ten un excelente dia :)");
                    var Filtr = new FrmFiltro();
                    Filtr.Show();
                    Hide();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show("Lo siento, no se ha podido realizar la accion, por favor comuniquese con sistemas");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}