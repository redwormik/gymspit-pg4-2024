namespace Lecture11
{
	public class TodoManager
	{
		private IList<Todo> todos = new List<Todo>();


		public void AddTodo(string title)
		{
			todos.Add(new Todo(title));
		}


		public Todo[] GetTodos()
		{
			return todos.ToArray();
		}
	}
}
