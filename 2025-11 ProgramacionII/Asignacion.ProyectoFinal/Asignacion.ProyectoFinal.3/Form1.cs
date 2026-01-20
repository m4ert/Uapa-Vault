namespace Asignacion.ProyectoFinal._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(lbTbx.Text.Trim(), out var lbTotal))
            {
                if (lbTotal is < 0 or > 10000)
                {
                    MessageBox.Show("El valor introducido supera el limite.");
                    return;
                }

                var kgTotal = lbTotal * 0.453592;
                resultLabel.Text = $"Kilogramos: {kgTotal}";
            }
            else
            {
                MessageBox.Show("El valor introducido es invalido.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbTbx.Text = String.Empty;
            resultLabel.Text = "Kilogramos: ";
        }
    }
}
