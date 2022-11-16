namespace MarsRoverKata;

public class MoveLeft : MoveCommand {
    private MarsRover marsRover;

    public MoveLeft(MarsRover marsRover) {
        this.marsRover = marsRover;
    }

    public void Move() {
        switch (marsRover.GetDirection())
        {
            case 'N':
                marsRover.SetDirection('W');
                break;
            case 'E':
                marsRover.SetDirection('N');
                break;
            case 'S':
                marsRover.SetDirection('E');
                break;
            case 'W':
                marsRover.SetDirection('S');
                break;
        }

    }
}