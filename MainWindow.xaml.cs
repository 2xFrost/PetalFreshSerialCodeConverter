using System.Windows;
using System.Windows.Input;

namespace PetalFreshKonweter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {         
            InitializeComponent();           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Input = UserInput.Text;
            Product product = new();

            if (Input.Length == 10 && "ABCDEFGHIJKL".Contains(Input[9]))
            {
                ProductOperations petal = new();
                petal.SetSerialCode(product,Input);
                petal.SetManufactureDate(product);               
                petal.SetShelfLife(product);

                ManufactureDateOutput.Text = product.ManufactureDate.ToString("dd/MM/yyyy");
                SerialCodeOutput.Text = product.SerialCode;
                ShelfLIfeOutput.Text = product.ShelfLife.Date.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("NIEPRAWIDŁOWA SERIA PRODUKTU");
            }         
        }

        private void CalculateValues_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
            
        }
    }
}
