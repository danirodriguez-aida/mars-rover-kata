namespace MarsRoverKata.Commands;

public class MoveForwardCommand : MoveCommand
{
    private readonly MarsRover marsRover;
    private readonly Dictionary<Direction, MoveCommand> moveForwardCommands;

    public MoveForwardCommand(MarsRover marsRover)
    {
        this.marsRover = marsRover;
        var moveRightCommand = new MoveRightCommand(marsRover);
        var moveUpCommand = new MoveUpCommand(marsRover);
        var moveLeftCommand = new MoveLeftCommand(marsRover);
        var moveDownCommand = new MoveDownCommand(marsRover);
        moveForwardCommands = new Dictionary<Direction, MoveCommand>
        {
            {Direction.N, moveUpCommand},
            {Direction.S, moveDownCommand},
            {Direction.E, moveRightCommand},
            {Direction.W, moveLeftCommand}
        };
    }

    public void Move()
    {
        moveForwardCommands[marsRover.GetDirection()].Move();
    }
}