using FluentAssertions;
using MarsRoverKata;

namespace MarsRoverTests {
    public class MarsRoverShould {

        [TestCase(0, 0, 1, 0, TestName = "(0,0)")]
        [TestCase(1, 0, 2, 0, TestName = "(1,0)")]
        [TestCase(2, 0, 3, 0, TestName = "(2,0)")]
        [TestCase(2, 1, 3, 1, TestName = "(2,1)")]
        public void move_forward_when_direction_is_East_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'E';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'f' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(0, 0, 0, 1, TestName = "(0,0)")]
        [TestCase(0, 1, 0, 2, TestName = "(0,1)")]
        [TestCase(0, 2, 0, 3, TestName = "(0,2)")]
        [TestCase(1, 2, 1, 3, TestName = "(1,2)")]
        public void move_forward_when_direction_is_North_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'N';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'f' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(0, 0, -1, 0, TestName = "(0,0)")]
        [TestCase(-1, 0, -2, 0, TestName = "(-1,0)")]
        [TestCase(-2, 0, -3, 0, TestName = "(-2,0)")]
        [TestCase(-2, 1, -3, 1, TestName = "(-2,1)")]
        public void move_forward_when_direction_is_West_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'W';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'f' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(0, 0, 0, -1, TestName = "(0,0)")]
        [TestCase(0, -1, 0, -2, TestName = "(0,-1)")]
        [TestCase(0, -2, 0, -3, TestName = "(0,-2)")]
        [TestCase(1, -2, 1, -3, TestName = "(1,-2)")]
        public void move_forward_when_direction_is_South_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'S';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'f' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(0, 0, -1, 0, TestName = "(0,0)")]
        [TestCase(-1, 0, -2, 0, TestName = "(-1,0)")]
        [TestCase(-2, 0, -3, 0, TestName = "(-2,0)")]
        [TestCase(-2, 1, -3, 1, TestName = "(-2,1)")]
        public void move_backward_when_direction_is_East_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'E';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'b' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(0, 0, 0, -1, TestName = "(0,0)")]
        [TestCase(0, -1, 0, -2, TestName = "(0,-1)")]
        [TestCase(0, -2, 0, -3, TestName = "(0,-2)")]
        [TestCase(1, -2, 1, -3, TestName = "(1,-2)")]
        public void move_backward_when_direction_is_North_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'N';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'b' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(0, 0, 1, 0, TestName = "(0,0)")]
        [TestCase(1, 0, 2, 0, TestName = "(1,0)")]
        [TestCase(2, 0, 3, 0, TestName = "(2,0)")]
        [TestCase(2, 1, 3, 1, TestName = "(2,1)")]
        public void move_backward_when_direction_is_West_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'W';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'b' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(0, 0, 0, 1, TestName = "(0,0)")]
        [TestCase(0, 1, 0, 2, TestName = "(0,1)")]
        [TestCase(0, 2, 0, 3, TestName = "(0,2)")]
        [TestCase(1, 2, 1, 3, TestName = "(1,2)")]
        public void move_backward_when_direction_is_South_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            const char initialDirection = 'S';
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'b' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [Test]
        public void move_array_commands_when_direction_is_East() {
            const char initialDirection = 'E';
            var initialPosition = new Position(0, 0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'f', 'f', 'f', 'b' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(2, 0);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase('N', 'E', TestName = "North")]
        [TestCase('E', 'S', TestName = "East")]
        [TestCase('S', 'W', TestName = "South")]
        [TestCase('W', 'N', TestName = "West")]
        public void turn_right_when_direction_is(char initialDirection, char expectedDirection ) {
            var initialPosition = new Position(0, 0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'r' };

            marsRover.Execute(commands);

            var marsRoverDirection = marsRover.GetDirection();
            marsRoverDirection.Should().Be(expectedDirection);
        }

        [TestCase('N', 'W', TestName = "North")]
        [TestCase('W', 'S', TestName = "West")]
        [TestCase('S', 'E', TestName = "South")]
        [TestCase('E', 'N', TestName = "East")]
        public void turn_left_when_direction_is(char initialDirection, char expectedDirection ) {
            var initialPosition = new Position(0, 0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'l' };

            marsRover.Execute(commands);

            var marsRoverDirection = marsRover.GetDirection();
            marsRoverDirection.Should().Be(expectedDirection);
        }
    }
}