namespace Task_1
{
    public partial class Form1 : Form
    {
        Button? button;
        bool bIsKeyPressed;
        bool bIsCreateWnd;
        Point posMouseDown;
        int _count = 0;
        int _height;
        int _width;
        int _x;
        int _y;
        public Form1()
        {
            InitializeComponent();

            Text = "Создание кнопки";

            button = null;
            bIsKeyPressed = false;
            bIsCreateWnd = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _x = posMouseDown.X = e.X;
            _y = posMouseDown.Y = e.Y;

            bIsKeyPressed = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bIsKeyPressed)
            {
                _height = e.Y - posMouseDown.Y;
                _width = e.X - posMouseDown.X;

                if (_width < 0)
                {
                    _x = e.X;
                    _width *= -1;
                }
                if (_height < 0)
                {
                    _y = e.Y;
                    _height *= -1;
                }

                if (!bIsCreateWnd)
                {
                    button = new Button();

                    SuspendLayout();

                    button.Name = "button " + _count++;
                    button.Text = button.Name;
                    button.TabIndex = _count;
                    button.UseVisualStyleBackColor = true;
                    button.Location = new Point(_x, _y); ;
                    button.Size = new Size(_width, _height);
                    button.Visible = true;

                    Controls.Add(button);

                    bIsCreateWnd = true;

                    ResumeLayout(true);
                }
                else
                {
                    button.Location = new Point(_x, _y);
                    button.Size = new Size(_width, _height);
                }
               
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bIsKeyPressed = false;
            bIsCreateWnd = false;
        }
    }
}