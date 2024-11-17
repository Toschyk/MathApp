using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathApp;

namespace MathAppTests
{
    // Класс тестов для проверки работы класса Calculator
    [TestClass]
    public class CalculatorTests
    {
        // Поле для экземпляра тестируемого объекта
        private Calculator calculator = null!;

        // Метод инициализации, вызывается перед каждым тестом
        [TestInitialize]
        public void Setup()
        {
            // Создаем новый экземпляр Calculator перед запуском каждого теста
            calculator = new Calculator();
        }

        // Тест: проверка корректной работы метода Add
        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Выполняем сложение двух чисел
            var result = calculator.Add(2, 3);

            // Проверяем, что результат равен 5
            Assert.AreEqual(5, result);
        }

        // Тест: проверка выброса исключения при делении на ноль
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))] // Указываем, что ожидается исключение типа DivideByZeroException
        public void Divide_ByZero_ThrowsException()
        {
            // Вызываем метод Divide с делением на 0, что должно вызвать исключение
            calculator.Divide(10, 0);
        }
    }
}
