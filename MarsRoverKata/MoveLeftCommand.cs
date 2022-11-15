namespace MarsRoverKata;

public class MoveLeftCommand : MoveCommand {
    private readonly MarsRover marsRover;

    public MoveLeftCommand(MarsRover marsRover) {
        this.marsRover = marsRover;
    }

    public void Move() {
        marsRover.SetNextLeftPosition();
    }
}