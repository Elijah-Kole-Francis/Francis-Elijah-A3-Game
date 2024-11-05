using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Francis_Elijah_A3_Game
{


	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class Ball
	{
		private Vector2 position;
		private Vector2 size;
		private Vector2 speed;
		private Vector2 ballcolor;


		public Ball()
		{
			//
			// TODO: Add constructor logic here
			//

			ballSize = new Vector2(30, 30);
			ballPosition = new Vector2(400, 50);
			ballSpeed = new Vector2(100, 100);
			ballColor = Random.Color();
	



	}

		private void moveBall()
		{
			ballPosition += speed * Time.Deltatime;
		}

		private void Drawball()
		{
			Draw.LineColor = Color.Black;
			Draw.LineSize = 3;
			Draw.Circle(ballposition, ballsize, 20);
            Draw.FillColor = ballcolor;


        }
	}
}