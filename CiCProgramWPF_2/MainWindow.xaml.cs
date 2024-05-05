using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CiCProgramWPF_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string result = FindPercent(salaryInput.Text);
                resultText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }


        private string FindPercent(string zp)
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
