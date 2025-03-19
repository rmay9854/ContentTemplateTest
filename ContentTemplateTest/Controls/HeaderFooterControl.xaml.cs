namespace ContentTemplateTest.Controls;

public partial class HeaderFooterControl : ContentPage
{
	public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create(nameof(HeaderText), typeof(string), typeof(HeaderFooterControl), default(string));

	public string HeaderText
	{
		get => (string)GetValue(HeaderTextProperty);
		set => SetValue(HeaderTextProperty, value);
	}

	public HeaderFooterControl()
	{
		InitializeComponent();
	}
}