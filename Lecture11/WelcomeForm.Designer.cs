namespace Lecture11
{
	partial class WelcomeForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			clickCounter = new Label();
			okButton = new Button();
			SuspendLayout();
			// 
			// clickCounter
			// 
			clickCounter.AutoSize = true;
			clickCounter.Location = new Point(21, 26);
			clickCounter.Name = "clickCounter";
			clickCounter.Size = new Size(28, 15);
			clickCounter.TabIndex = 0;
			clickCounter.Text = "XXX";
			// 
			// okButton
			// 
			okButton.AutoSize = true;
			okButton.Location = new Point(364, 211);
			okButton.Name = "okButton";
			okButton.Size = new Size(75, 25);
			okButton.TabIndex = 1;
			okButton.Text = "OK";
			okButton.UseVisualStyleBackColor = true;
			okButton.Click += okButton_Click;
			// 
			// WelcomeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(okButton);
			Controls.Add(clickCounter);
			Name = "WelcomeForm";
			Text = "Welcome!";
			Load += WelcomeForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label clickCounter;
		private Button okButton;
	}
}