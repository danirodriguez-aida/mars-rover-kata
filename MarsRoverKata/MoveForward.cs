namespace MarsRoverKata;

public class MoveForward : MoveCommand {
    private readonly MarsRover marsRover;
    private readonly Dictionary<char, MoveCommand> moveForwardCommands;

    public MoveForward(MarsRover marsRover) {
        this.marsRover = marsRover;
        var moveRightCommand = new MoveRightCommand(marsRover);
        var moveUpCommand = new MoveUpCommand(marsRover);
        var moveLeftCommand = new MoveLeftCommand(marsRover);
        var moveDownCommand = new MoveDownCommand(marsRover);
        moveForwardCommands = new Dictionary<char, MoveCommand>
        {
            {'N', moveUpCommand},
            {'S', moveDownCommand},
            {'E', moveRightCommand},
            {'W', moveLeftCommand}
        };
    }

    public void Move() {
        moveForwardCommands[marsRover.GetDirection()].Move();
    }
}