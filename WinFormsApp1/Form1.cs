using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private float offset = 0;
        private Bitmap rainbowBitmap;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            rainbowBitmap = CreateRainbowBitmap(600, 1);

            //Initialize Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30;
            timer.Tick += (s, e) => { offset += 2; Invalidate(); };
            timer.Start();
        }

        private Bitmap CreateRainbowBitmap(int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Rectangle rect = new Rectangle(0, 0, width, height);
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect, Color.Black, Color.Black, LinearGradientMode.Horizontal))
                {
                    ColorBlend cb = new ColorBlend();
                    cb.Positions = new float[] { 0f, 0.16f, 0.33f, 0.5f, 0.66f, 0.83f, 1f };
                    cb.Colors = new Color[]
                    {
                        Color.Red,
                        Color.Orange,
                        Color.Yellow,
                        Color.Green,
                        Color.Blue,
                        Color.Indigo,
                        Color.Violet
                    };
                    brush.InterpolationColors = cb;
                    g.FillRectangle(brush, rect);
                }
            }
            return bmp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = this.ClientRectangle;

            if (rect.Width == 0 || rect.Height == 0) return;

            using (TextureBrush tBrush = new TextureBrush(rainbowBitmap, WrapMode.Tile))
            {
                tBrush.TranslateTransform(-offset, 0, MatrixOrder.Append);

                e.Graphics.FillRectangle(tBrush, rect);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double result))
            {
                double temp = result * 1.8 + 32;
                //label2.Text = string.Format($"{temp:F2} Graus Fahrenheit");
                label2.Text = "Hello, world!";
            }
            else
            {
                label2.Text = "0 Graus Fahrenheit";
            }
            
        }
    }
}
