using System.Reflection.Metadata;
using System;

namespace AppAlcohol.Domain
{
    public class controllers: IopeSegPub
    {
        private string _bebida;
        private int _cantidad;
        private double _peso;
        private double _resultado;

        public double calcular(string bebida, int cantidad, double peso)
        {
            _bebida = bebida;
            _cantidad = cantidad;
            _peso = peso;
            int gradoEth=0;
            double Eth_consumido=0.0;
            double Eth_en_sangre_persona=0.0;
            double Factor_Eth=0.15;
            double masa=0.0;
            double dencidadEth= 0.789;
            double FactorvolumenSangre=0.08;
            double volumen_sangre_Persona=0.0;
            double Alcoholemia=0.0;


            switch (bebida)
            {
                case "CERVEZA":
                gradoEth = 5;
                break;
                case "VINO":
                gradoEth = 12;
                break;
                case "VERMU":
                gradoEth = 23;
                break;
                case "BRANDY":
                case "COMBINADO":
                gradoEth = 38;
                break;

            }


                Eth_consumido = (gradoEth /100) * double.Parse(_cantidad.ToString());
                Console.WriteLine(Eth_consumido);
                
                Eth_en_sangre_persona=(Factor_Eth*Eth_consumido);
                
                
                masa= dencidadEth * Eth_en_sangre_persona;
            
                volumen_sangre_Persona=FactorvolumenSangre*_peso;

                Alcoholemia= masa/volumen_sangre_Persona;
                return Alcoholemia;

            



        }

    }
}