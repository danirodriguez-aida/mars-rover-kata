namespace MarsRoverKata;

public class MoveDownCommand : MoveCommand {
    private readonly MarsRover marsRover;

    public MoveDownCommand(MarsRover marsRover) {
        this.marsRover = marsRover;
    }

    public void Move() {
        marsRover.SetNextDownPosition();
    }
}