using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace Game10003
{


	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class Ball
	{
		private Vector2 ballPosition;
		private Vector2 ballSize;
		private Vector2 ballSpeed;
		private Color ballcolor;
		private Vector2 ballgravity;
		private bool IsMouseButtonPressed;

		public Ball()
		{
			//
			// TODO: Add constructor logic here
			//
			ballSize = new Vector2(30, 30);
			ballPosition = new Vector2(400, 50);
			ballSpeed = new Vector2(100, 100);
			ballcolor = Random.Color();
			ballgravity = new(0, 10);

		}

		//
		private bool IsCircleOverlap(Pegs peg)
		{
			Vector2 pegPlusBall = peg.pegsPosition + ballPosition;
			bool doCirclesOverlap = Vector2.Distance(peg.pegsPosition, ballPosition) <= 80;

			return doCirclesOverlap;
		}

		//collision checks
		private void CollisionPegCircles(Pegs peg)
		{
			// this will give me a visual indicator of when they're colliding
			if (Vector2.Distance(ballPosition, peg.pegsPosition) < 30)
			{
				peg.pegHighlight = true;
				Game.Score++;
			}

			else peg.pegHighlight = false;

			if (IsCircleOverlap(peg))
			{
				// since its only circles I shouldn't need too much to detect if they're overlapping
				float ballX = ballPosition.X;
				float ballY = ballPosition.Y;

				float pegX = peg.pegsPosition.X;
				float pegY = peg.pegsPosition.Y;

				//collision distance
				float colDistance = 10.0f;


				//this should allow for proper collision detection when they get close to each other(?)
				bool colX = MathF.Abs(ballX - pegX) <= colDistance;
				bool colY = MathF.Abs(ballY - pegY) <= colDistance;

				//remember to specify the .X and .Y or else I'll be stuck for a while
				if (colX && ballSpeed.X > 0)
				{
					ballSpeed *= -1;
				}

				if (colY && ballSpeed.Y > 0)
				{
					ballSpeed *= -1;
				}

			}
		}

		private void Collisioncheck(Pegs[] pegs)
		{
			foreach (Pegs p in pegs)
			{
				CollisionPegCircles(p);
			}
			WindowCol();
		}

		//lovely little pachinko ball
		private void Drawball()
		{
			Draw.LineColor = Color.Black;
			Draw.LineSize = 3;
			Draw.Circle(ballPosition, ballSize, 30);
			Draw.FillColor = ballcolor;
		}

		// how the ball will move
		private void moveBall()
		{
			ballPosition += ballSpeed * Time.DeltaTime;
			ballSpeed += ballgravity;

		}
		//ball needs to stay in the window
		private void WindowCol()
		{
			if (ballPosition.X <= 0 && ballSpeed.X < 0)
			{
				ballPosition.X = 0;
				ballSpeed.X *= -1.2f;
			}

			if (ballPosition.X + ballSize.X >= Window.Size.X && ballSpeed.X > 0)
			{
				ballPosition.X = Window.Size.X - ballSize.X;
				ballSpeed.X *= -1.2f;
			}

			if (ballPosition.Y <= 0 && ballSpeed.Y < 0)
			{
				ballPosition.Y = 0;
				ballSpeed.Y *= -1.2f;
			}

			if (ballPosition.Y + ballSize.Y >= Window.Size.Y && ballSpeed.Y > 0)
			{
				ballPosition.Y = Window.Size.Y - ballSize.Y;
				ballSpeed.Y *= -1.2f;
			}

		}

		//this is going to be the control for clicking below x = 400,
		//inverting the speed of the ball to send it back up into pegs
		private void MouseRebound()
		{
            if (IsMouseButtonPressed && ballPosition.Y > 400)
            {
                ballSpeed *= -1;
				ballSpeed.X += 10;
				ballSpeed.Y -= 10;
                Game.Score++;
            }

        }

			 
		
	} 
}