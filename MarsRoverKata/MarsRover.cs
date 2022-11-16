using MarsRoverKata.Commands;

namespace MarsRoverKata;

public class MarsRover {
    private Position position;
    private readonly Dictionary<char, MoveCommand> moveCommands;
    private Direction direction;

    public MarsRover(Position position, Direction direction) {
        this.position = position;
        this.direction = direction;

        var moveForward = new MoveForwardCommand(this);
        var moveBackward = new MoveBackwardCommand(this);
        var moveRight = new TurnRightCommand(this);
        var moveLeft = new TurnLeftCommand(this);
        moveCommands = new Dictionary<char, MoveCommand>
        {
            {'f', moveForward},
            {'b', moveBackward},
            {'r', moveRight},
            {'l', moveLeft},
        };
    }

    public Position GetPosition() {
        return position;
    }

    public void Execute(char[] commands) {
        foreach (var command in commands) {
            moveCommands[command].Move();
        }
    }

    public Direction GetDirection() {
        return direction;
    }

    public void SetDirection(Direction newDirection) {
        direction = newDirection;
    }

    internal void SetNextRightPosition() => position = position.NextRightPosition();

    internal void SetNextDownPosition() => position = position.NextDownPosition();

    internal void SetNextLeftPosition() => position = position.NextLeftPosition();

    internal void SetNextUpPosition() => position = position.NextUpPosition();
}