# MathApp
### Лабораторная работа: Разработка тестовых пакетов MSTest и NUnit для консольного приложения на C#

#### Цель работы:
Изучить основы тестирования кода в .NET с использованием MSTest и NUnit. Разработать и применить тестовые пакеты для проверки корректности функционала консольного приложения.



### Шаги выполнения лабораторной работы:

#### 1. **Создание консольного приложения**
1. Откройте Visual Studio.
2. Создайте новый проект **Console App (.NET Framework)**.
3. Добавьте базовую логику приложения. Например, простое приложение для работы с математическими операциями:
   
   ```csharp
   namespace MathApp
   {
       public class Calculator
       {
           public int Add(int a, int b) => a + b;
           public int Subtract(int a, int b) => a - b;
           public int Multiply(int a, int b) => a * b;
           public int Divide(int a, int b) 
           {
               if (b == 0)
                   throw new DivideByZeroException("Деление на ноль невозможно.");
               return a / b;
           }
       }

       class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Введите два числа:");
               int a = int.Parse(Console.ReadLine());
               int b = int.Parse(Console.ReadLine());
               var calculator = new Calculator();
               Console.WriteLine($"Сумма: {calculator.Add(a, b)}");
           }
       }
   }
   ```



#### 2. **Настройка проекта для тестирования**
1. Создайте новый проект **Unit Test Project** для MSTest:
   - В **Solution Explorer** щелкните правой кнопкой мыши на Solution -> **Add -> New Project**.
   - Выберите **Unit Test Project (.NET Core)** или **Unit Test Project (.NET Framework)**.
2. Создайте аналогичный проект для NUnit:
   - Щелкните **Add -> New Project** и выберите **NUnit Test Project**.
   - Убедитесь, что для обоих проектов указана одна и та же версия .NET.



#### 3. **Добавление ссылок**
1. В каждом тестовом проекте добавьте ссылку на основное приложение:
   - Щелкните правой кнопкой мыши на тестовый проект -> **Add -> Project Reference**.
   - Выберите основной проект (например, `MathApp`).



#### 4. **Написание тестов**

##### Тесты на MSTest:
Создайте тестовый класс в проекте MSTest:

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathApp;

namespace MathAppTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            calculator.Divide(10, 0);
        }
    }
}
```

##### Тесты на NUnit:
Создайте тестовый класс в проекте NUnit:

```csharp
using NUnit.Framework;
using MathApp;

namespace MathAppNUnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
```

---

#### 5. **Запуск тестов**
1. Откройте **Test Explorer** в Visual Studio (**Test -> Test Explorer**).
2. Нажмите **Run All**, чтобы запустить тесты.
3. Проверьте, что все тесты проходят успешно.
