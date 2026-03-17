using SLWConnectionDialog;

namespace TestHarnessConnectionDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DlgConnection dlg = new DlgConnection();
            if (dlg.ShowDialog() == DialogResult.OK)
                Text = "OK";

        }
    }
}
