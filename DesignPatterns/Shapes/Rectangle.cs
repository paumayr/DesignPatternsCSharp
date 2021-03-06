﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes
{
	public abstract class Rectangle : Shape
	{
		public Rectangle(double x, double y, double width, double height)
		{
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
		}

		public Rectangle(Rectangle other)
		{
			this.X = other.X;
			this.Y = other.Y;
			this.Width = other.Width;
			this.Height = other.Height;
		}

		public double X { get; set; }

		public double Y { get; set; }

		public double Width { get; set; }

		public double Height { get; set; }

		public override double CalcArea()
		{
			return this.Width * this.Height;
		}

		public override void Accept(ShapeVisitor visitor)
		{
			visitor.VisitRectangle(this);
		}
	}
}
