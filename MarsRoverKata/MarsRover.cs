namespace MarsRoverKata;

public class MarsRover
{
    private Position position;
    private readonly char direction;


    public MarsRover(Position position, char direction)
    {
        this.position = position;
        this.direction = direction;
    }

    public Position GetPosition()
    {
        return position;
    }

    public void Execute(char[] commands)
    {
        position = direction switch
        {
            'E' => new Position(0, 1),
            'N' => new Position(-1, 0),
            _ => position
        };
    }
}