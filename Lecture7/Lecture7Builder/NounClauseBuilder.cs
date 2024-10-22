namespace Lecture7Builder
{
	internal class NounClauseBuilder
	{
		private string noun;

		private string size;

		private IList<string> colors;


		public NounClauseBuilder(string noun)
		{
			this.noun = noun;
			size = "";
			colors = new List<string>();
		}


		public NounClauseBuilder SetSize(string size)
		{
			this.size = size;
			return this;
		}


		public NounClauseBuilder AddColor(string color)
		{
			colors.Add(color);
			return this;
		}


		public string GetNounClause()
		{
			IList<string> parts = new List<string>();

			if (size != "") {
				parts.Add(size);
			}

			string colorPart = GetColorPart();
			if (colorPart != "") {
				parts.Add(colorPart);
			}

			parts.Add(noun);
			return string.Join(" ", parts.ToArray());
		}


		private string GetColorPart()
		{
			if (colors.Count == 0) {
				return "";
			}

			if (colors.Count == 1) {
				return colors.First();
			}

			IList<string> allButLast = new List<string>(colors);
			allButLast.RemoveAt(allButLast.Count - 1);
			return string.Format("{0} and {1}", string.Join(", ", allButLast), colors.Last());
		}
	}
}
