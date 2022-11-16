namespace MarsRoverKata.Commands;

public class TurnLeftCommand : MoveCommand {
    private MarsRover marsRover;

    public TurnLeftCommand(MarsRover marsRover) {
        this.marsRover = marsRover;
    }

    public void Move() {
        switch (marsRover.GetDirection())
        {
            case Direction.N:
                marsRover.SetDirection(Direction.W);
                break;
            case Direction.E:
                marsRover.SetDirection(Direction.N);
                break;
            case Direction.S:
                marsRover.SetDirection(Direction.E);
                break;
            case Direction.W:
                marsRover.SetDirection(Direction.S);
                break;
        }

    }
}