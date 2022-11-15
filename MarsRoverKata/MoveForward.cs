namespace MarsRoverKata;

public class MoveForward: MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveForward(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public void Move()
    {
        marsRover.moveForwardCommands[marsRover.direction].Move();
    }
}