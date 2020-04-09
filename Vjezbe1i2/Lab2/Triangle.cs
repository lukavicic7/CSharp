using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Labs{
    public class Triangle : Shape{

		private double side;

		public Triangle (double s){
			side = s;
			xPos = DataModel.getNewXPos();
			yPos = DataModel.getNewYPos();
		}
		public override double getArea(){ // površina    a^2 * korijen od 3 /4
			return side * side * Math.Sqrt(3)/4 ;
	
		}

		public override double getPerimeter(){ //opseg
			return 3 * side;
		}

		public override void printData()
		{
			Console.WriteLine();
			Console.WriteLine("My type: " + this.GetType());
			Console.WriteLine("Side of triangle = " + side);
			Console.WriteLine("X position = " + xPos);
			Console.WriteLine("Y position = " + yPos);
		}

	}
}
