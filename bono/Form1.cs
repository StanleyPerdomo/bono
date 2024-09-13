using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bono
{
    public partial class CalculoDeBono : Form
    {
        public CalculoDeBono()
        {
            InitializeComponent();
        }

        private void CalculoDeBono_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double bono = 0;
            
            if(rbGerencia.Checked)
            {
                bono = 500;
            }

            if (rbVentas.Checked)
            {
                bono = 300;
            }

            if (rbInformatica.Checked)
            {
                bono = 200;
            }

            if (rbAdministrativo.Checked)
            {
                bono = 100;
            }

            lblBono.Text = bono.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bono = 0;
            int seleccion = cbCategoria.SelectedIndex;

            switch(seleccion)
            {
                case 0:
                    bono = 500;
                    break;
                case 1:
                    bono = 300;
                    break;

                case 2:
                    bono = 200;
                    break;
                default:
                    bono = 0;
                    break;

            }
            //lblBono.Text = bono.ToString();
            lblBono.Text = cbCategoria.SelectedIndex.ToString();
                }
    }
}
