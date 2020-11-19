using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaborotorkaKaarma
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent(); 
        
        }
        
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 50, 50);
        Rectangle Circle2 = new Rectangle(290, 10, 50, 50);
        Rectangle Circle3 = new Rectangle(360, 10, 50, 50);
        Rectangle Square = new Rectangle(450, 10, 150, 150);
        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Blue, Circle);
            e.Graphics.FillEllipse(Brushes.Blue, Circle2);
            e.Graphics.FillEllipse(Brushes.Blue, Circle3);
            e.Graphics.FillRectangle(Brushes.Yellow, Square);
            e.Graphics.FillRectangle(Brushes.Red, Rectangle);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width ) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    Rectangle.Clicked = true;

                    Rectangle.X = e.X - Rectangle.X;
                    Rectangle.Y = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    Circle.Clicked = true;

                    Circle.X = e.X - Circle.X;
                    Circle.Y = e.Y - Circle.Y;
                }
            }
            if ((e.X < Circle2.X + Circle2.Width) && (e.X > Circle2.X))
            {
                if ((e.Y < Circle2.Y + Circle2.Height) && (e.Y > Circle2.Y))
                {
                    Circle2.Clicked = true;

                    Circle2.X = e.X - Circle2.X;
                    Circle2.Y = e.Y - Circle2.Y;
                }
            }
            if ((e.X < Circle3.X + Circle3.Width) && (e.X > Circle3.X))
            {
                if ((e.Y < Circle3.Y + Circle3.Height) && (e.Y > Circle3.Y))
                {
                    Circle3.Clicked = true;

                    Circle3.X = e.X - Circle3.X;
                    Circle3.Y = e.Y - Circle3.Y;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    Square.Clicked = true;

                    Square.X = e.X - Square.X;
                    Square.Y = e.Y - Square.Y;
                }
            }
        }
    }


}
