namespace MarsRoverKata;

public class MarsRover {
    private Position position;
    private char direction;
    private readonly Dictionary<char, MoveCommand> moveCommands;

    public MarsRover(Position position, char direction) {
        this.position = position;
        this.direction = direction;

        var moveForward = new MoveForward(this);
        var moveBackward = new MoveBackward(this);
        var moveRight = new MoveRight(this);
        moveCommands = new Dictionary<char, MoveCommand>
        {
            {'f', moveForward},
            {'b', moveBackward},
            {'r', moveRight},
        };
    }

    public Position GetPosition() {
        return position;
    }

    public void Execute(char[] commands) {
        foreach (var command in commands) {
            if (command.Equals('l'))
            {
                SetDirection('W');
                continue;
            }

            moveCommands[command].Move();
        }
    }

    public char GetDirection() {
        return direction;
    }

    public void SetDirection(char newDirection) {
        direction = newDirection;
    }

    internal void SetNextRightPosition() => position = position.NextRightPosition();

    internal void SetNextDownPosition() => position = position.NextDownPosition();

    internal void SetNextLeftPosition() => position = position.NextLeftPosition();

    internal void SetNextUpPosition() => position = position.NextUpPosition();
}