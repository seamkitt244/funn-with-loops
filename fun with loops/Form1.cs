using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace fun_with_loops
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int num1, num2, button, counter = 0;
        public Form1()
        {
            InitializeComponent();
            questionLabel1.Visible = false; questionLabel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false; button2.Visible = false; button3.Visible = false;
            questionLabel1.Visible = true; questionLabel2.Visible = true; outputLabel.Visible = true;
            inputLabel1.Visible = true; inputLabel2.Visible = true; outputLabel.Visible = true;
            button = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false; button2.Visible = false; button3.Visible = false;
            questionLabel1.Visible = false; questionLabel2.Visible = false; button4.Visible = false;
            inputLabel1.Visible = false; inputLabel2.Visible = false; outputLabel.Visible = false;
            button5.Visible = false;
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            int r = 0, g = 0, b = 0, x = 50, y = 150, starSize = 10, counter = 0;
            while (counter <= 1000)
            {
                drawBrush.Color = Color.FromArgb(r, g, b);
                formGraphics.FillRectangle(drawBrush, x, y, starSize, starSize);

                Thread.Sleep(10);
                x = randGen.Next(1, Width + 1);
                y = randGen.Next(1, Height + 1);
                r = randGen.Next(1, 256);
                g = randGen.Next(1, 256);
                b = randGen.Next(1, 256);
                starSize = randGen.Next(1, Width + 1);
                counter++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false; button2.Visible = false; button3.Visible = false;
            questionLabel1.Visible = false; questionLabel2.Visible = false; button4.Visible = true;
            inputLabel1.Visible = false; inputLabel2.Visible = false; outputLabel.Visible = true;
            button4.Text = "Generate"; button = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false; button2.Visible = false; button3.Visible = false;
            questionLabel1.Visible = false; questionLabel2.Visible = false; button4.Visible = false;
            inputLabel1.Visible = false; inputLabel2.Visible = false; outputLabel.Visible = false;
            button5.Visible = false;

            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int r = 0;
            int g = 0;
            int b = 255;
            int x = 50;
            int y = 150;
            int starSize = 10;

            while (y > 20)//r<256
            {
                drawBrush.Color = Color.FromArgb(r, g, b);

                formGraphics.Clear(Color.Black);
                formGraphics.FillRectangle(drawBrush, x, y, starSize, starSize);

                Thread.Sleep(10);
                x = x + 2;
                y = y - 2;
                b--;
                r++;
            }
            int pixelGrow = 1;
            starSize = 50;

            //test
            while (pixelGrow < 70)
            {
                if ()
                r = 255;
                g = 160;
                b = 0;
                drawBrush.Color = Color.FromArgb(r, g, b);
                //act
                formGraphics.Clear(Color.Black);
                formGraphics.FillEllipse(drawBrush, x - pixelGrow / 2, y - pixelGrow / 2, starSize + pixelGrow, starSize + pixelGrow);

                Thread.Sleep(5);
                //CHANGE
                pixelGrow = pixelGrow + 2;
                if (pixelGrow < 50)
                {
                    formGraphics.FillEllipse(drawBrush, x - pixelGrow / 2, y - pixelGrow / 2, starSize + pixelGrow, starSize + pixelGrow);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button == 1)
            {
                num1 = Convert.ToInt16(inputLabel1.Text);
                num2 = Convert.ToInt16(inputLabel2.Text);
                while (num1 <= num2)//r<256
                {
                    outputLabel.Text += num1 + " ";
                    num1++;
                }
            }
            else if (button == 2)
            {
                int bad = 0, bad2 = 0, bad3 = 0, bad4 = 0, bad5 = 0, bad6 = 0, bad7 = 0; outputLabel.Visible = true;
                num1 = randGen.Next(1, 8);
                while (counter <= 7)//r<256
                {
                    if (bad == num1)
                    {num1 = randGen.Next(1, 8);bad2 = bad;}

                    else if (bad2 == num1 )
                    {num1 = randGen.Next(1, 8);bad3 = num2;}

                    else if (bad3 == num1)
                    { num1 = randGen.Next(1, 8); bad4 = bad3; }

                    else if (bad4 == num1)
                    { num1 = randGen.Next(1, 8); bad5 = bad4; }

                    else if (bad5 == num1)
                    { num1 = randGen.Next(1, 8); bad6 = bad5; }

                    else if (bad6 == num1)
                    { num1 = randGen.Next(1, 8); bad7 = bad6; }

                    outputLabel.Text += num1 + " ";
                    bad = num1;
                    num1 = randGen.Next(1, 8);
                    counter++;

                }

            }
        }
    }
}
