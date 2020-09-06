using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes) // an element can be a Shape object, or an object who derives from the type of Shape
            {
                shape.Draw(); //at runtime the draw of the circle or the rectangle will be called, not the shape base itself.
            }
        }
    }
}
