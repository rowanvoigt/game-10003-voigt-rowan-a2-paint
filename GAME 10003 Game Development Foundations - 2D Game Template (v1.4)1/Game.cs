// Include the namespaces (code libraries) you need below.
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        float drawSize = 5.0f;
        int r = 0;
        int g = 0;
        int b = 0;
        Color drawColor;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

            drawColor = new Color(r, g, b, 255);
            Window.SetSize(600, 800);
            Window.SetTitle($"Painting!!!");
            Window.ClearBackground(Color.White);
            Window.TargetFPS = 144;
            drawCanvas(0, 0);
            drawPalette(0, 0);
            Draw.FillColor = Color.Cyan;
            Draw.LineSize = 0;
            /// draw the + button
            Draw.Rectangle(25, 150, 50, 15);
            Draw.Rectangle(42.5f, 132f, 15, 50);
            /// draw the - button
            Draw.FillColor = Color.Red;
            Draw.Rectangle(25, 250, 50, 15);
        }
        void drawCanvas(int x, int y)
        {
            Draw.LineSize = 8.0f;
            Draw.LineColor = Color.Black;
            Draw.Line(425.0f, 650.0f, 450.0f, 1000.0f);
            Draw.Line(175.0f, 650.0f, 150.0f, 1000.0f);
            Draw.Line(300.0f, 300.0f, 300.0f, 1000.0f);
            Draw.LineSize = 2.0f;
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(140.0f, 240.0f, 320.0f, 420.0f);
            Draw.FillColor = Color.White;
            Draw.Rectangle(150.0f, 250.0f, 300.0f, 400.0f);
        }
        void drawPalette(int x, int y)
        {
            Draw.LineColor = Color.White;
            Draw.FillColor = Color.Black;
            Draw.Circle(520, 140, 40);
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Red;
            Draw.Circle(70, 50, 40);
            Draw.FillColor = Color.Yellow;
            Draw.Circle(160, 50, 40);
            Draw.FillColor = Color.Green;
            Draw.Circle(250, 50, 40);
            Draw.FillColor = Color.Cyan;
            Draw.Circle(340, 50, 40);
            Draw.FillColor = Color.Magenta;
            Draw.Circle(430, 50, 40);
            Draw.FillColor = Color.White;
            Draw.Circle(520, 50, 40);
            Draw.FillColor = drawColor;
            Draw.Circle(520, 210, 20);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Draw.FillColor = drawColor;
            Draw.Circle(520, 210, 20);
            /// checks if the draw size is too big or small. if it is too big or small, set the size to the largest or smallest size allowed.
            if (drawSize < 1f)
            {
                drawSize = 1f;
            }
            else if (drawSize > 25)
            {
                drawSize = 25;
            }
            ///constantly get the mouse position
            float mouseX = Input.GetMousePosition().X;
            float mouseY = Input.GetMousePosition().Y;
            ///allow drawing ONLY if on the canvas coordinates.
            if (mouseX > 150 && mouseX < 450 && mouseY > 250 && mouseY < 650 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Draw.LineSize = 0.0f;
                Draw.FillColor = drawColor;
                Draw.Circle(mouseX, mouseY, drawSize);
            }
            ///allow size increasing if you click the +
            if (mouseX > 25 && mouseX < 75 && mouseY > 125 && mouseY < 180 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine(drawSize);
                drawSize++;
                Thread.Sleep(100);
            }
            ///allow size decreasing if you click the -
            if (mouseX > 25 && mouseX < 75 && mouseY > 250 && mouseY < 265 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine(drawSize);
                drawSize--;
                Thread.Sleep(100);
            }
            ///change colour of what you are drawing when you click on the circles.
            if (mouseX > 30 && mouseX < 110 && mouseY > 10 && mouseY < 90 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine("Red");
                drawColor = Color.Red;
                Thread.Sleep(100);
            }
            if (mouseX > 120 && mouseX < 200 && mouseY > 10 && mouseY < 90 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine("Yellow");
                drawColor = Color.Yellow;
                Thread.Sleep(100);
            }
            if (mouseX > 210 && mouseX < 290 && mouseY > 10 && mouseY < 90 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine("Green");
                drawColor = Color.Green;
                Thread.Sleep(100);
            }
            if (mouseX > 300 && mouseX < 380 && mouseY > 10 && mouseY < 90 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine("Cyan");
                drawColor = Color.Cyan;
                Thread.Sleep(100);
            }
            if (mouseX > 390 && mouseX < 470 && mouseY > 10 && mouseY < 90 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine("Pink");
                drawColor = Color.Magenta;
                Thread.Sleep(100);
            }
            if (mouseX > 480 && mouseX < 560 && mouseY > 10 && mouseY < 90 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine("White");
                drawColor = Color.White;
                Thread.Sleep(100);
            }
            if (mouseX > 480 && mouseX < 560 && mouseY > 100 && mouseY < 180 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.WriteLine("Black");
                drawColor = Color.Black;
                Thread.Sleep(100);
            }
        }

    }
}