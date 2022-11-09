namespace MarsRoverKata;

public class Position
{
    public int X { get; }
    public int Y { get; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Position NextRightPosition()
    {
        return new Position(X + 1, Y);
    }

    public Position NextUpPosition()
    {
        return new Position(X, Y + 1);
    }

    public Position NextLeftPosition()
    {
        return new Position(X - 1, Y);
    }

    public Position NextDownPosition()
    {
        return new Position(X, Y - 1);
    }
}