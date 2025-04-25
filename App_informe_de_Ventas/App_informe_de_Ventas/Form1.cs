namespace App_informe_de_Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvSales.View = View.Details;
            lvSales.FullRowSelect = true;  // Resalta toda la fila
            lvSales.GridLines = true;      // Muestra líneas de separación
            lvSales.Font = new Font("Arial", 9, FontStyle.Regular); // Fuente compacta

            // Crear columnas con ajustes de ancho
            lvSales.Columns.Add("Name", 150);
            lvSales.Columns.Add("Mon.", 70);
            lvSales.Columns.Add("Tue.", 70);
            lvSales.Columns.Add("Wed.", 70);
            lvSales.Columns.Add("Thu.", 70);
            lvSales.Columns.Add("Fri.", 70);
            lvSales.Columns.Add("Total", 100);

            // Alinear contenido de las columnas a la derecha 
            for (int i = 1; i < lvSales.Columns.Count; i++)
            {
                lvSales.Columns[i].TextAlign = HorizontalAlignment.Right;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validar que no existan campos vacios
            if (string.IsNullOrWhiteSpace(txtItem.Text) ||
        string.IsNullOrWhiteSpace(txtMonday.Text) ||
        string.IsNullOrWhiteSpace(txtTuesday.Text) ||
        string.IsNullOrWhiteSpace(txtWednesday.Text) ||
        string.IsNullOrWhiteSpace(txtThursday.Text) ||
        string.IsNullOrWhiteSpace(txtFriday.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener valores del formulario
                string itemName = txtItem.Text;
                decimal monday = Convert.ToDecimal(txtMonday.Text);
                decimal tuesday = Convert.ToDecimal(txtTuesday.Text);
                decimal wednesday = Convert.ToDecimal(txtWednesday.Text);
                decimal thursday = Convert.ToDecimal(txtThursday.Text);
                decimal friday = Convert.ToDecimal(txtFriday.Text);

                // Calcular total semanal
                decimal total = monday + tuesday + wednesday + thursday + friday;

                // Agregar al ListView
                ListViewItem item = new ListViewItem(itemName);
                item.SubItems.Add(monday.ToString("C2"));
                item.SubItems.Add(tuesday.ToString("C2"));
                item.SubItems.Add(wednesday.ToString("C2"));
                item.SubItems.Add(thursday.ToString("C2"));
                item.SubItems.Add(friday.ToString("C2"));
                item.SubItems.Add(total.ToString("C2"));

                lvSales.Items.Add(item);

                // Actualizar total global
                CalcularVentasTotales();

                // Limpiar campos después de ingresar un producto
                txtItem.Clear();
                txtMonday.Clear();
                txtTuesday.Clear();
                txtWednesday.Clear();
                txtThursday.Clear();
                txtFriday.Clear();
                txtItem.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos para las ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalcularVentasTotales()
        {
            decimal totalGeneral = 0;

            foreach (ListViewItem item in lvSales.Items)
            {
                totalGeneral += Convert.ToDecimal(item.SubItems[6].Text.Replace("$", ""));
            }

            lblTotalSales.Text = totalGeneral.ToString("C2");
        }

        private void lblTotalSales_Click(object sender, EventArgs e)
        {

        }
    }
}
