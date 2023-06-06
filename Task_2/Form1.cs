namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RelocationButton()
        {
            Random random = new Random();

            int x = random.Next(0, ClientSize.Width - button1.Width);
            int y = random.Next(0, ClientSize.Height - button1.Height);

            button1.Location = new Point(x, y);
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            RelocationButton();
        }
    }
}