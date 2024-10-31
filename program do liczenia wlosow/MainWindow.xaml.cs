using System;
using System.Windows;

namespace SzacowanieWlosowNaGlowie
{
    public partial class MainWindow : Window
    {
        private Glowa glowa = new Glowa();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double gestosc = Convert.ToDouble(gestoscTextBox.Text);
                double obwod = Convert.ToDouble(obwodTextBox.Text);
                double wysokosc = Convert.ToDouble(wysokoscTextBox.Text);

                glowa.UstawGestoscWlosow(gestosc);
                glowa.UstawObwodGlowy(obwod);
                glowa.UstawWysokoscCzola(wysokosc);

                glowa.ObliczLiczbeWlosow();
                double liczbaWlosow = glowa.PobierzLiczbeWlosow();

                wynikTextBlock.Text = $"Szacunkowa liczba włosów: {liczbaWlosow}";

                double procentWiecejMniej = glowa.PorownajDoSredniej();
                porownanieTextBlock.Text = procentWiecejMniej > 0
                    ? $"Masz {Math.Abs(procentWiecejMniej):F2}% więcej włosów niż przeciętna."
                    : $"Masz {Math.Abs(procentWiecejMniej):F2}% mniej włosów niż przeciętna.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadź poprawne dane liczbowe!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Resetuj_Click(object sender, RoutedEventArgs e)
        {
            glowa.Resetuj();
            gestoscTextBox.Clear();
            obwodTextBox.Clear();
            wysokoscTextBox.Clear();
            wynikTextBlock.Text = "";
            porownanieTextBlock.Text = "";
        }
    }
}
