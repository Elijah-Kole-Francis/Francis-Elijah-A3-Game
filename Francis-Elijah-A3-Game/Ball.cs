using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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


		public Ball()
		{
			//
			// TODO: Add constructor logic here
			//
			ballSize = new Vector2(30, 30);
			ballPosition = new Vector2(400, 50);
			ballSpeed = new Vector2 (100, 100);
            ballcolor = Random.Color();

		}

		private void moveBall()
		{
			ballPosition += ballSpeed * Time.DeltaTime;
		}

		private void Drawball()
		{
			Draw.LineColor = Color.Black;
			Draw.LineSize = 3;
			Draw.Circle(ballPosition, ballSize, 20);
            Draw.FillColor = ballcolor;


        }
	}
}