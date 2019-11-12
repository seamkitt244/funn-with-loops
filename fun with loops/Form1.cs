using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace fun_with_loops
{
    public partial class Form1 : Form
    {
        const int MAX = 50;
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
            r = 255;
            g = 160;
            b = 0;
            while (pixelGrow <= 70)
            {
                drawBrush.Color = Color.FromArgb(r, g, b);
                //act
                formGraphics.Clear(Color.Black);
                formGraphics.FillEllipse(drawBrush, x - pixelGrow / 2, y - pixelGrow / 2, starSize + pixelGrow, starSize + pixelGrow);
                Thread.Sleep(5);
                //CHANGE
                pixelGrow = pixelGrow + 2;
            }
            while (pixelGrow <= 100)
            {
                formGraphics.FillEllipse(drawBrush, x - pixelGrow / 2, y - pixelGrow / 2, starSize + pixelGrow, starSize + pixelGrow);
                Thread.Sleep(5);
                r = r - 10;
                g = g - 10;
                pixelGrow = pixelGrow + 1;
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
                outputLabel.Text = "  ";
                button5.Visible = false;
                int num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0; outputLabel.Visible = true;
                num1 = randGen.Next(1, MAX);
                num2 = randGen.Next(1, MAX);
                num3 = randGen.Next(1, MAX);
                num4 = randGen.Next(1, MAX);
                num5 = randGen.Next(1, MAX);
                num6 = randGen.Next(1, MAX);
                num7 = randGen.Next(1, MAX);

                while (num2 == num1)//r<256
                { num2 = randGen.Next(1, 8); }

                while (num3 == num2 || num3 == num1)
                { num3 = randGen.Next(1, MAX); }

                while (num4 == num3 || num4 == num2 || num4 == num1)
                { num4 = randGen.Next(1, MAX); }

                while (num5 == num4 || num5 == num3 || num5 == num2 || num5 == num1)
                { num5 = randGen.Next(1, MAX); }

                while (num6 == num5 || num6 == num4 || num6 == num3 || num6 == num2 || num6 == num1)
                { num6 = randGen.Next(1, MAX); }

                while (num7 == num6 || num7 == num5 || num7 == num4 || num7 == num3 || num7 == num2 || num7 == num1)
                { num7 = randGen.Next(1, MAX); }

                outputLabel.Text += num1 + " " + num2 + " " + num3 + " " + num4 + " " + num5 + " " + num6 + " " + num7;
            }

        }
    }
}

