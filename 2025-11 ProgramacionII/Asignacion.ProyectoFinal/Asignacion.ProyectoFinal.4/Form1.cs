using Microsoft.VisualBasic;

namespace Asignacion.ProyectoFinal._4
{
    public partial class Form1 : Form
    {
        private const string KgToLbs = "Kilogramos a Libras";
        private const string LbsToKg = "Libras a Kilogramos";

        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add(KgToLbs);
            comboBox1.Items.Add(LbsToKg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(valueTbx.Text, out var result))
            {
                var convertion = Convert(result);
                resultLabel.Text = $"Resultado: {convertion}";
                RegisterConvertion(result, convertion);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido.");
                return;
            }
        }

        private void RegisterConvertion(double input, double convertion)
        {
            historyLbx.Items.Add($"{DateTime.Now} | {input} {comboBox1.SelectedItem} = {convertion}");

            // Cannot exceed from 5 items in history
            if (historyLbx.Items.Count > 5)
            {
                historyLbx.Items.RemoveAt(0);
            }
        }

        private double Convert(double value)
        {
            return comboBox1.SelectedItem switch
            {
                KgToLbs => ConvertKgToLbs(value),
                LbsToKg => ConvertLbsToKg(value),
                _ => 0
            };
        }

        private static double ConvertLbsToKg(double lbs)
        {
            return lbs * 0.453592;
        }

        private static double ConvertKgToLbs(double kgs)
        {
            return kgs * 2.20462;
        }
    }
}
