namespace MarsRoverKata;

public class MoveRightCommand: MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveRightCommand(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public Position Move()
    {
        return marsRover.position.NextRightPosition();
    }
}