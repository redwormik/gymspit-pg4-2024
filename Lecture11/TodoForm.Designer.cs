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
			newTodoTitle = new TextBox();
			addButton = new Button();
			dataGridView1 = new DataGridView();
			dataGridView2 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(129, 144);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(240, 150);
			dataGridView1.TabIndex = 2;
			dataGridView1.CellMouseDoubleClick += dataGridView_CellMouseUpOrDoubleClick;
			dataGridView1.CellMouseUp += dataGridView_CellMouseUpOrDoubleClick;
			dataGridView1.CellValueChanged += dataGridView_CellValueChanged;
			dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
			dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(428, 144);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.Size = new Size(240, 150);
			dataGridView2.TabIndex = 3;
			dataGridView2.CellMouseDoubleClick += dataGridView_CellMouseUpOrDoubleClick;
			dataGridView2.CellMouseUp += dataGridView_CellMouseUpOrDoubleClick;
			dataGridView2.CellValueChanged += dataGridView_CellValueChanged;
			// 
			// TodoForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView2);
			Controls.Add(dataGridView1);
			Controls.Add(addButton);
			Controls.Add(newTodoTitle);
			Name = "TodoForm";
			Text = "TodoForm";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox newTodoTitle;
		private Button addButton;
		private DataGridView dataGridView1;
		private DataGridView dataGridView2;
	}
}