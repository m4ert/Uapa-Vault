namespace Asignacion.ProyectoFinal._5
{
    public partial class Form1 : Form
    {
        private const string Entrada = "Entrada";
        private const string Salida = "Salida";

        public Form1()
        {
            InitializeComponent();

            typeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCbx.Items.Add(Entrada);
            typeCbx.Items.Add(Salida);

            dataGridView1.Columns.Add("ProductCode", "Codigo");
            dataGridView1.Columns.Add("Name", "Nombre");
            dataGridView1.Columns.Add("Type", "Tipo");
            dataGridView1.Columns.Add("Quantity", "Cantidad");
            dataGridView1.Columns.Add("Date", "Fecha");
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(quantityTbx.Text, out var quantity) ||
                quantity < 0)
            {
                MessageBox.Show("Cantidad invalida");
                return;
            }


            dataGridView1.Rows.Add(
                productCodeTbx.Text,
                nameTbx.Text,
                typeCbx.SelectedItem?.ToString() ?? "",
                quantityTbx.Text,
                datePicker.Value.ToShortDateString()
            );

            CalculateTotals();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selection = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selection)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

            CalculateTotals();
        }

        private void CalculateTotals()
        {
            CalculateInbounds(out var totalInbounds);
            CalculateOutbounds(out var totalOutbounds);

            stockNetoLabel.Text = $"Stock Neto: {totalInbounds - totalOutbounds}";
        }

        private void CalculateInbounds(out int totalInbounds)
        {
            totalInbounds = GetTotalType(Entrada);
            inboundLabel.Text = $"Total Entradas: {totalInbounds}";
        }

        private void CalculateOutbounds(out int totalOutbounds)
        {
            totalOutbounds = GetTotalType(Salida);
            outboundLabel.Text = $"Total Salidas: {totalOutbounds}";
        }

        private int GetTotalType(string type)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Type"].Value?.ToString() == type)
                {
                    total += Int32.Parse(row.Cells["Quantity"].Value?.ToString() ?? "0");
                }
            }

            return total;
        }
    }
}
