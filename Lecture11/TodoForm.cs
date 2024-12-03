using System.Windows.Forms;

namespace Lecture11
{
	public partial class TodoForm : Form
	{
		private readonly TodoManager todoManager;

		private BindingSource bindingSource = new BindingSource();


		public TodoForm(TodoManager todoManager)
		{
			InitializeComponent();
			this.todoManager = todoManager;
			bindingSource.DataSource = new List<Todo>(this.todoManager.GetTodos());
			dataGridView1.DataSource = bindingSource;
			dataGridView2.DataSource = bindingSource;

			DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
			dataGridView1.Columns.Add(deleteButtonColumn);
		}


		private void addButton_Click(object sender, EventArgs e)
		{
			string title = newTodoTitle.Text;
			if (title == "") {
				MessageBox.Show("Title cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			Todo todo = todoManager.AddTodo(title);
			bindingSource.Add(todo);
			newTodoTitle.Text = "";
		}


		private bool IsCheckBoxCell(DataGridView dataGridView, int columnIndex, int rowIndex)
		{
			return columnIndex >= 0 &&
				columnIndex < dataGridView.ColumnCount &&
				rowIndex >= 0 &&
				rowIndex < dataGridView.RowCount &&
				dataGridView[columnIndex, rowIndex] is DataGridViewCheckBoxCell;
		}


		private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			// BindData();
		}


		private void dataGridView_CellMouseUpOrDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridView dataGridView = sender as DataGridView;
			if (dataGridView != null && IsCheckBoxCell(dataGridView, e.ColumnIndex, e.RowIndex)) {
				dataGridView.EndEdit();
			}
		}

		private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			MessageBox.Show("addd");
		}

		private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			MessageBox.Show("delete");
		}
	}
}
