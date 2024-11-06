using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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

		private Color pegsColor;
		private Color highlightPegsColor = Random.Color();

		public Pegs()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}