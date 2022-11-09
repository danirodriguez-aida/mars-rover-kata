namespace MarsRoverKata;

public class MoveDownCommand: MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveDownCommand(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public Position Move()
    {
        return marsRover.position.NextDownPosition();
    }
}