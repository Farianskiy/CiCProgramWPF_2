namespace FindPercentLib
{
    public class ZadanueTwo
    {
        public string FindPercentZP(string zp)
        {

            string[] strings = zp.Split(' '); // Здесь используем символ пробела в одинарных кавычках
            int[] ints = new int[strings.Length];

            // Преобразуем строки в целые числа и проверяем успешность преобразования
            for (int i = 0; i < strings.Length; i++)
            {
                if (!int.TryParse(strings[i], out ints[i]))
                {
                    return "-";
                }
            }

            // Находим максимальное и минимальное значения в массиве
            int max = ints.Max();
            int min = ints.Min();

            // Вычисляем процентное отношение
            int percent = min * 100 / max;

            return percent.ToString();
        }
    }
}
