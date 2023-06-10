using AreaCalculateLibrary.Exceptions;
using AreaCalculateLibrary.Services;
using AreaCalculateLibrary.Shapes;

namespace AreaCalculateUnits
{
    public class UnitTest1
    {
        [Fact]
        public void Check_TrustRectangleArea_True()
        {
            IShape shape = new Rectangle(3, 4, 5);
            double excepted = 6;

            double actual = shape.GetArea();

            Assert.True(excepted == actual);
        }

        [Fact]
        public void Check_TrustCirleArea_True()
        {
            IShape shape = new Circle(3);
            double excepted = 28.3;

            double actual = Math.Round(shape.GetArea(), 1);

            Assert.True(excepted == actual);
        }

        [Fact]
        public void Check_RectangleNotExist_True()
        {
            var ex = Assert.Throws<RectangleException>(() => new Rectangle(1, 1, 10));

            string excepted = "Треугольника с указанными сторонами не существует.";

            Assert.Equal(excepted, ex.Message);
        }

        [Fact]
        public void Check_RectangleIsRectangular_True()
        {
            Rectangle shape = new Rectangle(24, 7, 25);

            bool actual = shape.IsRectangular();

            Assert.True(actual);
        }
    }
}