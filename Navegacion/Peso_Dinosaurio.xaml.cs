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

public partial class Peso_Dinosaurio : ContentPage
{
	public Peso_Dinosaurio()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Nombre.Text) && !string.IsNullOrEmpty(PesoKG.Text) && !string.IsNullOrEmpty(AlturaM.Text))
        {
            string nombredinosaurio;
            double pesoenkilogramos, pesoenlibras, alturaenmetros, alturaencentimetros;
            nombredinosaurio = Convert.ToString(Nombre.Text);
            pesoenkilogramos = Convert.ToDouble(PesoKG.Text);
            alturaenmetros = Convert.ToDouble(AlturaM.Text);
            pesoenlibras = pesoenkilogramos * 2.20462;
            alturaencentimetros = alturaenmetros * 100;
            Label1.Text = Convert.ToString("El peso en libras del " + nombredinosaurio + " es:");
            Label2.Text = Convert.ToString("La altura en cent�metros del " + nombredinosaurio + " es:");
            PesoL.Text = Convert.ToString(pesoenlibras);
            AlturaCM.Text = Convert.ToString(alturaencentimetros);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            Label1.Text = "El peso en libras del... es:";
            Label2.Text = "La altura en cent�metros del... es:";
            PesoL.Text = "";
            AlturaCM.Text = "";
        }
    }
}