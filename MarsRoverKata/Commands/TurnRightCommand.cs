namespace MarsRoverKata.Commands;

public class TurnRightCommand : MoveCommand {
    private readonly MarsRover marsRover;
    Dictionary<Direction, Action> setDirections;

    public TurnRightCommand(MarsRover marsRover) {
        this.marsRover = marsRover;
        setDirections = new Dictionary<Direction, Action>
        {
            { Direction.N, () => marsRover.SetDirection(Direction.E) },
            { Direction.E, () => marsRover.SetDirection(Direction.S) },
            { Direction.S, () => marsRover.SetDirection(Direction.W) },
            { Direction.W, () => marsRover.SetDirection(Direction.N) }

        };
    }

    public void Move() {
        setDirections[marsRover.GetDirection()]();
    }
}