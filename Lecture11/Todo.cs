namespace Lecture11
{
	public class Todo
	{
		public string Title { get; set; }
		public bool Completed { get; set; } = false;


		public Todo(string title)
		{
			Title = title;
		}
	}
}
