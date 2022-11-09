namespace MarsRoverKata;

public class MarsRover {
    internal Position position;
    private readonly char direction;
    private readonly MoveRightCommand moveRightCommand;
    private readonly MoveUpCommand moveUpCommand;
    private readonly MoveLeftCommand moveLeftCommand;
    private readonly MoveDownCommand moveDownCommand;


    public MarsRover(Position position, char direction) {
        this.position = position;
        this.direction = direction;
        moveRightCommand = new MoveRightCommand(this);
        moveUpCommand = new MoveUpCommand(this);
        moveLeftCommand = new MoveLeftCommand(this);
        moveDownCommand = new MoveDownCommand(this);
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
            'E' => moveRightCommand.Move(),
            'N' => moveUpCommand.Move(),
            'W' => moveLeftCommand.Move(),
            'S' => moveDownCommand.Move(),
            _ => position
        };
    }

    private void MoveBackward()
    {
        position = direction switch
        {
            'E' => moveLeftCommand.Move(),
            'N' => moveDownCommand.Move(),
            'W' => moveRightCommand.Move(),
            'S' => moveUpCommand.Move(),
            _ => position
        };
    }
}