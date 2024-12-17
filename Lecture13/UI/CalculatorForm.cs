using Lecture13.Model;

namespace Lecture13.UI
{
	public partial class CalculatorForm : Form
	{
		Calculator calculator;

		int decimals = 0;


		public CalculatorForm(Calculator calculator)
		{
			this.calculator = calculator;
			InitializeComponent();
			printValue();
		}


		private void printValue()
		{
			valueLabel.Text = calculator.Value.ToString(string.Format("N{0}", decimals > 0 ? decimals - 1 : 0));
		}


		private void numberButton_Click(object sender, EventArgs e)
		{
			int buttonValue = int.Parse((sender as Button).Text);
			double newValue = decimals == 0 ?
				calculator.Value * 10 + buttonValue :
				calculator.Value + buttonValue * Math.Pow(10, -decimals++);
			calculator.EnterValue(newValue);
			printValue();
		}


		private void decimalsButton_Click(object sender, EventArgs e)
		{
			if (decimals == 0) {
				decimals = 1;
			}
		}


		private void clearButton_Click(object sender, EventArgs e)
		{
			calculator.Clear();
			decimals = 0;
			printValue();
		}
	}
}