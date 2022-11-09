using FluentAssertions;

namespace MarsRoverTests {
    public class MarsRoverShould {

        [Test]
        public void moveForward()
        {
            const char initialDirection = 'N';
            var initialPosition = new Position(0,0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] {'f'};

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(0,1);
            marsRoverPosition.Should().Be(expectedMarsRoverPosition);
        }
    }

    public class MarsRover
    {
        public MarsRover(Position initialPosition, char initialDirection)
        {
            throw new NotImplementedException();
        }

        public Position GetPosition()
        {
            throw new NotImplementedException();
        }

        public void Execute(char[] commands)
        {
            throw new NotImplementedException();
        }
    }

    public class Position
    {
        public Position(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}