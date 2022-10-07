using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TreeView___MenuStrip
{
    public partial class Pantalla_CrearUsuario : Form
    {
        public Pantalla_CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Pantalla1 P1 = new Pantalla1();
            P1.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TextWriter Registro = new StreamWriter(@"D:\PracticasVS\Practicas_VisualStudio\TreeView - MenuStrip\bin\Debug\" + tBUsuarioNuevo.Text + ".txt", true);
            Registro.WriteLine(tBContraseñaNuevo.Text);
            Registro.Close();
            this.Hide();
            MessageBox.Show("Se registró con éxito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Pantalla1 P1 = new Pantalla1();
            P1.Show();
        }
    }
}
