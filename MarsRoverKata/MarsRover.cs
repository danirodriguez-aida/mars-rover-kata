namespace MarsRoverKata;

public class MarsRover {
    internal Position position;
    internal readonly char direction;
    internal readonly Dictionary<char, MoveCommand> moveForwardCommands;
    internal readonly Dictionary<char, MoveCommand> moveBackwardCommands;
    private readonly Dictionary<char, MoveCommand> moveCommands;

    public MarsRover(Position position, char direction) {
        this.position = position;
        this.direction = direction;
        var moveRightCommand = new MoveRightCommand(this);
        var moveUpCommand = new MoveUpCommand(this);
        var moveLeftCommand = new MoveLeftCommand(this);
        var moveDownCommand = new MoveDownCommand(this);
        moveForwardCommands = new Dictionary<char, MoveCommand>
        {
            {'N', moveUpCommand},
            {'S', moveDownCommand},
            {'E', moveRightCommand},
            {'W', moveLeftCommand}
        };
        moveBackwardCommands = new Dictionary<char, MoveCommand>
        {
            {'N', moveDownCommand},
            {'S', moveUpCommand},
            {'E', moveLeftCommand},
            {'W', moveRightCommand}
        };
        var moveForward = new MoveForward(this);
        var moveBackward = new MoveBackward(this);
        moveCommands = new Dictionary<char, MoveCommand>
        {
            {'f', moveForward},
            {'b', moveBackward},
        };
    }

    public Position GetPosition() {
        return position;
    }

    public void Execute(char[] commands)
    {
        var firstCommand = commands.First();
        moveCommands[firstCommand].Move();
    }
}