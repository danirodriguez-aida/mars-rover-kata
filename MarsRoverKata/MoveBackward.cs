namespace MarsRoverKata;

public class MoveBackward : MoveCommand {
    private readonly MarsRover marsRover;
    private readonly Dictionary<Direction, MoveCommand> moveBackwardCommands;

    public MoveBackward(MarsRover marsRover) {
        this.marsRover = marsRover;
        var moveRightCommand = new MoveRightCommand(marsRover);
        var moveUpCommand = new MoveUpCommand(marsRover);
        var moveLeftCommand = new MoveLeftCommand(marsRover);
        var moveDownCommand = new MoveDownCommand(marsRover);
        moveBackwardCommands = new Dictionary<Direction, MoveCommand>
        {
            {Direction.N, moveDownCommand},
            {Direction.S, moveUpCommand},
            {Direction.E, moveLeftCommand},
            {Direction.W, moveRightCommand}
        };
    }

    public void Move() {
        moveBackwardCommands[marsRover.GetDirection()].Move();
    }
}