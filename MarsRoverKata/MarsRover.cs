namespace MarsRoverKata;

public class MarsRover {
    internal Position position;
    private readonly char direction;
    private readonly Dictionary<char, MoveCommand> moveForwardCommands;
    private readonly Dictionary<char, MoveCommand> moveBackwardCommands;


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

    }

    public Position GetPosition() {
        return position;
    }

    public void Execute(char[] commands)
    {
        if (commands.First() == 'b')
        {
            MoveBackward();
            return;
        }

        MoveForward();
    }

    private void MoveForward()
    {
        moveForwardCommands[direction].Move();
    }

    private void MoveBackward()
    {
        moveBackwardCommands[direction].Move();

    }
}