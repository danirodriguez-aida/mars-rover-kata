namespace MarsRoverKata.Commands;

public class MoveRightCommand : MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveRightCommand(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public void Move()
    {
        marsRover.SetNextRightPosition();
    }
}