using MauiMultiLangDemo.Resources.Strings;
using System.Globalization;

namespace MauiMultiLangDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        AppResources.Culture = new CultureInfo("ar");

    }
}
