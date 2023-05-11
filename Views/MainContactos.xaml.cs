using Prueba_Maui.Clases;

namespace Prueba_Maui.Views;
public partial class MainContactos : ContentPage
{
	private List<Contacto> _listaDeContactos = new List<Contacto>();
	private int Contador = 0;
	public MainContactos()
	{
		InitializeComponent();

		for(int i=0; i<10; i++)
		{
			_listaDeContactos.Add(new Contacto());
		}

		CollectionViewDataContactos.ItemsSource = _listaDeContactos;
	}

    private void btnPija_Clicked(object sender, EventArgs e)
    {
		Contador++;
		btnPija.Text = $"Has Probado: {Contador} Pijas";
    }
}