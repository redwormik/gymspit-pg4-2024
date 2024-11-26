namespace Lecture11
{
	partial class TodoForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			newTodoTitle = new TextBox();
			addButton = new Button();
			dataGridView1 = new DataGridView();
			todoManagerBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)todoManagerBindingSource).BeginInit();
			SuspendLayout();
			// 
			// newTodoTitle
			// 
			newTodoTitle.Location = new Point(12, 12);
			newTodoTitle.Name = "newTodoTitle";
			newTodoTitle.Size = new Size(695, 23);
			newTodoTitle.TabIndex = 0;
			// 
			// addButton
			// 
			addButton.Location = new Point(713, 12);
			addButton.Name = "addButton";
			addButton.Size = new Size(75, 23);
			addButton.TabIndex = 1;
			addButton.Text = "Add todo";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.DataSource = todoManagerBindingSource;
			dataGridView1.Location = new Point(129, 144);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(240, 150);
			dataGridView1.TabIndex = 2;
			// 
			// todoManagerBindingSource
			// 
			todoManagerBindingSource.DataSource = typeof(TodoManager);
			// 
			// TodoForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView1);
			Controls.Add(addButton);
			Controls.Add(newTodoTitle);
			Name = "TodoForm";
			Text = "TodoForm";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)todoManagerBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox newTodoTitle;
		private Button addButton;
		private DataGridView dataGridView1;
		private BindingSource todoManagerBindingSource;
	}
}