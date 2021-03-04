﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace HomeWork.Lesson1.Task1
{
    internal class Asteroid
    {
        protected Point Position;
        protected Point Direction;
        protected Size Size;

        public Asteroid(Point position, Point direction, Size size)
        {
            Position = position;
            Direction = direction;
            Size = size;
        }

        public virtual void Draw()
        {
            using (Image image = new Bitmap(@"img/asteroid_1.png"))
            {
                GameCore.Buffer.Graphics.DrawImage(image, Position.X, Position.Y);
            }
        }

        public virtual void Update()
        {
            Position.X = Position.X + Direction.X;
            Position.Y = Position.Y + Direction.Y;

            if (Position.X < 0) Direction.X = -Direction.X;
            if (Position.X > GameCore.Width-70) Direction.X = -Direction.X;
            if (Position.Y < 0) Direction.Y = -Direction.Y;
            if (Position.Y > GameCore.Height-70) Direction.Y = -Direction.Y;
        }
    }
}
