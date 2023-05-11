using Prueba_Maui.Clases;

namespace Prueba_Maui.Views;
public partial class MainContactos : ContentPage
{
	private List<Contacto> _listaDeContactos = new List<Contacto>();
	private int Contador = 0;
	public MainContactos()
	{
		InitializeComponent();

		for(int i=0; i<12; i++)
		{
			_listaDeContactos.Add(new Contacto());
		}
		CollectionViewContactos.ItemsSource = _listaDeContactos;
	}

    private void btnAgregarContacto_Clicked(object sender, EventArgs e)
    {
		Contador++;
		btnAgregarContacto.Text = $"{Contador}";
    }

    private void CollectionViewContactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AgregarEditarContacto));
    }
}