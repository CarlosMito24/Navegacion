namespace Navegacion;

///<Summary>
///<Createddate> 2022/06/29 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/29 </lastmodificationdate>
///<lastmodificationdescription>
/// Se configuró este archivo para que los botones puedan abrir las demás apps
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void CambioClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new Cambio());
	}

    private void TrianguloClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Area_Triangulo());
    }

    private void DinosaurioClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Peso_Dinosaurio());
    }

    private void GasolineraClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gasolinera());
    }

    private void AcercaClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acerca());
    }
}