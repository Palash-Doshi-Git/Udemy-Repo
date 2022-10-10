namespace MethodOveriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
          foreach(Shape shape in shapes)
            {
                switch(shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle");
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a Rectangle");
                        break;
                 }
            }
        }
    }
     
}
