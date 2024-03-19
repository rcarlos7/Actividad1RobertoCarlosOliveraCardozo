using Actividad1.BSS;
using Actividad1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Actividad1.VISTA.ComputadoraVistas
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }

        ComputadoraBss bss = new ComputadoraBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Computadora computadora = new Computadora();
            computadora.Nombre = textBox1.Text;
            computadora.Descripcion = textBox2.Text;
            computadora.Precio = Convert.ToDecimal(textBox3.Text);
            computadora.FechadeFabricacion = dateTimePicker1.Value;

            bss.InsertarComputadoraBss(computadora);
            MessageBox.Show("Se guardo correctamente la computadora");
        }
    }
}
