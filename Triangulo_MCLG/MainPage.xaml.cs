using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo_MCLG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Lado1.Text) && !string.IsNullOrEmpty(Lado2.Text) && !string.IsNullOrEmpty(Base.Text) && !string.IsNullOrEmpty(Altura.Text))
            {
                //variables de lados del trinagulo
                var lado1 = float.Parse(Lado1.Text);
                var lado2 = float.Parse(Lado2.Text);
                var baseTriangulo = float.Parse(Base.Text);
                string esTrinagulo = "No es un triangulo";

                //saber si es un traingulo
                if (lado1 + lado2 < baseTriangulo || baseTriangulo + lado1 < lado2 || baseTriangulo + lado2 < lado1)
                {
                    DisplayAlert("Resultado: ", esTrinagulo, "Quitar");
                }
                else
                {
                    //declarar variables
                    var alturaTriangulo = float.Parse(Altura.Text);


                    //calcular area del triangulo
                    var areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

                    AreaTriangulo.Text = areaTriangulo.ToString();

                    //consiciones para tipo de triangulo
                    string tipoTriangulo = " ";

                    if (lado1 == baseTriangulo && lado2 == baseTriangulo)
                    {
                        tipoTriangulo = "Equilatero";
                        imgEquilatero.IsVisible = true;
                     
                        imgEscaleno.IsVisible = false;
                        imgIsosceles.IsVisible = false;
                    }
                    else if (lado1 == baseTriangulo || lado2 == baseTriangulo || lado1 == lado2)
                    {
                        tipoTriangulo = "Isosceles";
                        imgEquilatero.IsVisible = false;
                        imgEscaleno.IsVisible = false;
                        imgIsosceles.IsVisible = true;
                    }
                    else 
                    {
                        tipoTriangulo = "Escaleno";
                        
                        imgEscaleno.IsVisible = true;
                        imgEquilatero.IsVisible = false;
                       
                        imgIsosceles.IsVisible = false;
                    }
                    TipoTriangulo.Text = tipoTriangulo.ToString();
                }


                /*
                if (lado1 + lado2 < baseTriangulo)
                {
                    DisplayAlert("Resultado: ", esTrinagulo, "Quitar");
                }
                else if (baseTriangulo + lado1 < lado2)
                {
                    DisplayAlert("Resultado: ", esTrinagulo, "Quitar");
                }
                else if(baseTriangulo+lado2 < lado1)
                {
                    DisplayAlert("Resultado: ", esTrinagulo, "Quitar");
                }
                else
                {
                    //declarar variables
                    var alturaTriangulo = float.Parse(Altura.Text);


                    //calcular area del triangulo
                    var areaTriangulo = (baseTriangulo*alturaTriangulo)/2;

                    AreaTriangulo.Text = areaTriangulo.ToString();

                    //consiciones para tipo de triangulo
                    string tipoTriangulo = " ";

                    if (lado1 == baseTriangulo && lado2==baseTriangulo)
                    {
                        tipoTriangulo = "Equilatero";
                    }
                    else if(lado1 == baseTriangulo || lado2 == baseTriangulo || lado1 ==lado2)
                    {
                        tipoTriangulo = "Isosceles";
                    }
                    else
                    {
                        tipoTriangulo = "Escaleno";
                    }
                    TipoTriangulo.Text = tipoTriangulo.ToString();
                }


                */
            }
            else
            {
                DisplayAlert("datos erroneos", "por favor, llena la información", "Quitar");
            }






        }
    }
}
