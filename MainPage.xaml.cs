using System;
using System.Globalization;

namespace AppMercado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Método que se ejecuta cada vez que el texto cambia
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string text = ProductEditor.Text;
            UpdateTotal(text);
        }

        // Método para calcular el total
        private void UpdateTotal(string inputText)
        {
            decimal total = 0;
            string[] lines = inputText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                string[] parts = line.Trim().Split(' ');

                // Asegúrate de que haya al menos dos partes: el nombre y el precio
                if (parts.Length == 2)
                {
                    string priceText = parts[1].Trim();
                    if (decimal.TryParse(priceText, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal price))
                    {
                        total += price;
                    }
                }
            }

            // Actualizar el total mostrado en la UI
            TotalLabel.Text = $"Total: ${total:F2}";
        }
    }
}
