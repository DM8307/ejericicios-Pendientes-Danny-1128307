namespace Flag_Quiz_Danny
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> banderas = new Dictionary<string, string>
{
    { "Flag-Afghanistan.jpg", "Afganistán" },
    { "Flag-Albania.jpg", "Albania" },
    { "Flag-Angola.jpg", "Angola" },
    { "Flag-Argentina.jpg", "Argentina" },
    { "Flag-Australia.jpg", "Australia" },
    { "Flag-Belgium.jpg", "Bélgica" },
    { "Flag-Brazil.jpg", "Brasil" },
    { "Flag-Cambodia.jpg", "Camboya" },
    { "Flag-Chile.jpg", "Chile" },
    { "Flag-Colombia.jpg", "Colombia" },
    { "Flag-Cuba.jpg", "Cuba" },
    { "Flag-Egypt.jpg", "Egipto" },
    { "Flag-Ethiopia.jpg", "Etiopía" },
    { "Flag-Fiji.jpg", "Fiyi" },
    { "Flag-France.jpg", "Francia" },
    { "Flag-India.jpg", "India" },
    { "FLAG-Ireland.jpg", "Irlanda" },
    { "Flag-Italy.jpg", "Italia" },
    { "Flag-Jamaica.jpg", "Jamaica" },
    { "Flag-Kenya.jpg", "Kenia" },
    { "Flag-Lebanon.jpg", "Líbano" },
    { "Flag-Mexico.jpg", "México" },
    { "Flag-Mozambique.jpg", "Mozambique" },
    { "Flag-Nepal.jpg", "Nepal" },
    { "Flag-Panama.jpg", "Panamá" },
    { "Flag-Papua-New-Guinea.jpg", "Papúa Nueva Guinea" },
    { "Flag-Portugal.jpg", "Portugal" },
    { "Flag-Saudi-Arabia.jpg", "Arabia Saudita" },
    { "Flag-South-Korea.jpg", "Corea del Sur" },
    { "Flag-Spain.jpg", "España" },
    { "Flag-Sri-Lanka.jpg", "Sri Lanka" },
    { "Flag-Sweden.jpg", "Suecia" },
    { "Flag-Switzerland.jpg", "Suiza" },
    { "Flag-Turkey.jpg", "Turquía" },
    { "Flag-Vatican-City-exception-rule-European-flag.jpg", "Ciudad del Vaticano" }
};

        public Form1()
        {
            InitializeComponent();
        }

        private List<string> clavesBarajadas;
        private int indiceActual = 0;
        private int aciertos = 0;
        private int totalRespuestas = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCountries.Items.AddRange(banderas.Values.ToArray());
            cmbCountries.SelectedIndex = -1;

            clavesBarajadas = banderas.Keys.OrderBy(k => Guid.NewGuid()).ToList();
            CargarBandera();
        }

        private void CargarBandera()
        {
            if (indiceActual < clavesBarajadas.Count)
            {
                string nombreArchivo = clavesBarajadas[indiceActual];

                try
                {
                    //Image imagen = Image.FromFile("Flag-Albania.jpg");
                    //pictureBox1.Image = imagen;
                    string rutaCompleta = Path.Combine(Application.StartupPath, "Flags", nombreArchivo);
                    pictureBox1.Image = Image.FromFile(rutaCompleta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error cargando imagen: {ex.Message}\nRuta: {Path.Combine("Flags", nombreArchivo)}");
                }
                txtFeedback.Clear();
                cmbCountries.SelectedIndex = -1;
            }
            else
            {
                EvaluarResultadoFinal();
            }
        }
        private void EvaluarResultadoFinal()
        {
            string resultado;

            if (aciertos <= 5)
                resultado = "Fail";
            else if (aciertos <= 15)
                resultado = "Poor";
            else if (aciertos <= 20)
                resultado = "Good";
            else if (aciertos <= 34)
                resultado = "Very Good!";
            else
                resultado = "Excellent!";

            txtFinalScore.Text = resultado;
            btnSubmit.Enabled = false;
            btnNext.Enabled = false;
            cmbCountries.Enabled = false;
        }
        private void PrepararJuego()
        {
            clavesBarajadas = banderas.Keys.OrderBy(_ => Guid.NewGuid()).ToList();
            indiceActual = 0;
            MostrarBanderaActual();
        }

        private void MostrarBanderaActual()
        {
            if (indiceActual < clavesBarajadas.Count)
            {
                string archivo = clavesBarajadas[indiceActual];
                pictureBox1.Image = Image.FromFile(Path.Combine("Flags", archivo));
                cmbCountries.SelectedIndex = -1;
                txtFeedback.Clear();
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (indiceActual >= clavesBarajadas.Count)
            {
                MessageBox.Show("Ya completaste todas las banderas.");
                return;
            }
            if (cmbCountries.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un país.", "Validación");
                return;
            }

            string seleccionUsuario = cmbCountries.SelectedItem.ToString();
            string nombreArchivo = clavesBarajadas[indiceActual];
            string respuestaCorrecta = banderas[nombreArchivo];

            totalRespuestas++;

            if (seleccionUsuario == respuestaCorrecta)
            {
                txtFeedback.Text = "Correcto";
                aciertos++;
            }
            else
            {
                txtFeedback.Text = "Incorrecto";
            }

            btnSubmit.Enabled = false;
            btnNext.Enabled = true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            indiceActual++;
            CargarBandera();
            btnNext.Enabled = false;
            btnSubmit.Enabled = true;
        }

    }
}
