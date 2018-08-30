public class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Right => Left + Width;
    public int Bottom => Top + Height;

    public bool IsInside(Rectangle other)
    {
        var isInLeft = Left >= other.Left;
        var isInRight = Right <= other.Right;
        var isInsideHorizontal = isInLeft && isInRight;
        var isInTop = Top >= other.Top;
        var isInBottom = Bottom <= other.Bottom;
        var isInsideVertical = isInTop && isInBottom;
        return isInsideHorizontal && isInsideVertical;
    }
}
