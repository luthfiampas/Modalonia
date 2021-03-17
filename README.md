# Modalonia
[![NuGet Count](https://img.shields.io/nuget/dt/Modalonia.svg?style=flat-square)](https://www.nuget.org/packages/Modalonia/)  
A simple modal for [Avalonia](https://github.com/AvaloniaUI/Avalonia).  
![Modalonia](https://i.ibb.co/Vjn6HF8/modalonia.gif "Modalonia")

## Usage
```csharp
// you can attach any control as a modal's content..
var content = new TextBlock
{
   TextWrapping = TextWrapping.Wrap,
   Text = "Lorem ipsum dolor si amet"
};

var result = await Modal.Show("Modal Title", content, ModalButtons.YesNo);
if (result == ModalResult.Yes)
{
   // do something..
}
```

## Styling
Add default Modalonia styles to App.xaml.
```xaml
<Application.Styles>
   <StyleInclude Source="avares://Modalonia/Styles/Default.xaml"/>
</Application.Styles>
```

### Style selectors
- Grid.modalonia_container
- Border.modalonia_border
- ContentControl.modalonia_header
- TextBlock.modalonia_header_title
- Button.modalonia_header_close
- ContentControl.modalonia_content
- ContentControl.modalonia_buttons_container
- StackPanel.modalonia_buttons
- Button.modalonia_button
- Button.modalonia_button_yes
- Button.modalonia_button_no
- Button.modalonia_button_ok
- Button.modalonia_button_cancel

## License
[MIT License](https://github.com/luthfiampas/Modalonia/blob/master/LICENSE)