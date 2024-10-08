namespace Lecture6MethodOverloading
{
	internal static class Utils
	{
		public static int Length()
		{
			return Length("nothing");
		}


		public static int Length(int number)
		{
			if (number == 0) {
				return 1;
			}

			if (number < 0) {
				return Length(-number) + 1;
			}

			return (int) Math.Log10(number) + 1;
		}


		public static int Length(string str)
		{
			return str.Length;
		}


		/*
		public static string Length(string str)
		{
			return str;
		}
		*/


		public static int Length<T>(T[] array)
		{
			return array.Length;
		}


		public static int Length(Parent parent)
		{
			parent.test();
			return Length("Parent");
		}


		public static int Length(Child child)
		{
			child.test();
			return Length("Child");
		}


		public static int LengthVirtual(Parent parent)
		{
			return Length(parent.ToString());
		}
	}
}
