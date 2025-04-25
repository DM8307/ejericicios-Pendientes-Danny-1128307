using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIADanny
{
    public partial class Form1: Form
    {
        // Definición de precios fijos para cada tipo de monitor
        private const decimal Price24 = 25.00m;
        private const decimal Price27 = 50.00m;
        private const decimal Price32 = 100.00m;
        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers(); // Asigna eventos a los controles
            SetFixedPrices(); // Establece los precios fijos
            btnCalculate.Enabled = false; // Desactiva el botón de cálculo al inicio
            txtInvoiceDate.Text = DateTime.Now.ToShortDateString(); // Establece la fecha actual
            txtInvoiceDate.ReadOnly = true; // Evita la edición manual de la fecha
        }
        // Método para asignar los eventos de validación y cambios de texto
        private void AttachEventHandlers()
        {
            txtQuantity24.KeyPress += ValidateIntegerInput;
            txtQuantity27.KeyPress += ValidateIntegerInput;
            txtQuantity32.KeyPress += ValidateIntegerInput;
            txtQuantity24.TextChanged += EnableCalculateButton;
            txtQuantity27.TextChanged += EnableCalculateButton;
            txtQuantity32.TextChanged += EnableCalculateButton;
            txtInvoiceNumber.KeyPress += ValidateInvoiceNumberInput;
        }
        // Valida que solo se ingresen números enteros positivos en los campos de cantidad
        private void ValidateIntegerInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Valida que el número de pedido solo contenga 4 dígitos numéricos
        private void ValidateInvoiceNumberInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtInvoiceNumber.Text.Length >= 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Activa el botón de cálculo si al menos un producto tiene cantidad mayor a 0
        private void EnableCalculateButton(object sender, EventArgs e)
        {
            btnCalculate.Enabled = GetQuantity(txtQuantity24) > 0 || GetQuantity(txtQuantity27) > 0 || GetQuantity(txtQuantity32) > 0;
        }
        // Establece los precios fijos y deshabilita su edición
        private void SetFixedPrices()
        {
            txtPrice24.Text = Price24.ToString("C");
            txtPrice27.Text = Price27.ToString("C");
            txtPrice32.Text = Price32.ToString("C");
            txtPrice24.ReadOnly = true;
            txtPrice27.ReadOnly = true;
            txtPrice32.ReadOnly = true;
        }

        // Convierte el texto de un TextBox en un entero (si es válido)
        private int GetQuantity(TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int result) ? result : 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //clic por error y ahora no la puedo quitar porque si no el forms explota
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //clic por error y ahora no la puedo quitar porque si no el forms explota
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //clic por error y ahora no la puedo quitar porque si no el forms explota
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //clic por error y ahora no la puedo quitar porque si no el forms explota
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //clic por error y ahora no la puedo quitar porque si no el forms explota
        }

        // Limpia los campos de entrada y deshabilita el botón de cálculo
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInvoiceNumber.Clear();
            txtCompanyName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtQuantity24.Clear();
            txtQuantity27.Clear();
            txtQuantity32.Clear();
            txtTotal24.Clear();
            txtTotal27.Clear();
            txtTotal32.Clear();
            txtSubTotal.Clear();
            txtTaxes.Clear();
            txtDiscount.Clear();
            txtTotal.Clear();
            btnCalculate.Enabled = false;
        }
        // Calcula el total del pedido incluyendo impuestos, descuentos y envío
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Verifica que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtInvoiceNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress1.Text))
            {
                MessageBox.Show("Por favor, complete el número de pedido, nombre y dirección de envío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtiene las cantidades de monitores ordenados
            int quantity24 = GetQuantity(txtQuantity24);
            int quantity27 = GetQuantity(txtQuantity27);
            int quantity32 = GetQuantity(txtQuantity32);

            // Calcula el subtotal por cada tipo de monitor
            decimal total24 = quantity24 * Price24;
            decimal total27 = quantity27 * Price27;
            decimal total32 = quantity32 * Price32;
            decimal subTotal = total24 + total27 + total32;

            // Calcula impuestos, envío y descuentos
            decimal tax = subTotal * 0.05m;
            decimal shipping = (quantity24 + quantity27 + quantity32 > 20) ? 0 : 1.50m;
            decimal discount = (subTotal >= 500) ? subTotal * 0.07m : 0;

            decimal finalTotal = subTotal + tax + shipping - discount;

            // Muestra los valores calculados en los TextBoxes
            txtTotal24.Text = total24.ToString("C");
            txtTotal27.Text = total27.ToString("C");
            txtTotal32.Text = total32.ToString("C");
            txtSubTotal.Text = subTotal.ToString("C");
            txtTaxes.Text = tax.ToString("C");
            txtDiscount.Text = discount > 0 ? $"(-{discount:C})" : "$0.00";
            txtTotal.Text = finalTotal.ToString("C");

            // Muestra una notificación si se aplica el descuento del 7%
            if (discount > 0)
            {
                MessageBox.Show("7% discount will be applied.", "Discount Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
