//4) ѕользователю даЄтс€ 20 секунд, чтобы совершить максимально возможное количество кликов по кнопке.
//ѕо истечении времени показать MessageBox, который сообщает набранное количество кликов, 
//и максимальный рекорд по итогам всех попыток.

using Timer = System.Windows.Forms.Timer;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private static Timer _timer = new Timer();
        private bool _bIsStart;
        private uint _uCount;
        private List<uint> _list = new List<uint>();
        public Form1()
        {
            InitializeComponent();

            _timer.Tick += new EventHandler(ShowTimer);
            _timer.Interval = 20000;
            _bIsStart = false;
            _uCount = 0;
        }
        private void ShowTimer(object sender, EventArgs e)
        {
            _timer.Stop();
            _bIsStart = false;
            button1.Text = "—тарт";

            _list.Add(_uCount);

            MessageBox.Show($" оличество кликов: {_uCount} maxCount: {Sort()}");
            _uCount = 0;
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_bIsStart)
            {
                _uCount++;
            }
            else
            {
                _timer.Start();
                _bIsStart = true;
                button1.Text = " ликай";
            }
        }

        private uint Sort() 
        {
            _list.Sort();
            return _list[_list.Count - 1];
        }

    }
}