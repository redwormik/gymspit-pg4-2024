namespace Lecture11
{
	public partial class WelcomeForm : Form
	{
		private int clickedTimes = 0;

		private Random random = new Random();


		public WelcomeForm()
		{
			InitializeComponent();
		}


		private void WelcomeForm_Load(object sender, EventArgs e)
		{
			clickCounter.Text = clickedTimes.ToString();
		}


		private void okButton_Click(object sender, EventArgs e)
		{
			clickedTimes += 1;
			clickCounter.Text = clickedTimes.ToString();

			if (clickedTimes >= 5) {
				DialogResult = DialogResult.Continue;
				Close();
				return;
			}

			int maxX = Math.Max(0, Size.Width - okButton.Size.Width - 40);
			int maxY = Math.Max(0, Size.Height - okButton.Size.Height - 40);
			okButton.Location = new Point(random.Next(0, maxX), random.Next(0, maxY));
		}
	}
}