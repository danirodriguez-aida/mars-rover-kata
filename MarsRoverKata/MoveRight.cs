namespace MarsRoverKata;

public class MoveRight: MoveCommand
{
    private readonly MarsRover marsRover;

    public MoveRight(MarsRover marsRover)
    {
        this.marsRover = marsRover;
    }

    public void Move()
    {
        switch (marsRover.GetDirection())
        {
            case 'N':
                marsRover.SetDirection('E');
                break;
            case 'E':
                marsRover.SetDirection('S');
                break;
            case 'S':
                marsRover.SetDirection('W');
                break;
            case 'W':
                marsRover.SetDirection('N');
                break;
        }
    }
}