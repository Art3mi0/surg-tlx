namespace surg_tlx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Part1 part1 = new Part1();
                part1.LoadId(textBox1.Text);
                this.Hide();
                part1.ShowDialog();
                this.Close();
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
