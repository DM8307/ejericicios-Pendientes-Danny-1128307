using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Calculadoradepagosylistas
{
    public partial class Calculadoradepagos : Form
    {
        public Calculadoradepagos()
        {
            InitializeComponent();
            AttachEventHandlers();

        }
        private void btnCalcularpagos_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entradas antes de convertirlas
                if (!double.TryParse(txtValoraTomar.Text, out double valor) ||
                    !int.TryParse(txtCantidaddeMeses.Text, out int meses) ||
                    !double.TryParse(txtTasadeinteres.Text, out double tasaInteres))
                {
                    MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir tasa de interés anual a mensual
                double tasaMensual = tasaInteres / 100 / 12;

                // Determinar si el pago es anticipado o no
                DueDate modoPago = chkpagosanticipados.Checked ? DueDate.BegOfPeriod : DueDate.EndOfPeriod;

                // Calcular el pago mensual
                double pagoMensual = Financial.Pmt(tasaMensual, meses, -valor, 0, modoPago);

                // Mostrar el resultado formateado en el TextBox
                txtPagosMensuales.Text = pagoMensual.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AttachEventHandlers()
        {
            // Asignar validaciones a cada campo
            txtCantidaddeMeses.KeyPress += ValidarSoloEnteros;
            txtTasadeinteres.KeyPress += ValidarDecimales;
            txtValoraTomar.KeyPress += ValidarDecimales;
        }

        private void ValidarSoloEnteros(object? sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox txt) return; // Si sender no es un TextBox, salir.

            // Permitir solo dígitos y teclas de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ValidarDecimales(object? sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox txt) return; // Si sender no es un TextBox, salir.

            // Permitir solo dígitos, un solo punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Evitar más de un punto decimal
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
