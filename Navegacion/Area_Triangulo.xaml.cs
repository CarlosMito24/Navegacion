namespace Navegacion;

///<Summary>
///<Createddate> 2022/06/27 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/27 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class Area_Triangulo : ContentPage
{
	public Area_Triangulo()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Base.Text))
        {
            double h, b, area;
            h = Convert.ToDouble(Altura.Text);
            b = Convert.ToDouble(Base.Text);
            area = (h * b) / 2;
            Área.Text = Convert.ToString(area);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            Área.Text = "";
        }
    }
}