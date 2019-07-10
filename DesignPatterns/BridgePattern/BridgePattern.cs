using System;

namespace DesignPatterns.BridgePattern
{
    /// <summary>
    /// Interface of Draw a circle
    /// </summary>
    public interface IDrawShape
    {
        void DrawShape(float radius);
    }

    /// <summary>
    /// Class for drawing shape with pen
    /// </summary>
    /// <seealso cref="DesignPatterns.BridgePattern.IDrawShape" />
    public class Pen : IDrawShape
    {
        /// <summary>
        /// Draws the shape using pen.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public void DrawShape(float radius)
        {
            Console.WriteLine($"Drawing circle with pen of radius {radius}");
        }
    }

    /// <summary>
    /// Class for drawing shape with pencil
    /// </summary>
    /// <seealso cref="DesignPatterns.BridgePattern.IDrawShape" />
    public class Pencil : IDrawShape
    {
        /// <summary>
        /// Draws the shape using pencil.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public void DrawShape(float radius)
        {
            Console.WriteLine($"Drawing circle with pencil of radius {radius}");
        }
    }

    /// <summary>
    /// Abstract class for shape
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// The renderer
        /// </summary>
        protected IDrawShape drawShape;

        // a bridge between the shape that's being drawn an
        // the component which actually draws it
        public Shape(IDrawShape drawShape)
        {
            this.drawShape = drawShape;
        }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        public abstract void Draw();
    }

    /// <summary>
    /// Class for circle as shape
    /// </summary>
    /// <seealso cref="DesignPatterns.BridgePattern.Shape" />
    public class Circle : Shape
    {
        /// <summary>
        /// The radius
        /// </summary>
        private float radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="drawShape">The draw shape.</param>
        /// <param name="radius">The radius.</param>
        public Circle(IDrawShape drawShape, float radius) : base(drawShape)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        public override void Draw()
        {
            drawShape.DrawShape(radius);
        }
    }
}
