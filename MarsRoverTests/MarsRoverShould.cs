using FluentAssertions;
using MarsRoverKata;

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
            var expectedMarsRoverPosition = new Position(1,0);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [Test]
        public void move_forward_when_direction_is_North()
        {
            const char initialDirection = 'N';
            var initialPosition = new Position(0,0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] {'f'};

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(0,1);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [Test]
        public void move_forward_when_direction_is_West()
        {
            const char initialDirection = 'W';
            var initialPosition = new Position(0,0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] {'f'};

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(-1,0);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [Test]
        public void move_forward_when_direction_is_South()
        {
            const char initialDirection = 'S';
            var initialPosition = new Position(0,0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] {'f'};

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(0,-1);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }
    }
}