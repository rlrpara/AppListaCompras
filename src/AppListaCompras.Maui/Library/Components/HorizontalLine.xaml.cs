using BindableProps;
using System.Runtime.CompilerServices;

namespace AppListaCompras.Maui.Library.Components;

public partial class HorizontalLine : ContentView
{
    [BindableProp]
    private Color _stroke;
	public HorizontalLine()
	{
		InitializeComponent();
	}

    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if(Window != null && Window?.Width != 0 && linha != null)
        {
            linha.X2 = Window.Width;
        }

        if(linha != null && propertyName == "Stroke")
        {
            linha.Stroke = Stroke;
        }
    }
}