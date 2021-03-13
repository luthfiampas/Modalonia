using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Modalonia.Example
{
    public class MainWindow : Window
    {
        private readonly TextBlock _modalContent = new TextBlock
        {
            TextWrapping = TextWrapping.Wrap,
            Text = "Lorem ipsum dolor si amet orem ipsum dolor si amet orem ipsum dolor si amet orem ipsum dolor si amet"
        };

        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);

#if DEBUG
            this.AttachDevTools();
#endif
            
            this.FindControl<Button>("button").Click += Button_Click;
        }

        private async void Button_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var result = await Modal.Show("Do you want to continue?", _modalContent, ModalButtons.YesNo);
            this.FindControl<TextBlock>("result").Text = $"Modal Result: {result}";
        }
    }
}
