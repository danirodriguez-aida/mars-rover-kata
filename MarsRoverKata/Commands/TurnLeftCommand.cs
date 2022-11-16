namespace MarsRoverKata.Commands;

public class TurnLeftCommand : MoveCommand {
    private MarsRover marsRover;
    Dictionary<Direction, Action> setDirections;

    public TurnLeftCommand(MarsRover marsRover) {
        this.marsRover = marsRover;
        setDirections = new Dictionary<Direction, Action>
        {
            { Direction.N, () => marsRover.SetDirection(Direction.W) },
            { Direction.E, () => marsRover.SetDirection(Direction.N) },
            { Direction.S, () => marsRover.SetDirection(Direction.E) },
            { Direction.W, () => marsRover.SetDirection(Direction.S) }

        };
    }

    public void Move() {
        setDirections[marsRover.GetDirection()]();
    }
}