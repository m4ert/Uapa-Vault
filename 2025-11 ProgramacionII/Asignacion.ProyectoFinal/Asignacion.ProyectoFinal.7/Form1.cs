namespace Asignacion.ProyectoFinal._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new Asignacion.ProyectoFinal._2.Form1(); 
            form.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form = new Asignacion.ProyectoFinal._3.Form1();
            form.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var form = new Asignacion.ProyectoFinal._4.Form1();
            form.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var form = new Asignacion.ProyectoFinal._5.Form1();
            form.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var form = new Asignacion.ProyectoFinal._6.Form1();
            form.Show();
        }
    }
}
