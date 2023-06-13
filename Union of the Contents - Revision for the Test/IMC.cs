using System;

class IMC
{
    private double alt;
    private double peso;

    public IMC(double alt, double peso)
    {
        this.alt = alt;
        this.peso = peso;
    }


    public (double, string, string) Imc()
    {
        string grau;
        string classificacao;
        double imc = peso / (alt * alt);
        if (imc < 18.5)
        {
            classificacao = "Magreza";
            grau = "0";
        }
        else if (18.5 >= imc && imc < 25)
        {
            classificacao = "Normal";
            grau = "0";
        }

        else if (25 >= imc && imc < 30)
        {
            classificacao = "SobrePeso";
            grau = "I";
        }
        else if (30 >= imc && imc < 40)
        {
            classificacao = "Obesidade";
            grau = "II";
        }
        else
        {
            classificacao = "Obesidade Grave";
            grau = "III";
        }
        return (imc, classificacao, grau);
    }
}