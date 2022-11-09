namespace MarsRoverKata;

public class MarsRover {
    internal Position position;
    private readonly char direction;
    private readonly MoveRightCommand moveRightCommand;
    private readonly MoveUpCommand moveUpCommand;
    private readonly MoveLeftCommand moveLeftCommand;
    private readonly MoveDownCommand moveDownCommand;
    private Dictionary<char, MoveCommand> moveForwardCommands;
    private Dictionary<char, MoveCommand> moveBackwardCommands;


    public MarsRover(Position position, char direction) {
        this.position = position;
        this.direction = direction;
        moveRightCommand = new MoveRightCommand(this);
        moveUpCommand = new MoveUpCommand(this);
        moveLeftCommand = new MoveLeftCommand(this);
        moveDownCommand = new MoveDownCommand(this);
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