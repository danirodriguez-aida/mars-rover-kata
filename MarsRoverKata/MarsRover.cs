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
        if (commands.First() == 'b')
        {
            position = direction switch
            {
                'E' => new Position(-1, 0),
                'N' => new Position(0, -1),
                _ => position
            };
            return;
        }

        position = direction switch
        {
            'E' => new Position(1, 0),
            'N' => new Position(0, 1),
            'W' => new Position(-1, 0),
            'S' => new Position(0, -1),
            _ => position
        };
    }
}