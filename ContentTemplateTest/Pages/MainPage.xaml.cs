﻿using ContentTemplateTest.Controls;

namespace ContentTemplateTest.Pages;
public partial class MainPage : HeaderFooterControl
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		// count++;

		// if (count == 1)
		// 	CounterBtn.Text = $"Clicked {count} time";
		// else
		// 	CounterBtn.Text = $"Clicked {count} times";

		// SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

