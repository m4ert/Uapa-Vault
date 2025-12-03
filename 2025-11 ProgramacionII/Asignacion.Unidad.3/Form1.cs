namespace Asignacion.Unidad._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnMultiply(object sender, EventArgs e)
        {
            var values = GetValues();
            DisplayResult(values.Number1 *  values.Number2);
        }
        
        private void OnDivide(object sender, EventArgs e)
        {
            var values = GetValues();
            DisplayResult(values.Number1 /  values.Number2);
        }
        
        private void OnSubtract(object sender, EventArgs e)
        {
            var values = GetValues();
            DisplayResult(values.Number1 -  values.Number2);
        }
        
        private void OnAppend(object sender, EventArgs e)
        {
            var values = GetValues();
            DisplayResult(values.Number1 +  values.Number2);
        }

        private (float Number1, float Number2) GetValues()
        {
            return (float.Parse(firstNumber.Text), float.Parse(secondNumber.Text));
        }

        private void DisplayResult(float result)
        {
            this.resultLabel.Text = @$"Result: {result}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
