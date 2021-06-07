using System;
using Faisalman.AgeCalc;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            DateTime planDate = new DateTime(2021, 5, 29);
            DateTime factDate = new DateTime(2021, 5, 29);
            Console.Write("Событие выполнено ");
            if (factDate == planDate)
                Console.WriteLine("вовремя");
            else if (factDate < planDate)
                Console.WriteLine("раньше назначенного срока");
            else
                Console.WriteLine("позже назначенного срока");
            Console.WriteLine();

            //2
            DateTime firstDate = new DateTime(2021, 5, 29, 11, 47, 15);
            DateTime secondDate = new DateTime(2021, 5, 28, 11, 12, 13);
            Console.WriteLine("Даты совпадают по:");
            if (firstDate.Second == secondDate.Second)
                Console.WriteLine($"секундам ({firstDate.Second})");
            if (firstDate.Minute == secondDate.Minute)
                Console.WriteLine($"минутам ({firstDate.Minute})");
            if (firstDate.Hour == secondDate.Hour)
                Console.WriteLine($"часам ({firstDate.Hour})");
            if (firstDate.Day == secondDate.Day)
                Console.WriteLine($"дню ({firstDate.Day})");
            if (firstDate.Month == secondDate.Month)
                Console.WriteLine($"месяцу ({firstDate.Month})");
            if (firstDate.Year == secondDate.Year)
                Console.WriteLine($"году ({firstDate.Year})");
            Console.WriteLine();

            //3
            DateTime dateOfBirth = new DateTime(1997, 5, 19);
            if (dateOfBirth > DateTime.Today)
                Console.WriteLine("Человек ещё не родился");
            else
            {
                Age age = new Age(dateOfBirth);
                DateTime futureBirthday = new DateTime(DateTime.Today.Year + 1, dateOfBirth.Month, dateOfBirth.Day);
                if (dateOfBirth == DateTime.Today)
                    Console.WriteLine($"С днем рождения! Вам {age.Years}");
                else if (dateOfBirth > DateTime.Today)
                    Console.WriteLine("Человек ещё не родился");
                else
                {
                    Console.WriteLine($"Точный возраст человека: " +
                                        $"{age.Years} {YearsWord(age.Years)} " +
                                        $"{age.Months} {MonthsWord(age.Months)} " +
                                        $"{age.Days} {DaysWord(age.Days)}");
                }
                Console.WriteLine($"Дней до следующего дня рождения: {(futureBirthday - DateTime.Today).TotalDays}");
                Console.WriteLine($"В этом году день рождения выпал на {(futureBirthday.AddYears(-1)).DayOfWeek}");
            }
            Console.WriteLine();

            //4
            DateTime alarmClock = DateTime.Today.AddDays(1).AddHours(1).AddMinutes(1).AddSeconds(1);
            DateTime now = DateTime.Now;
            if (alarmClock <= now)
                Console.WriteLine("Будильник уже сработал!");
            else
                Console.WriteLine($"Будильник сработает через: " +
                                  $"{(alarmClock - now).Hours} {HoursWord((alarmClock - now).Hours)} " +
                                  $"{(alarmClock - now).Minutes} {MinutesWord((alarmClock - now).Minutes)} " +
                                  $"{(alarmClock - now).Seconds} {SecondsWord((alarmClock - now).Seconds)}");
            Console.WriteLine();

            //5
            Console.WriteLine($"Москва {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Russian Standard Time")}");
            Console.WriteLine($"Лондон {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "GMT Standard Time")}");
            Console.WriteLine($"Нью-Йорк {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "US Eastern Standard Time")}");
            Console.WriteLine($"Токио {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Tokyo Standard Time")}");
            Console.WriteLine($"Пекин {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "China Standard Time")}");
        }

        static string YearsWord(int d)
        {
            if ((d % 10 == 0) || (d % 100 >= 5 && d % 100 <= 20) || (d % 10 >= 5 && d % 10 <= 9))
            {
                return "лет";
            }
            else if (d % 10 >= 2 && d % 10 <= 4)
            {
                return "года";
            }
            else return "год";
        }

        static string MonthsWord(int d)
        {
            if ((d % 10 == 0) || (d % 100 >= 5 && d % 100 <= 20) || (d % 10 >= 5 && d % 10 <= 9))
            {
                return "месяцев";
            }
            else if (d % 10 >= 2 && d % 10 <= 4)
            {
                return "месяца";
            }
            else return "месяц";
        }

        static string DaysWord(int d)
        {
            if ((d % 10 == 0) || (d % 100 >= 5 && d % 100 <= 20) || (d % 10 >= 5 && d % 10 <= 9))
            {
                return "дней";
            }
            else if (d % 10 >= 2 && d % 10 <= 4)
            {
                return "дня";
            }
            else return "день";
        }

        static string HoursWord(int d)
        {
            if ((d % 10 == 0) || (d % 100 >= 5 && d % 100 <= 20) || (d % 10 >= 5 && d % 10 <= 9))
            {
                return "часов";
            }
            else if (d % 10 >= 2 && d % 10 <= 4)
            {
                return "часа";
            }
            else return "час";
        }

        static string MinutesWord(int d)
        {
            if ((d % 10 == 0) || (d % 100 >= 5 && d % 100 <= 20) || (d % 10 >= 5 && d % 10 <= 9))
            {
                return "минут";
            }
            else if (d % 10 >= 2 && d % 10 <= 4)
            {
                return "минуты";
            }
            else return "минуту";
        }

        static string SecondsWord(int d)
        {
            if ((d % 10 == 0) || (d % 100 >= 5 && d % 100 <= 20) || (d % 10 >= 5 && d % 10 <= 9))
            {
                return "секунд";
            }
            else if (d % 10 >= 2 && d % 10 <= 4)
            {
                return "секунды";
            }
            else return "секунду";
        }
    }
}
