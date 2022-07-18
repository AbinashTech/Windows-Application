namespace Testing_Applications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Success");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}