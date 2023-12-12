namespace ConsoleAppPickRandomCards
{
    /// <summary>
    /// Сборщик карт
    /// </summary>
    class CardPicker
    {
        static Random randomCoCo = new Random();

        /// <summary>
        /// Выбрать несколько карт
        /// </summary>
        /// <param name="numberOfCards"></param>
        /// <returns>Массив строк с названием карт</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            if (numberOfCards <= 0)
            {
                string[] pickedCards = new string[0];

                return pickedCards;
            }
            else
            {
                string[] pickedCards = new string[numberOfCards];

                for (int i = 0; i < numberOfCards; i = i + 1)
                {
                    pickedCards[i] = RandomValue() + " of " + RandomSuit();
                }

                // Команда return заставляет метод немедленно прервать выполнение и вернуться к команде, из которой он был вызван
                return pickedCards;
            }
        }

        // Случайная карта
        private static string RandomSuit()
        {
            // Получить случайное число от 1 до 4, не включая 5
            int valueCoCoDi = randomCoCo.Next(1, 5);

            // Если 1, вернуть строку "Spades" Пики
            if (valueCoCoDi == 1) return "Spades";
            // Если 2, вернуть строку "Hearts" Сердца / Черви
            if (valueCoCoDi == 2) return "Hearts";
            // Если 3, вернуть строку "Clubs" Трефы / Клубы
            if (valueCoCoDi == 3) return "Clubs";
            // Если выполнение продолжается, вернуть строку "Diamonds" Бриллианты
            return "Diamonds";
        }

        // Случайное значение
        private static string RandomValue()
        {
            int valueCoCoDe = randomCoCo.Next(1, 14);

            if (valueCoCoDe == 1) return "Ace";
            if (valueCoCoDe == 11) return "Jack";
            if (valueCoCoDe == 12) return "Queen";
            if (valueCoCoDe == 13) return "King";
            // valueCoCoDe является int, а метод RandomValue() был объявлен со строковым возвращаемым типом, поэтому valueCoCoDe необходимо преобразовать в строку
            // Добавление .ToString() к любой переменной или значению преобразует их в строку
            return valueCoCoDe.ToString();
        }
    }
}
