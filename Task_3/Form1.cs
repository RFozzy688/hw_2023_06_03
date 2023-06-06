//3) ���������� ����������, ������� ������� � �������� �������� �� ��/��/��������� 
//    �������� WinForms (19.08.2023 12:00)

namespace Task_3
{
    public partial class Form1 : Form
    {
        private DateTime dateTime;
        private TimeSpan timeSpan;
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void ShowTime(object sender, EventArgs e)
        {
            timeSpan = dateTime - DateTime.Now;
            labelTime.Text = "�� ��������� �������� WinForms ��������: " + Convert.ToInt32(timeSpan.TotalSeconds) + " ������";
        }
        public Form1()
        {
            InitializeComponent();

            dateTime = new DateTime(2023, 8, 19, 12, 0, 0);

            labelTime.Text = "�� ��������� �������� WinForms ��������: ";
            timer.Tick += new EventHandler(ShowTime);
            timer.Interval = 1000;
            timer.Start();
        }

    }
}