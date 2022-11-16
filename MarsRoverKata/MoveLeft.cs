namespace MarsRoverKata;

public class MoveLeft : MoveCommand {
    private MarsRover marsRover;

    public MoveLeft(MarsRover marsRover) {
        this.marsRover = marsRover;
    }

    public void Move() {

        if (marsRover.GetDirection().Equals('N')) {
            marsRover.SetDirection('W');
        }
        else if (marsRover.GetDirection().Equals('W')) {
            marsRover.SetDirection('S');
        }
        else {
            marsRover.SetDirection('E');
        }

    }
}