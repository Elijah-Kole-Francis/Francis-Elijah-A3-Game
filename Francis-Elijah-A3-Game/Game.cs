// Include code libraries you need here:
using System;
using System.Numerics;

// Where your code is placed.
namespace Francis_Elijah_A3_Game
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Vector2[] pegPosition =
        {
            //peg positions
            new (90,90), new (265, 100), new (420, 60), new (190, 290), new (350, 270), new (555, 175),
            new (670,270), new (430,330), new (70, 400), new (275, 425), new (540, 410), new (625, 450)

            
        };

        pegs[] pegs = new peg[12];

        public static int Score = 0;
        public static bool loseCondition = false;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Pachinko");
            Window.SetSize(800, 600);


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }
    }
}
