namespace MarsRoverKata;

public class MoveUpCommand: MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveUpCommand(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public Position Move()
    {
        return marsRover.position.NextUpPosition();
    }
}