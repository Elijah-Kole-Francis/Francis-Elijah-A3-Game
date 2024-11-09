using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

//making sure I have all the same system stuff like in the lecture, just in case
namespace Game10003
{


	/// <summary>
	///		The pegs will be a series of circles that are stationary but give points for each collision
	/// Summary description for Class1
	/// </summary>
	public class Pegs
	{
		public Vector2 pegsPosition;
		public Vector2 pegsSize;
		public bool pegHighlight = false;

		private Color pegsColor = Color.Green;
		private Color highlightPegsColor = Random.Color();

		public Pegs()
		{
			//
			// TODO: Add constructor logic here
			//
		}


		//putting the pegs on the screen
		private void drawPeg()
		{
			Draw.LineColor = Color.Black;
			Draw.FillColor = pegsColor;
			Draw.LineSize = 1;

			if (pegHighlight)
			{
				Draw.FillColor = highlightPegsColor;
			}

			else
			{
				Draw.FillColor = pegsColor;
			}

			Draw.Circle(pegsPosition, pegsSize, 50);

		}
	}
}