using System;

namespace PracticalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Громогласов Дмитрий Валерьевич";  // Фамилия, имя, отчество персонажа.

            byte age = 29;  // Возраст.

            string email = "gromdmitry94@gmail.com";

            float programmingScores = 37.5F;  // Баллы по программированию.
            float mathScores = 36.6F;  // Баллы по математике.
            float physicsScores = 25.0F;  // Баллы по физике.

            string pattern = "Ф.И.О: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              programmingScores,
                              mathScores,
                              physicsScores);
            Console.ReadKey();

            float totalScores = programmingScores + mathScores + physicsScores;  // Сумма всех баллов.
            float averageScore = totalScores / 3;  // Среднее арифметическое всех баллов.
            string newPattern = "Сумма всех баллов: {0} \nСреднее арифметическое всех баллов: {1}";

            Console.WriteLine(newPattern,
                              totalScores,
                              averageScore);
            Console.ReadKey();
        }
    }
}
