namespace Navegacion;

///<Summary>
///<Createddate> 2022/06/29 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/29 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class Gasolinera : ContentPage
{
	public Gasolinera()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(PreciLitro.Text) && !string.IsNullOrEmpty(Galones.Text))
        {
            string resultado;
            double precioporlitro, cantidaddegalones, total;
            precioporlitro = Convert.ToDouble(PreciLitro.Text);
            cantidaddegalones = Convert.ToDouble(Galones.Text);
            total = (precioporlitro * 3.785) * cantidaddegalones;
            resultado = total.ToString("0.00");
            Total.Text = Convert.ToString(resultado);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            Total.Text = "";
        }
    }
}