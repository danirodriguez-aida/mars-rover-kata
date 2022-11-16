using FluentAssertions;
using MarsRoverKata;

namespace MarsRoverTests {
    public class MarsRoverShould {

        [TestCase(0, 0, 1, 0, TestName = "(0,0)")]
        [TestCase(1, 0, 2, 0, TestName = "(1,0)")]
        [TestCase(2, 0, 3, 0, TestName = "(2,0)")]
        [TestCase(2, 1, 3, 1, TestName = "(2,1)")]
        public void move_forward_when_direction_is_East_and_position_is(int xInitial, int yInitial, int xFinal, int yFinal) {
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.E);
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
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.N);
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
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.W);
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
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.S);
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
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.E);
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
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.N);
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
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.W);
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
            var initialPosition = new Position(xInitial, yInitial);
            var marsRover = new MarsRover(initialPosition, Direction.S);
            var commands = new[] { 'b' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(xFinal, yFinal);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [Test]
        public void move_array_commands_when_direction_is_East() {
            var initialPosition = new Position(0, 0);
            var marsRover = new MarsRover(initialPosition, Direction.E);
            var commands = new[] { 'f', 'f', 'f', 'b' };

            marsRover.Execute(commands);

            var marsRoverPosition = marsRover.GetPosition();
            var expectedMarsRoverPosition = new Position(2, 0);
            marsRoverPosition.Should().BeEquivalentTo(expectedMarsRoverPosition);
        }

        [TestCase(Direction.N, Direction.E, TestName = "North")]
        [TestCase(Direction.E, Direction.S, TestName = "East")]
        [TestCase(Direction.S, Direction.W, TestName = "South")]
        [TestCase(Direction.W, Direction.N, TestName = "West")]
        public void turn_right_when_direction_is(Direction initialDirection, Direction expectedDirection ) {
            var initialPosition = new Position(0, 0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'r' };

            marsRover.Execute(commands);

            var marsRoverDirection = marsRover.GetDirection();
            marsRoverDirection.Should().Be(expectedDirection);
        }

        [TestCase(Direction.N, Direction.W, TestName = "North")]
        [TestCase(Direction.W, Direction.S, TestName = "West")]
        [TestCase(Direction.S, Direction.E, TestName = "South")]
        [TestCase(Direction.E, Direction.N, TestName = "East")]
        public void turn_left_when_direction_is(Direction initialDirection, Direction expectedDirection ) {
            var initialPosition = new Position(0, 0);
            var marsRover = new MarsRover(initialPosition, initialDirection);
            var commands = new[] { 'l' };

            marsRover.Execute(commands);

            var marsRoverDirection = marsRover.GetDirection();
            marsRoverDirection.Should().Be(expectedDirection);
        }
    }
}