//Цвет фона приложения плавно меняется от чёрного к красному, от красного к жёлтому,
//к зелёному, к голубому, к синему, к розовому, белому, чёрному и тд.

using System.Drawing;
using Timer = System.Windows.Forms.Timer;

namespace Task_5
{
    public partial class Form1 : Form
    {
        private Timer _timer = new Timer();
        private int _red;
        private int _green;
        private int _blue;
        private bool _flag;
        public Form1()
        {
            InitializeComponent();

            _timer.Tick += new EventHandler(ShowTimer);
            _timer.Interval = 10;
            _timer.Start();

            _red = _green = _blue = 0;
            _flag = true;
        }
        private void ShowTimer(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(_red, _green, _blue);

            if (_flag)
            {
                if (_red < 255)
                {
                    _red++;
                }
                else if (_green < 255)
                {
                    _green++;
                }
                else if (_blue < 255)
                {
                    _blue++;
                }
                else
                {
                    _flag = false;
                }
            }
            else
            {
                if (_red > 0)
                {
                    _red--;
                }
                else if (_green > 0)
                {
                    _green--;
                }
                else if (_blue > 0)
                {
                    _blue--;
                }
                else
                {
                    _flag = true;
                }
            }
        }
    }
}