namespace Lecture11
{
	public partial class TodoForm : Form
	{
		private readonly TodoManager todoManager;


		public TodoForm(TodoManager todoManager)
		{
			InitializeComponent();
			this.todoManager = todoManager;
			todoManagerBindingSource.DataSource = this.todoManager;
		}


		private void addButton_Click(object sender, EventArgs e)
		{
			string title = newTodoTitle.Text;
			if (title == "") {
				MessageBox.Show("Title cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			todoManager.AddTodo(title);
			newTodoTitle.Text = "";
		}
	}
}
