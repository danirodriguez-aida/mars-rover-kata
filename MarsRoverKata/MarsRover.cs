namespace MarsRoverKata;

public class MarsRover {
    private Position position;
    private readonly char direction;


    public MarsRover(Position position, char direction) {
        this.position = position;
        this.direction = direction;
    }

    public Position GetPosition() {
        return position;
    }

    public void Execute(char[] commands)
    {
        if (commands.First() == 'b')
        {
            MoveBackward();
            return;
        }

        MoveForward();
    }

    private void MoveForward()
    {
        position = direction switch
        {
            'E' => position.NextRightPosition(),
            'N' => position.NextUpPosition(),
            'W' => position.NextLeftPosition(),
            'S' => position.NextDownPosition(),
            _ => position
        };
    }

    private void MoveBackward()
    {
        position = direction switch
        {
            'E' => position.NextLeftPosition(),
            'N' => position.NextDownPosition(),
            'W' => position.NextRightPosition(),
            'S' => position.NextUpPosition(),
            _ => position
        };
    }
}