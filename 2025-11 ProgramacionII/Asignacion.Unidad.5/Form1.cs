namespace Asignacion.Unidad._5
{
    public partial class Form1 : Form
    {
        private static class AccountType
        {
            public const string Debit = "Debito";
            public const string Credit = "Credito";
            
            public static readonly string[] Values = [Debit, Credit];
        }
        
        public Form1()
        {
            InitializeComponent();

            typeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCbx.Items.AddRange(AccountType.Values);
            
            addBtn.Click += AddBtnOnClick;
   
            resultsDg.AllowUserToAddRows = false;
            resultsDg.RowsAdded += UpdateResults;
            resultsDg.RowsRemoved += UpdateResults;
            resultsDg.CellValueChanged += UpdateResults;
            
            resultsDg.Columns.Add("account", "Cuenta");
            resultsDg.Columns.Add("accountName", "Nombre Cuenta");
            resultsDg.Columns.Add("accountDebit", "Debito");
            resultsDg.Columns.Add("accountCredit", "Credito");
        }
        
        private void AddBtnOnClick(object? sender, EventArgs e)
        {
            double debitValue = 0, creditValue = 0;
            var totalValue = Double.Parse(totalTbx.Text);
            
            switch (typeCbx.Text)
            {
                case AccountType.Debit:
                    debitValue = totalValue;
                    break;
                case AccountType.Credit:
                    creditValue = totalValue;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            // Add cells
            var newRow = new DataGridViewRow();
            newRow.CreateCells(resultsDg);
            
            newRow.Cells[0].Value = accountTbx.Text;
            newRow.Cells[1].Value = accountNameTbx.Text;
            newRow.Cells[2].Value = debitValue;
            newRow.Cells[3].Value = creditValue;

            resultsDg.Rows.Add(newRow);

            resultsDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Clean up
            accountTbx.Text = String.Empty;
            accountNameTbx.Text = String.Empty;
            totalTbx.Text = String.Empty;
            typeCbx.SelectedItem = null;
        }
        
        private void UpdateResults(object? sender, EventArgs e)
        {
            double totalDebits = 0, totalCredits = 0;
            foreach (DataGridViewRow row in resultsDg.Rows)
            {
                totalDebits += Convert.ToDouble(row.Cells[2].Value);
                totalCredits += Convert.ToDouble(row.Cells[3].Value);
            }
            
            totalDebitCbx.Text = totalDebits.ToString("C");
            totalCreditsCbx.Text = totalCredits.ToString("C");
        }
    }
}
