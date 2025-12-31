namespace Asignacion.Unidad._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            authorToolStripMenuItem.Click += AuthorToolStripMenuItemOnClick;
        }

        void AuthorToolStripMenuItemOnClick(object? sender, EventArgs e)
        {
            MessageBox.Show(@"
                Matricula: 100088713
                Nombre: Angel
                Apellido: Marte
                Carrera: Ingenieria en Software
            ");
        }
    }
}
