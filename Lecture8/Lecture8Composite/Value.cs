namespace Lecture8Composite
{
	internal class Value : Expression
	{
		private int value;


		public Value(int value)
		{
			this.value = value;
		}


		public int GetValue()
		{
			return value;
		}
	}
}
