using ConsoleAppPickRandomCards;

internal class Program
{
    private static void Main(string[] args)
    {
        bool checkCoCo = true;
        while (checkCoCo)
        {
            Console.WriteLine("Введите количество карт для выбора");
            string line;
            line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                bool checkCoCoAdditional = true;

                if (numberOfCards <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите положительное число!");
                    Console.ResetColor();

                    checkCoCoAdditional = false;
                }

                // Этот блок выполняется в том случае, если строка МОЖЕТ БЫТЬ преобразована в int
                // Значение, сохраняемое в новой переменной, называется numberOfCards
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }

                while (checkCoCoAdditional)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Желаете повторить попытку? y/n");
                    Console.ResetColor();

                    string next;
                    next = Console.ReadLine();

                    if (next == "y" || next == "n")
                    {
                        if (next == "y")
                        {
                            checkCoCo = true;
                            checkCoCoAdditional = false;
                        }
                        else if (next == "n")
                        {
                            checkCoCo = false;
                            checkCoCoAdditional = false;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели неправильный ответ!");
                        Console.ResetColor();
                        checkCoCoAdditional = true;
                    }
                }
            }
            else
            {
                // Этот блок выполняется, если строка НЕ МОЖЕТ БЫТЬ преобразована в int
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите действительное, целое число!");
                Console.ResetColor();

                checkCoCo = true;
            }
        }
    }
}
