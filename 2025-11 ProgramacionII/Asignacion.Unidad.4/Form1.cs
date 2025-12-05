namespace Asignacion.Unidad._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Readonly dropdown
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Subscribe to the selection changes
            comboBox1.SelectionChangeCommitted += OnSelectionChangeCommitted;
            
            // Autofill 
            for (int month = 1; month <= 12; month++)
            {
                comboBox1.Items.Add(month);
            }
        }

        private void OnSelectionChangeCommitted(object? sender, EventArgs e)
        {
            var cbx = sender as ComboBox;
            var monthName = GetMonthName(Convert.ToInt32(cbx!.SelectedItem));
            selectedMonth.Text = monthName;
        }

        private static string GetMonthName(int month)
        {
            return month switch
            {
                1 => "Enero",
                2 => "Febrero",
                3 => "Marzo",
                4 => "Abril",
                5 => "Mayo",
                6 => "Junio",
                7 => "Julio",
                8 => "Agosto",
                9 => "Septiembre",
                10 => "Octubre",
                11 => "Noviembre",
                12 => "Diciembre",
                _ => throw new ArgumentOutOfRangeException(nameof(month), month, null)
            };
        }
    }
}
