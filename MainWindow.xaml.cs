using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageEditor
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

        private void SelectImageButton_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wählen Sie ein Bild aus";
            openFileDialog.Filter = "Alle Bilder (*.jpeg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png;";
            openFileDialog.Multiselect = false;


            bool? result = openFileDialog.ShowDialog();
            if (result == true)
                try
                {
                    string selectedFilePath = openFileDialog.FileName;
                    BitmapImage bitmap = new BitmapImage(new Uri(selectedFilePath));
                    ImageToEdit.Source = bitmap;
                    ImageEditingMethodListbox.Visibility = Visibility.Visible;
                    ImageEditingSpecifications.Visibility   = Visibility.Visible;
                    
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Öffnen der Datei: " + ex.Message, "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            else
            {
                MessageBox.Show("Es wurde keine Datei ausgewählt.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SetImageWidthButton_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ImageToEdit.Width = Convert.ToInt32(SetImageWidthTextBox.Text);

            }
            catch
            {
                MessageBox.Show("Geben Sie bitte eine Zahl ein.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ResizeButton_Click(object sender, RoutedEventArgs e)
        {
            
           ImageEditingSpecificationsLabel.Content = "Geben Sie die gewünschte \nHöhe oder Breite an";
            SetImageWidthTextBox.Visibility = Visibility.Visible;
            SetImageHeightTextBox.Visibility = Visibility.Visible;
            TextBlockSetHeight.Visibility = Visibility.Visible;
            TextBlockSetWidth.Visibility = Visibility.Visible;
            ImageEditingSpecificationsLabel.Visibility = Visibility.Visible;
        }

        private void SetImageHeightButton_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ImageToEdit.Height = Convert.ToInt32(SetImageHeightTextBox.Text);

            }
            catch
            {
                MessageBox.Show("Geben Sie bitte eine Zahl ein.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}