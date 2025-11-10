using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class Square: Rectangle
	{
		public Square(double side, int startX, int startY, int lineWidth, Color color) :
			base(startX, startY, lineWidth, color);
		
		

	}
}
