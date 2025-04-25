namespace Microondas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declarar una variable de tipo string para almacenar lo que el usuario digita como un tiempo
        string tiempo = "";
        Timer temporizador;

        private void DisplayTime()
        {
            //aqui tomamos lo que tiene la varible tiempo y lo convertimos a un formato de hh:mm:ss
            int horas, minutos, segundos;

            //nos vamos a asegurar que la variable tiempo tenga 5 caracteres
            if (tiempo.Length > 5)
            {
                tiempo = tiempo.Substring(0, 5);
            }

            string display;
            display = tiempo.PadLeft(5, '0');

            //vamos a transformar a horas, minutos y segundos

            horas = int.Parse(display.Substring(0, 1));
            minutos = int.Parse(display.Substring(1, 2));
            segundos = int.Parse(display.Substring(3, 2));

            if (segundos > 59)
            {
                segundos = 59;
            }

            if (minutos > 59)
            {
                minutos = 59;
            }

            lblpantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn1.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn2.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //vamos concatenado lo digitado por el usuario
            tiempo = tiempo + btn3.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn4.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn5.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn6.Text;
            //mostrar en la pantalla
            DisplayTime();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn7.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn8.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn9.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn0.Text;
            //mostrar en la pantalla
            DisplayTime();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Descomponer nuestro tiempo en horas, minutos y segundos
            int horas, minutos, segundos;

            //vamos a transformar a horas, minutos y segundos

            tiempo = tiempo.PadLeft(5, '0');
            horas = int.Parse(tiempo.Substring(0, 1));
            minutos = int.Parse(tiempo.Substring(1, 2));
            segundos = int.Parse(tiempo.Substring(3, 2));

            //crear un objeto Tiempo

            temporizador = new Timer(horas, minutos, segundos);

            //mostrar ese objeto temporizador en la pantalla
            lblpantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", temporizador.Horas, temporizador.Minutos, temporizador.Segundos);

            //iniciar el temporizador activando el timer
            timer1.Enabled = true;
            pnlPrincipal.BackColor = Color.Yellow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //decrementar los atributos del objeto Timer
            if (temporizador.Segundos > 0)
            {
                temporizador.Segundos--;
            }
            else if (temporizador.Minutos > 0)
            {
                temporizador.Minutos--;
                temporizador.Segundos = 59;
            }
            else if (temporizador.Horas > 0)
            {
                temporizador.Horas--;
                temporizador.Minutos = 59;
                temporizador.Segundos = 59;
            }
            else
            {
                //El temporizador ha llegado a cero
                timer1.Enabled = false;
                tiempo = "";
                pnlPrincipal.BackColor = SystemColors.Control;

            }

            if (temporizador.Horas == 0 && temporizador.Minutos == 0 && temporizador.Segundos == 0)
            {
                lblpantalla.Text = "Fin";
            }
            else
            {
                lblpantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", temporizador.Horas, temporizador.Minutos, temporizador.Segundos);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                //reiniciar el temporizador
                tiempo = "";
                lblpantalla.Text = "00:00:00";
            }
            //detener el temporizador
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                //Guardar el tiempo restante
                tiempo = string.Format("{0:D1}{1:D2}{2:D2}", temporizador.Horas, temporizador.Minutos, temporizador.Segundos);
                //mostrar el tiempo restante
                lblpantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", temporizador.Horas, temporizador.Minutos, temporizador.Segundos);
                //cambiar el color del panel
                pnlPrincipal.BackColor = SystemColors.Control;
            }
        }
    }
}
