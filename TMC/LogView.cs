namespace TMC
{
    public partial class LogView : Form
    {
        public LogView() => InitializeComponent();
        private void LogView_Load(object sender, EventArgs e) { label1.Text = ""; for (int i = 0; i < VERSION.UPDATE_LOGS.Count; i++) { label1.Text += $"\n{VERSION.UPDATE_LOGS[i]}"; }; }
    }
}
