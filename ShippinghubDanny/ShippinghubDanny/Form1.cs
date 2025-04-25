namespace ShippinghubDanny
{
    public partial class Form1 : Form
    {
        private List<Paquete> paquetesFiltrados = new List<Paquete>();
        private int indiceActual = -1;
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "paquetes.txt");
        private List<Paquete> paquetes = new List<Paquete>();
        private Random generadorPaquetes = new Random();
        private HashSet<int> paquetesGenerados = new HashSet<int>();

        private string GenerarNumeroPaquete()
        {
            int numero;
            do
            {
                numero = generadorPaquetes.Next(10000, 99999); // Ej: 5 cifras
            } while (paquetesGenerados.Contains(numero));

            paquetesGenerados.Add(numero);
            return numero.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            CargarPaquetes();
        }
        public class Paquete
        {
            public string Numero { get; set; }
            public string Direccion { get; set; }
            public string Ciudad { get; set; }
            public string Estado { get; set; }
            public string Zip { get; set; }
            public DateTime FechaLlegada { get; set; }

            public override string ToString()
            {
                return $"{Numero} - {Ciudad}, {Estado}";
            }
        }
        private void GuardarPaquetes()
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                foreach (var item in lstPackages.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
        private void MostrarDetallePaquete(Paquete p)
        {
            txtPackageNumber.Text = p.Numero;
            txtAddress.Text = p.Direccion;
            txtCity.Text = p.Ciudad;
            txtZip.Text = p.Zip;
            cmbStateI.SelectedItem = p.Estado;
            txtArrivedat.Text = p.FechaLlegada.ToString("yyyy-MM-dd HH:mm");
        }
        private void CargarPaquetes()
        {
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (var linea in lineas)
                {
                    lstPackages.Items.Add(linea);

                    // Intentamos reconstruir el objeto Paquete desde el texto
                    // "#12345 - Ciudad, Estado"
                    string[] partes = linea.Split('-');
                    if (partes.Length < 2) continue;

                    string numero = partes[0].Trim('#', ' ');
                    string[] datos = partes[1].Split(',');

                    if (datos.Length < 2) continue;

                    string ciudad = datos[0].Trim();
                    string estado = datos[1].Trim();

                    paquetes.Add(new Paquete
                    {
                        Numero = numero,
                        Ciudad = ciudad,
                        Estado = estado,
                        Direccion = "Desconocida",
                        Zip = "00000",
                        FechaLlegada = DateTime.Now
                    });
                }
            }
        }
        private void LimpiarCampos()
        {
            txtPackageNumber.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtZip.Clear();
            cmbStateI.SelectedIndex = -1;
            txtArrivedat.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text) ||
        string.IsNullOrWhiteSpace(txtCity.Text) ||
        string.IsNullOrWhiteSpace(txtZip.Text) ||
        cmbStateI.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtZip.Text, out _) || txtZip.Text.Length != 5)
            {
                MessageBox.Show("El ZIP code debe tener exactamente 5 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string numeroPaquete = string.IsNullOrWhiteSpace(txtPackageNumber.Text)
                                    ? GenerarNumeroPaquete()
                                    : txtPackageNumber.Text;

            string paquete = $"#{numeroPaquete} - {txtAddress.Text}, {txtCity.Text}, {cmbStateI.SelectedItem} {txtZip.Text}";
            lstPackages.Items.Add(paquete);
            GuardarPaquetes();
            paquetes.Add(new Paquete
            {
                Numero = numeroPaquete,
                Direccion = txtAddress.Text,
                Ciudad = txtCity.Text,
                Estado = cmbStateI.SelectedItem.ToString(),
                Zip = txtZip.Text,
                FechaLlegada = DateTime.Now
            });
            LimpiarCampos();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPackages.SelectedIndex != -1)
            {
                lstPackages.Items.RemoveAt(lstPackages.SelectedIndex);
                GuardarPaquetes();
            }
            else
            {
                MessageBox.Show("Selecciona un paquete para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPackages.SelectedIndex != -1)
            {
                string item = lstPackages.SelectedItem.ToString();

                // Ejemplo de parsing simple (si mantienes el formato actual)
                // "#12345 - Calle 1, Ciudad, Estado ZIP"
                string[] partes = item.Split('-');
                string numero = partes[0].Trim('#', ' ');
                string[] datos = partes[1].Split(',');

                txtPackageNumber.Text = numero;
                txtAddress.Text = datos[0].Trim();
                txtCity.Text = datos[1].Trim();

                string[] estadoZip = datos[2].Trim().Split(' ');
                if (estadoZip.Length == 2)
                {
                    cmbStateI.SelectedItem = estadoZip[0];
                    txtZip.Text = estadoZip[1];
                }

                // Eliminarlo de la lista para volverlo a agregar luego
                lstPackages.Items.RemoveAt(lstPackages.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona un paquete para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnScanNew_Click(object sender, EventArgs e)
        {
            txtPackageNumber.Text = GenerarNumeroPaquete();
            txtAddress.Clear();
            txtCity.Clear();
            txtZip.Clear();
            cmbStateI.SelectedIndex = -1;
            txtArrivedat.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm"); // Fecha automática
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un estado para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si es la primera vez o se cambió de estado, filtramos y reiniciamos el índice
            if (paquetesFiltrados.Count == 0 || indiceActual == -1 ||
                paquetesFiltrados.First().Estado != cmbState.SelectedItem.ToString())
            {
                paquetesFiltrados = paquetes
                    .Where(p => p.Estado == cmbState.SelectedItem.ToString())
                    .ToList();

                indiceActual = 0;

                if (paquetesFiltrados.Count == 0)
                {
                    MessageBox.Show("No hay paquetes para este estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                // Siguiente paquete
                indiceActual++;
                if (indiceActual >= paquetesFiltrados.Count)
                {
                    indiceActual = 0; // reinicia el ciclo
                }
            }

            // Mostrar el paquete actual
            var actual = paquetesFiltrados[indiceActual];
            MostrarDetallePaquete(actual);
            lstPackages.Items.Clear();
            lstPackages.Items.Add(actual.ToString());
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un estado para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (paquetesFiltrados.Count == 0 || indiceActual == -1 ||
                paquetesFiltrados.First().Estado != cmbState.SelectedItem.ToString())
            {
                paquetesFiltrados = paquetes
                    .Where(p => p.Estado == cmbState.SelectedItem.ToString())
                    .ToList();

                if (paquetesFiltrados.Count == 0)
                {
                    MessageBox.Show("No hay paquetes para este estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                indiceActual = paquetesFiltrados.Count - 1;
            }
            else
            {
                // Retroceder
                indiceActual--;
                if (indiceActual < 0)
                {
                    indiceActual = paquetesFiltrados.Count - 1; // Vuelve al último
                }
            }

            // Mostrar el paquete actual
            var actual = paquetesFiltrados[indiceActual];
            MostrarDetallePaquete(actual);
            lstPackages.Items.Clear();
            lstPackages.Items.Add(actual.ToString());
        }
        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = cmbState.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(estadoSeleccionado)) return;

            lstPackages.Items.Clear();
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (var linea in lineas)
                {
                    if (linea.Contains($", {estadoSeleccionado} "))
                    {
                        lstPackages.Items.Add(linea);
                    }
                }
            }
        }
    }
}
