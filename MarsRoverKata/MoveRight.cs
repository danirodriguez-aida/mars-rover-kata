namespace MarsRoverKata;

public class MoveRight: MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveRight(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public void Move()
    {
        switch (marsRover.GetDirection())
        {
            case Direction.N:
                marsRover.SetDirection(Direction.E);
                break;
            case Direction.E:
                marsRover.SetDirection(Direction.S);
                break;
            case Direction.S:
                marsRover.SetDirection(Direction.W);
                break;
            case Direction.W:
                marsRover.SetDirection(Direction.N);
                break;
        }
    }
}