namespace Asignacion.ProyectoFinal._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(kgTbx.Text.Trim(), out var kgTotal))
            {
                if (kgTotal < 0)
                {
                    MessageBox.Show("El valor introducido no puede ser negativo.");
                    return;
                }

                var lbTotal = kgTotal * 2.20462;
                resultLabel.Text = $"Libras: {lbTotal}";
            }
            else
            {
                MessageBox.Show("El valor introducido es invalido.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kgTbx.Text = String.Empty;
            resultLabel.Text = "Libras: ";
        }
    }
}
