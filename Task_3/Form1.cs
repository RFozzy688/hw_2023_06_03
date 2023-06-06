//3) Приложение показывает, сколько времени в секундах осталось до НГ/ДР/окончания 
//    предмета WinForms (19.08.2023 12:00)

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
            labelTime.Text = "До начала экземена по WinForms осталось: " + Convert.ToInt32(timeSpan.TotalSeconds) + " секунд";

            if (Convert.ToInt32(timeSpan.TotalSeconds) == 0)
            {
                timer.Stop();
                MessageBox.Show("Экзамен!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public Form1()
        {
            InitializeComponent();

            dateTime = new DateTime(2023, 6, 6, 15, 18, 0);
            timeSpan = dateTime - DateTime.Now;

            labelTime.Text = "До начала экземена по WinForms осталось: ";
            timer.Tick += new EventHandler(ShowTime);
            timer.Interval = 1000;
            timer.Start();
        }

    }
}