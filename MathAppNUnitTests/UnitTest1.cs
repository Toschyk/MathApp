using NUnit.Framework;
using MathApp;

namespace MathAppNUnitTests
{
    // �������� ����� ��� �������� ������ ������� Calculator
    [TestFixture]
    public class CalculatorTests
    {
        // ���� ��� ���������� ������������ �������
        private Calculator calculator = null!;

        // ����� �������������, ���������� ����� ������ ������
        [SetUp]
        public void Setup()
        {
            // ������� ����� ��������� Calculator
            calculator = new Calculator();
        }

        // ����: �������� ������ Add
        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // ��������� ��������
            var result = calculator.Add(2, 3);

            // ���������, ��� ��������� ����� 5
            Assert.That(result, Is.EqualTo(5));
        }

        // ����: �������� ���������� ��� ������� �� ����
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            // ���������, ��� ����� Divide ����������� ���������� DivideByZeroException
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
