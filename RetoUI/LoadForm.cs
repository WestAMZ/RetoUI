namespace RetoUI
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            this.timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 10;
            }
            else
            {
                timer.Stop();
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
        }
    }
}
