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
        switch (marsRover.direction)
        {
            case 'N':
                marsRover.direction = 'E';
                break;
            case 'E':
                marsRover.direction = 'S';
                break;
            case 'S':
                marsRover.direction = 'W';
                break;
            case 'W':
                marsRover.direction = 'N';
                break;
        }
    }
}