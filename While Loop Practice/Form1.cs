namespace While_Loop_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start, end;

            if (int.TryParse(enterBox.Text, out start) && int.TryParse(endBox.Text, out end))
            {
                outputLabel.Text = "";

                while (start < end)
                {
                    outputLabel.Text += $"{start} ";
                    start++;
                }

                outputLabel.Visible = true;
            }
            else
            {
                outputLabel.Text = "Please enter whole numbers only!";
                outputLabel.Visible = true;
            }
        }

    }

}

