using System;
using System.Drawing;

namespace FractalTrees
{
    /// <summary>
    /// This class manages the creations of each fractal pattern
    /// </summary>
    public class FractalManager
    {
        // Constants

        // Sierpinski Sieve 
        private const int SIERPINSKI_HALF = 2;

        // Koch Snowflake
        private const double KOCH_HALF = 0.5;
        private const int KOCH_THIRD = 3;
        private const int KOCH_INCREMENT = 2;
        private const double KOCH_LINE = 6.25;

        // Dragon Curve
        private const int DRAGON_HALF = 2;

        // Flower of Life

        // Fields 
        private Graphics graphics;
        private Brush brush;
        private Pen pen;
        private Random random;

        /// <summary>
        /// Fractal Manager Ctor
        /// </summary>
        public FractalManager(Graphics graphics, Random random)
        {
            this.graphics = graphics;
            this.random = random;
        }

        /// <summary>
        /// Sierpinski Sieve 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void SierpinskiSieve(int depth, Point x, Point y, Point z)
        {
            brush = new SolidBrush(Color.Black);

            if (depth == 0)
            {
                Point[] trianglePoints = { x, y, z };
                graphics.FillPolygon(brush, trianglePoints);
            }
            else
            {
                // Calculating three points of the fractal triangle
                Point leftSide = new Point((x.X + z.X) / SIERPINSKI_HALF, (x.Y + z.Y) / SIERPINSKI_HALF);
                Point rightSide = new Point((x.X + y.X) / SIERPINSKI_HALF, (x.Y + y.Y) / SIERPINSKI_HALF);
                Point bottomSide = new Point((z.X + y.X) / SIERPINSKI_HALF, (z.Y + y.Y) / SIERPINSKI_HALF);

                // Using recursion for the next set of fractal triangles
                SierpinskiSieve(depth - 1, x, rightSide, leftSide);
                SierpinskiSieve(depth - 1, rightSide, y, bottomSide);
                SierpinskiSieve(depth - 1, leftSide, bottomSide, z);
            }
        }

        /// <summary>
        /// Koch SnowFlake Points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Point KochSnowFlakePoints(Point start, Point end)
        {
            int x = (int)(KOCH_HALF * (start.X + end.X) + Math.Sqrt(KOCH_THIRD) * (start.Y - end.Y) / KOCH_LINE); 
            int y = (int)(KOCH_HALF * (start.Y + end.Y) + Math.Sqrt(KOCH_THIRD) * (end.X - start.X) / KOCH_LINE);
            return new Point(x, y);
        }

        /// <summary>
        /// Koch Snowflake
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void KochSnowflake(int depth, Point start, Point end)
        {
            pen = new Pen(Color.Black);
            Point lineLength;
            Point firstThird;
            Point trianglePoint;
            Point lastThird;
            
            if (depth == 0)
            {
                graphics.DrawLine(pen, start, end);
            }
            else
            {
                // The length of the previous line
                lineLength = new Point(end.X - start.X, end.Y - start.Y);
                // The end of the first point
                firstThird = new Point(start.X + lineLength.X / KOCH_THIRD, start.Y + lineLength.Y / KOCH_THIRD);
                // The new triangle's point
                trianglePoint = KochSnowFlakePoints(start, end);
                // The start of the third point
                lastThird = new Point(start.X + KOCH_INCREMENT * lineLength.X / KOCH_THIRD, start.Y + KOCH_INCREMENT * lineLength.Y / KOCH_THIRD);
                // Using recursion for each new line
                KochSnowflake(depth - 1, start, firstThird);
                KochSnowflake(depth - 1, firstThird, trianglePoint);
                KochSnowflake(depth - 1, trianglePoint, lastThird);
                KochSnowflake(depth - 1, lastThird, end);
            }
        }

        /// <summary>
        /// Dragon Curve
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="start"></param>
        /// <param name="dir"></param>
        /// <param name="currDir"></param>
        public void DragonCurve(int depth, Point start, Point dir, eDirection currDir)
        {
            pen = new Pen(Color.Black);

            if (depth == 0)
            {
                // Drawing a starting line for the dragon fractal
                graphics.DrawLine(pen, start.X, start.Y, start.X + dir.X, start.Y + dir.Y);
            }
            else
            {
                // Calculating where the x and y lines meet at a right angle
                double x = dir.X / DRAGON_HALF;
                double y = dir.Y / DRAGON_HALF;
                double newDirX = -y + x;
                double newDirY = x + y;

                if (currDir == eDirection.RIGHT)
                {
                    DragonCurve(depth - 1, start, new Point((int)newDirX, (int)newDirY), eDirection.RIGHT);
                    // Creating a new point
                    double newStartX = start.X + newDirX;
                    double newStartY = start.Y + newDirY;
                    Point newStart = new Point((int)newStartX, (int)newStartY);
                    DragonCurve(depth - 1, newStart, new Point((int)newDirY, (int)-newDirX), eDirection.LEFT);
                }

                if (currDir == eDirection.LEFT)
                {
                    DragonCurve(depth - 1, start, new Point((int)newDirY, (int)-newDirX), eDirection.RIGHT);
                    double newStartX = start.X + newDirY;
                    double newStartY = start.Y - newDirX;
                    Point newStart = new Point((int)newStartX, (int)newStartY);
                    DragonCurve(depth - 1, newStart, new Point((int)newDirX, (int)newDirY), eDirection.LEFT);
                }
            }
        }

        /// <summary>
        /// The Flower of Life
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="start"></param>
        /// <param name="dimen"></param>
        public void TheFlowerOfLife(int depth, Point start, int dimen)
        {
            brush = new SolidBrush(Color.Black);
            pen = new Pen(Color.Red, 1F);
            graphics.FillEllipse(brush, start.X, start.Y, dimen, dimen);
            graphics.DrawEllipse(pen, start.X, start.Y, dimen, dimen);
            brush = new SolidBrush(Color.Red);

            if (depth == 0)
            {
                graphics.FillEllipse(brush, start.X, start.Y, dimen, dimen);
            }
            else
            {
                double largeFlowers = dimen / 3; // Large flowers
                double smallFlowers = largeFlowers / 2; // Small flowers
                // Starting points for each flower
                Point center = new Point((int)(start.X + largeFlowers), (int)(start.Y + largeFlowers));
                Point top = new Point((int)(start.X + largeFlowers), start.Y);
                Point bottom = new Point((int)(start.X + largeFlowers), (int)(start.Y + largeFlowers * 2));
                Point left = new Point(start.X, (int)(start.Y + largeFlowers));
                Point right = new Point((int)(start.X + largeFlowers * 2), (int)(start.Y + largeFlowers));
                Point topLeft = new Point((int)(start.X + smallFlowers), (int)(start.Y + smallFlowers));
                Point topRight = new Point((int)(start.X + smallFlowers * 4), (int)(start.Y + smallFlowers));
                Point bottomLeft = new Point((int)(start.X + smallFlowers), (int)(start.Y + smallFlowers * 4));
                Point bottomRight = new Point((int)(start.X + smallFlowers * 4), (int)(start.Y + smallFlowers * 4));
                TheFlowerOfLife(depth - 1, center, (int)largeFlowers);
                TheFlowerOfLife(depth - 1, top, (int)largeFlowers);
                TheFlowerOfLife(depth - 1, bottom, (int)largeFlowers);
                TheFlowerOfLife(depth - 1, left, (int)largeFlowers);
                TheFlowerOfLife(depth - 1, right, (int)largeFlowers);
                TheFlowerOfLife(depth - 1, topLeft, (int)smallFlowers);
                TheFlowerOfLife(depth - 1, topRight, (int)smallFlowers);
                TheFlowerOfLife(depth - 1, bottomRight, (int)smallFlowers);
                TheFlowerOfLife(depth - 1, bottomLeft, (int)smallFlowers);
            }
        }
    }
}
