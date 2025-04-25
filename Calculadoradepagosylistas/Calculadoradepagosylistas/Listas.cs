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
    public partial class Listas : Form
    {
        public Listas()
        {
            InitializeComponent();
        }

        private void btnañadirelementolistasin_Click(object sender, EventArgs e)
        {
            try
            {
                string entrada = Interaction.InputBox("Introduzca un elemento");

                if (!string.IsNullOrWhiteSpace(entrada)) // Verifica que no sea vacío
                {
                    lbsinordenar.Items.Add(entrada);
                }
                else
                {
                    MessageBox.Show("No puede dejar el espacio nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnañadirelementolistaordenada_Click(object sender, EventArgs e)
        {
            try
            {
                string entrada = Interaction.InputBox("Introduzca un elemento");

                if (!string.IsNullOrWhiteSpace(entrada)) // Verifica que no sea vacío
                {
                    lbordenada.Items.Add(entrada);
                }
                else
                {
                    MessageBox.Show("No puede dejar el espacio nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnborrarelementolistasin_Click(object sender, EventArgs e)
        {
            if (lbsinordenar.SelectedItem != null)
            {
                lbsinordenar.Items.Remove(lbsinordenar.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnborrarlistasin_Click(object sender, EventArgs e)
        {
            lbsinordenar.Items.Clear();
        }
        private void btnborrarelelistaordenada_Click(object sender, EventArgs e)
        {
            if (lbordenada.SelectedItem != null)
            {
                lbordenada.Items.Remove(lbordenada.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnborrarlistaordenada_Click(object sender, EventArgs e)
        {
            lbordenada.Items.Clear(); 
        }

        private void btnmoverasin_Click(object sender, EventArgs e)
        {
            List<object> seleccionados = new List<object>();

            foreach (var item in lbordenada.SelectedItems)
            {
                seleccionados.Add(item);
            }

            foreach (var item in seleccionados)
            {
                lbsinordenar.Items.Add(item);
                lbordenada.Items.Remove(item);
            }
        }

        private void btnmoveraordenada_Click(object sender, EventArgs e)
        {
            if (lbsinordenar.SelectedItem != null)
            {
                lbordenada.Items.Add(lbsinordenar.SelectedItem);
                lbsinordenar.Items.Remove(lbsinordenar.SelectedItem);
                
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para mover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
