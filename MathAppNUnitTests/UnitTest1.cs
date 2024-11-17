using NUnit.Framework;
using MathApp;

namespace MathAppNUnitTests
{
    // Тестовый класс для проверки работы методов Calculator
    [TestFixture]
    public class CalculatorTests
    {
        // Поле для экземпляра тестируемого объекта
        private Calculator calculator = null!;

        // Метод инициализации, вызывается перед каждым тестом
        [SetUp]
        public void Setup()
        {
            // Создаем новый экземпляр Calculator
            calculator = new Calculator();
        }

        // Тест: проверка метода Add
        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Выполняем сложение
            var result = calculator.Add(2, 3);

            // Проверяем, что результат равен 5
            Assert.That(result, Is.EqualTo(5));
        }

        // Тест: проверка исключения при делении на ноль
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            // Проверяем, что метод Divide выбрасывает исключение DivideByZeroException
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
