namespace Calculadoradepagosylistas
{
    public partial class Form1 : Form
    {
        private static Calculadoradepagos? calculadoradepagosfrm;
        private static Listas? listasfrm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calculadoradepagosfrm == null || calculadoradepagosfrm.IsDisposed)
            {
                calculadoradepagosfrm = new Calculadoradepagos();
                calculadoradepagosfrm.FormClosed += (s, args) => this.Show();
                this.Hide();
                calculadoradepagosfrm.Show();
            }
            else
            {
                calculadoradepagosfrm.BringToFront();
            }
        }
        private void button2_Click(object sebder, EventArgs e)
        {
            if (listasfrm == null || listasfrm.IsDisposed)
            {
                listasfrm = new Listas();
                listasfrm.FormClosed += (s, args) => this.Show();
                this.Hide();
                listasfrm.Show();
            }
            else
            {
                listasfrm.BringToFront();
            }
        }
    }
}
