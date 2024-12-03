namespace Lecture11
{
	public class TodoManager
	{
		private IList<Todo> todos = new List<Todo>();


		public Todo AddTodo(string title)
		{
			Todo todo = new Todo(title);
			todos.Add(todo);
			return todo;
		}


		public Todo[] GetTodos()
		{
			return todos.ToArray();
		}
	}
}
