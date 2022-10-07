namespace TreeView___MenuStrip
{
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Equipo conformado por:\n" +
                "Alan Antonio Medina Juarez\n" +
                "Oscar Oziel Padilla Bárcenas","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_CrearUsuario CU = new Pantalla_CrearUsuario();
            CU.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader InicioSesion = new StreamReader(@"D:\PracticasVS\Practicas_VisualStudio\TreeView - MenuStrip\bin\Debug\" + tBUsuario.Text + ".txt");

                if (InicioSesion.ReadLine()==tBContraseña.Text)
                {
                    Pantalla2 P2 = new Pantalla2();
                    this.Hide();
                    P2.Show();
                    P2.cargarToolStripMenuItem_Click(sender,e);
                    tBUsuario.Clear();
                    tBContraseña.Clear();
                }
                else
                {
                    lblErrores.Text = "Contraseña equivocada";
                }
            }
            catch (Exception)
            {
                lblErrores.Text = "Usuario no encontrado";
                tBUsuario.Clear();
                tBContraseña.Clear();
            }
            
        }
    }
}