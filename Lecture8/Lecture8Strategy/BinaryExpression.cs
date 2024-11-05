namespace Lecture8Strategy
{
	internal class BinaryExpression : Expression
	{
		private Expression left;

		private Expression right;

		private BinaryOperation operation;


		public BinaryExpression(Expression left, Expression right, BinaryOperation operation)
		{
			this.left = left;
			this.right = right;
			this.operation = operation;
		}


		public int GetValue()
		{
			return operation.Compute(left.GetValue(), right.GetValue());
		}
	}
}
