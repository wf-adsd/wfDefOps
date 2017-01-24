﻿using System;
namespace cSharpe
{
	public class Point
	{
		public readonly int X;
		public readonly int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int DistanceTo(int x, int y)
		{
			int xDiff = X - x;
			int yDiff = Y - y;

			int xDiffSquare = xDiff * xDiff;
			int yDiffSquare = yDiff * yDiff;

			return (int)Math.Sqrt(xDiffSquare * yDiffSquare);
      	}
	}
}
