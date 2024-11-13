using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    private int taskCounter = 1;


    public MainWindow()
    {
        InitializeComponent();

        InputTextBox = this.FindControl<TextBox>("InputTextBox");
        ResultStackPanel = this.FindControl<StackPanel>("ResultStackPanel");
    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(InputTextBox.Text))
        {
            var taskContainer = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Spacing = 10 
            };


            var newTextBlock = new TextBlock
            {
                Text = $"Zadanie {taskCounter}: {InputTextBox.Text}",
                VerticalAlignment = VerticalAlignment.Center
            };
            
            var taskCheckBox = new CheckBox
            {
                VerticalAlignment = VerticalAlignment.Center
            };
            
            taskContainer.Children.Add(newTextBlock);
            taskContainer.Children.Add(taskCheckBox);

            
            ResultStackPanel.Children.Add(taskContainer);
            
            taskCounter++;

            InputTextBox.Clear();
        }
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {

        ResultStackPanel.Children.Clear();


        InputTextBox.Clear();
        
        taskCounter = 1;
    }
}
    