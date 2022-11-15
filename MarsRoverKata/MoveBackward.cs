namespace MarsRoverKata;

public class MoveBackward : MoveCommand {
    private readonly MarsRover marsRover;
    private readonly Dictionary<char, MoveCommand> moveBackwardCommands;

    public MoveBackward(MarsRover marsRover) {
        this.marsRover = marsRover;
        var moveRightCommand = new MoveRightCommand(marsRover);
        var moveUpCommand = new MoveUpCommand(marsRover);
        var moveLeftCommand = new MoveLeftCommand(marsRover);
        var moveDownCommand = new MoveDownCommand(marsRover);
        moveBackwardCommands = new Dictionary<char, MoveCommand>
        {
            {'N', moveDownCommand},
            {'S', moveUpCommand},
            {'E', moveLeftCommand},
            {'W', moveRightCommand}
        };
    }

    public void Move() {
        moveBackwardCommands[marsRover.direction].Move();
    }
}