using FluentAssertions;

namespace MarsRoverTests {
    public class MarsRoverShould {

        [Test]
        public void move_forward_when_direction_is_East()
        {
            const char initialDirection = 'E';
            var initialPosition = new Position(0,0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] {'f'};

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(0,1);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }
    }

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
            position = new Position(0, 1);
        }
    }

    public class Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}