namespace Lecture13.UI
{
	partial class CalculatorForm
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
			valueLabel = new Label();
			numberButton0 = new Button();
			numberButton1 = new Button();
			numberButton2 = new Button();
			numberButton3 = new Button();
			numberButton4 = new Button();
			numberButton5 = new Button();
			numberButton6 = new Button();
			numberButton7 = new Button();
			numberButton8 = new Button();
			numberButton9 = new Button();
			decimalsButton = new Button();
			clearButton = new Button();
			SuspendLayout();
			// 
			// valueLabel
			// 
			valueLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			valueLabel.Location = new Point(12, 9);
			valueLabel.Name = "valueLabel";
			valueLabel.Size = new Size(776, 25);
			valueLabel.TabIndex = 0;
			valueLabel.Text = "0";
			valueLabel.TextAlign = ContentAlignment.MiddleRight;
			// 
			// numberButton0
			// 
			numberButton0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton0.Location = new Point(12, 238);
			numberButton0.Name = "numberButton0";
			numberButton0.Size = new Size(40, 40);
			numberButton0.TabIndex = 1;
			numberButton0.Text = "0";
			numberButton0.UseVisualStyleBackColor = true;
			numberButton0.Click += numberButton_Click;
			// 
			// numberButton1
			// 
			numberButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton1.Location = new Point(12, 192);
			numberButton1.Name = "numberButton1";
			numberButton1.Size = new Size(40, 40);
			numberButton1.TabIndex = 2;
			numberButton1.Text = "1";
			numberButton1.UseVisualStyleBackColor = true;
			numberButton1.Click += numberButton_Click;
			// 
			// numberButton2
			// 
			numberButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton2.Location = new Point(58, 192);
			numberButton2.Name = "numberButton2";
			numberButton2.Size = new Size(40, 40);
			numberButton2.TabIndex = 3;
			numberButton2.Text = "2";
			numberButton2.UseVisualStyleBackColor = true;
			numberButton2.Click += numberButton_Click;
			// 
			// numberButton3
			// 
			numberButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton3.Location = new Point(104, 192);
			numberButton3.Name = "numberButton3";
			numberButton3.Size = new Size(40, 40);
			numberButton3.TabIndex = 4;
			numberButton3.Text = "3";
			numberButton3.UseVisualStyleBackColor = true;
			numberButton3.Click += numberButton_Click;
			// 
			// numberButton4
			// 
			numberButton4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton4.Location = new Point(12, 146);
			numberButton4.Name = "numberButton4";
			numberButton4.Size = new Size(40, 40);
			numberButton4.TabIndex = 5;
			numberButton4.Text = "4";
			numberButton4.UseVisualStyleBackColor = true;
			numberButton4.Click += numberButton_Click;
			// 
			// numberButton5
			// 
			numberButton5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton5.Location = new Point(58, 146);
			numberButton5.Name = "numberButton5";
			numberButton5.Size = new Size(40, 40);
			numberButton5.TabIndex = 6;
			numberButton5.Text = "5";
			numberButton5.UseVisualStyleBackColor = true;
			numberButton5.Click += numberButton_Click;
			// 
			// numberButton6
			// 
			numberButton6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton6.Location = new Point(104, 146);
			numberButton6.Name = "numberButton6";
			numberButton6.Size = new Size(40, 40);
			numberButton6.TabIndex = 7;
			numberButton6.Text = "6";
			numberButton6.UseVisualStyleBackColor = true;
			numberButton6.Click += numberButton_Click;
			// 
			// numberButton7
			// 
			numberButton7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton7.Location = new Point(12, 100);
			numberButton7.Name = "numberButton7";
			numberButton7.Size = new Size(40, 40);
			numberButton7.TabIndex = 8;
			numberButton7.Text = "7";
			numberButton7.UseVisualStyleBackColor = true;
			numberButton7.Click += numberButton_Click;
			// 
			// numberButton8
			// 
			numberButton8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton8.Location = new Point(58, 100);
			numberButton8.Name = "numberButton8";
			numberButton8.Size = new Size(40, 40);
			numberButton8.TabIndex = 9;
			numberButton8.Text = "8";
			numberButton8.UseVisualStyleBackColor = true;
			numberButton8.Click += numberButton_Click;
			// 
			// numberButton9
			// 
			numberButton9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			numberButton9.Location = new Point(104, 100);
			numberButton9.Name = "numberButton9";
			numberButton9.Size = new Size(40, 40);
			numberButton9.TabIndex = 10;
			numberButton9.Text = "9";
			numberButton9.UseVisualStyleBackColor = true;
			numberButton9.Click += numberButton_Click;
			// 
			// decimalsButton
			// 
			decimalsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			decimalsButton.Location = new Point(58, 238);
			decimalsButton.Name = "decimalsButton";
			decimalsButton.Size = new Size(40, 40);
			decimalsButton.TabIndex = 11;
			decimalsButton.Text = ",";
			decimalsButton.UseVisualStyleBackColor = true;
			decimalsButton.Click += decimalsButton_Click;
			// 
			// clearButton
			// 
			clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			clearButton.Location = new Point(104, 238);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(40, 40);
			clearButton.TabIndex = 12;
			clearButton.Text = "C";
			clearButton.UseVisualStyleBackColor = true;
			clearButton.Click += clearButton_Click;
			// 
			// CalculatorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(clearButton);
			Controls.Add(decimalsButton);
			Controls.Add(numberButton9);
			Controls.Add(numberButton8);
			Controls.Add(numberButton7);
			Controls.Add(numberButton6);
			Controls.Add(numberButton5);
			Controls.Add(numberButton4);
			Controls.Add(numberButton3);
			Controls.Add(numberButton2);
			Controls.Add(numberButton1);
			Controls.Add(numberButton0);
			Controls.Add(valueLabel);
			Name = "CalculatorForm";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Label valueLabel;
		private Button numberButton0;
		private Button numberButton1;
		private Button numberButton2;
		private Button numberButton3;
		private Button numberButton4;
		private Button numberButton5;
		private Button numberButton6;
		private Button numberButton7;
		private Button numberButton8;
		private Button numberButton9;
		private Button decimalsButton;
		private Button clearButton;
	}
}