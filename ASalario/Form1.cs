using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASalario
{
    public partial class fmrSalario : Form
    {
        public fmrSalario()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DateTime fechai = dtpFNacimiento.Value;
            int FNac;
            int FActual;
            int Edad;
            int actual = DateTime.Now.Year;
            int Antiguedad;
            Decimal salario = Convert.ToInt32(txtSalario.Text);
            FNac = fechai.Year;
            FActual = actual;
            Edad = FActual - FNac;
            Antiguedad = Convert.ToInt32(txtAntiguedad.Text);
            if (Convert.ToInt32(txtVentas.Text) >= 10000)
            {
                if (Edad >= 30)
                {
                    if (Antiguedad >= 10)
                    {
                        salario = salario * (Decimal).05;
                        salario = salario + Convert.ToInt32(txtSalario.Text);
                        MessageBox.Show($"NUEVO SALARIO: { salario  }");

                    }
                    else
                    {
                        MessageBox.Show("NO SE CUMPLEN LOS REQUISITOS PARA UN AUMENTO");
                    }
                }
                else
                {
                    MessageBox.Show("NO SE CUMPLEN LOS REQUISITOS PARA UN AUMENTO");

                }
            }
            else
            {
                MessageBox.Show("NO SE CUMPLEN LOS REQUISITOS PARA UN AUMENTO");
            }
        }
    }
}

        