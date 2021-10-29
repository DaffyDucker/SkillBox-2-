using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_2_Домашнее_Задание
{
    class Program
    {   /// <summary>
        /// Программа "Записная Книжка" необходима для подсчета среднего балла по трем предметам
        /// для конктретного пользователя.
        /// </summary>
        /// <param name="args">Параметр запуска</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста,Введите Свое Имя:");//Подсказка для пользователя
            string FirstName = Convert.ToString(Console.ReadLine());//Присваивание значение переменной  Имя

            Console.WriteLine("Пожалуйста,Введите Свой Возраст:");//Подсказка для пользователя
            int age = int.Parse(Console.ReadLine());//Присваивание значение переменной  Возраст

            Console.WriteLine("Пожалуйста,Введите Свой Рост:");//Подсказка для пользователя
            double height = Convert.ToDouble(Console.ReadLine());//Присваивание значение переменной  Рост

            Console.WriteLine("Пожалуйста,Введите Свой Баллы по Истории:");//Подсказка для пользователя
            double ScoreHistory = Convert.ToDouble(Console.ReadLine());//Присваивание значение переменной  Баллы по Истории

            Console.WriteLine("Пожалуйста,Введите Свой Баллы по Математике:");//Подсказка для пользователя
            double ScoreMath = Convert.ToDouble(Console.ReadLine()); ;//Присваивание значение переменной  Баллы по Математике

            Console.WriteLine("Пожалуйста,Введите Свой Баллы по Русскому языку:");//Подсказка для пользователя
            double ScoreRussian = Convert.ToDouble(Console.ReadLine()); ;//Присваивание значение переменной  Баллы по Русскому Языку

            double Average = (ScoreHistory + ScoreMath + ScoreRussian) / 3;//Подсчет среднего балла по трем предметам

            #region Вывод информации на консоль при помощи Обычного вывода
            Console.WriteLine("Имя: " + FirstName + " Возраст: " + age + " Рост: " + height + " Балл по Истории: " + ScoreHistory + " Балл по Математике: " + ScoreMath + " Балл по Русскому Языку: " + ScoreRussian + " Средний балл по трем предметам: " + Average);
            #endregion
            #region Вывод информации на консоль при Форматирования строк
            string pattern = "Имя: {0} \nВозраст: {1} Рост: {2} \nБалл по Истории: {3} \nБалл по Математике: {4} \nБалл по Русскому языку: {5} \nСредний балл по трем предметам: {6}";
            Console.WriteLine(pattern,
                              FirstName,
                              age,
                              height,
                              ScoreHistory,
                              ScoreMath,
                              ScoreRussian,
                              Average);
            #endregion
            #region Вывод информации на консоль при помощи интерполяции строк
            Console.WriteLine($"Имя: {FirstName}" +
                              $"\nВозраст: {age} " +
                              $"\nРост: {height}" +
                              $"\nБалл по Истории: {ScoreHistory}" +
                              $"\nБалл по Математике: {ScoreMath}" +
                              $"\nБалл по Русскому Языку: {ScoreRussian}" +
                              $"\nСредний балл по трем предметам:  {Average}");
            #endregion
            #region Вывод информации в центре консоли
            Console.WriteLine($"Имя: {FirstName,59}" +
                              $"\nВозраст: {age,55} " +
                              $"\nРост: {height,58}" +
                              $"\nБалл по Истории: {ScoreHistory,47}" +
                              $"\nБалл по Математике: {ScoreMath,44}" +
                              $"\nБалл по Русскому Языку: {ScoreRussian,40}" +
                              $"\nСредний балл по трем предметам:  {Average,31}");
            #endregion
        }
    }
}
