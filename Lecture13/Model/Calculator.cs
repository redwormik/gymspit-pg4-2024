namespace Lecture13.Model
{
	public class Calculator
	{
		private double left;

		private double right;

		private BinaryOperation operation;

		private bool hasValue;

		public double Value => operation == BinaryOperation.None ? left : right;

		public BinaryOperation Operation => operation;


		public Calculator()
		{
			Clear();
		}


		public void EnterValue(double value)
		{
			if (operation == BinaryOperation.None) {
				left = value;
			} else {
				right = value;
			}

			hasValue = true;
		}


		public void EnterOperation(BinaryOperation op)
		{
			if (operation == BinaryOperation.None && !hasValue) {
				return;
			}

			if (operation != BinaryOperation.None && hasValue) {
				Evaluate();
			}

			operation = op;
			hasValue = false;
		}


		public double Evaluate()
		{
			double result = Compute();
			left = result;
			right = 0.0;
			operation = BinaryOperation.None;
			return result;
		}


		public void Clear()
		{
			left = 0.0;
			right = 0.0;
			operation = BinaryOperation.None;
			hasValue = false;
		}


		private double Compute() {
			if (!hasValue) {
				return left;
			}

			switch (operation) {
				case BinaryOperation.None: return left;
				case BinaryOperation.Addition: return left + right;
				case BinaryOperation.Subtraction: return left - right;
				case BinaryOperation.Multiplication: return left * right;
				case BinaryOperation.Division: return left / right;
				default: throw new InvalidOperationException();
			}
		}
	}
}
