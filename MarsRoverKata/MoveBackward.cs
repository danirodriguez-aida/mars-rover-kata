namespace MarsRoverKata;

public class MoveBackward: MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveBackward(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public void Move()
    {
        marsRover.moveBackwardCommands[marsRover.direction].Move();

    }
}