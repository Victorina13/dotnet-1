﻿using System;

namespace Laba1.Model
{
    public class RectangularParallelepiped : Figure3D
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public RectangularParallelepiped(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;

        }
        public double GetWidth()
        {
            return Math.Abs(Point1.X - Point2.X);
        }
        public double GetLength()
        {
            return Math.Abs(Point1.Y - Point2.Y);
        }
        public double GetHeight()
        {
            return Math.Abs(Point1.Z - Point2.Z);
        }
        public override double GetArea()
        {
            return 2 * (GetLength() * GetWidth() + GetLength() * GetHeight() + GetWidth() * GetHeight());
        }

        public override double GetVolume()
        {
            return GetLength() * GetWidth() * GetHeight();

        }

        public override RectangularParallelepiped GetMinParallelepiped()
        {
            return new RectangularParallelepiped
                (new (Point1.X, Point1.Y, Point1.Z), new (Point2.X, Point2.Y, Point2.Z));
        }
    }
}
