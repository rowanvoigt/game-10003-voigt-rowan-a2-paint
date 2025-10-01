// Include the namespaces (code libraries) you need below.
using System;
using System.Data;
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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(600, 800);
            Window.SetTitle($"Painting!!!");
            Window.ClearBackground(Color.White);

            drawCanvas(0, 0);
            drawPalette(0, 0);
            Draw.FillColor = Color.Black;
            Draw.LineSize = 0;
            Draw.Rectangle(25, 150, 50, 50);
            Draw.Rectangle(35, 250, 25, 25);
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
            Draw.FillColor = Color.Red;
            Draw.Circle(70, 50, 40);
            Draw.FillColor = Color.Yellow;
            Draw.Circle(160, 50, 40);
            Draw.FillColor = Color.Green;
            Draw.Circle(250, 50, 40);
            Draw.FillColor = Color.Blue;
            Draw.Circle(340, 50, 40);
            Draw.FillColor = Color.Magenta;
            Draw.Circle(430, 50, 40);
            Draw.FillColor = Color.Cyan;
            Draw.Circle(520, 50, 40);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {


            float mouseX = Input.GetMousePosition().X;
            float mouseY = Input.GetMousePosition().Y;
            if (mouseX > 150 && mouseX < 450 && mouseY > 250 && mouseY < 650 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Draw.LineSize = 0.0f;
                Draw.FillColor = Color.Red;
                Draw.Circle(mouseX, mouseY, drawSize);
            }
            else
            {
            }
            if (mouseX > 25 && mouseX < 75 && mouseY > 150 && mouseY < 180 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.Write(drawSize);
                drawSize++;
            }
            else
            {
            }
            if (mouseX > 25 && mouseX < 75 && mouseY > 250 && mouseY < 280 && (Input.IsMouseButtonDown(MouseInput.Left)))
            {
                Console.Write(drawSize);
                drawSize--;
            }
            else
            {
            }

        }

    }
}



