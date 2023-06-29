namespace Navegacion;

///<Summary>
///<Createddate> 2022/06/29 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/29 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el dise�o y se configur� el c�digo cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Costo.Text) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            double articulo, dinero, vuelto;
            articulo = Convert.ToDouble(Costo.Text);
            dinero = Convert.ToDouble(Cantidad.Text);
            vuelto = dinero - articulo;
            Cambio1.Text = Convert.ToString(vuelto);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            Cambio1.Text = "";
        }
    }
}