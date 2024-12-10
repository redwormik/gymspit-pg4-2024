using Lecture13.Model;

namespace Lecture13.UI
{
	public partial class CalculatorForm : Form
	{
		Calculator calculator;


		public CalculatorForm(Calculator calculator)
		{
			this.calculator = calculator;
			InitializeComponent();
		}


		private void numberButton_Click(object sender, EventArgs e)
		{
			int value = int.Parse((sender as Button).Text);
			calculator.EnterValue(calculator.Value * 10 + value);
			valueLabel.Text = calculator.Value.ToString();
		}
	}
}