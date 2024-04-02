public static class Validacao
{

    public static bool ValidaCPF(string cpf)
    {
        if (string.IsNullOrEmpty(cpf))
        {
            return false;
        }

        cpf = cpf.Replace("-", "");
        cpf = cpf.Replace(".", "");

        if (cpf.Length != 11)
        {
            return false;
        }

        var numero = cpf[..9];
        Console.WriteLine(numero);
        var digitos = cpf[^2..];

        var pesoValidacao = new uint[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        uint soma = 0;

        for (var i = 0; i < pesoValidacao.Length; i++)
        {
            soma += (numero[i] * pesoValidacao[i]);
        }

        (string d1, string d2) digitosValidos;

        var resto = soma % 11;

        if (resto < 2)
        {
            digitosValidos.d1 = "0";
        }
        else
        {
            digitosValidos.d1 = (11 - resto).ToString();
        }

        Console.WriteLine(digitosValidos.d1);
        Console.WriteLine(digitos[1].ToString());
        if (digitosValidos.d1 != digitos[1].ToString())
        {
            return false;
        }

        Console.WriteLine("bbb");
        var pesoValidacaoSegundo = new uint[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        soma = 0;

        for (var i = 0; i < pesoValidacaoSegundo.Length; i++)
        {
            soma += (numero[i] * pesoValidacaoSegundo[i]);
        }

        resto = soma % 11;

        if (resto < 2)
        {
            digitosValidos.d2 = "0";
        }
        else
        {
            digitosValidos.d2 = (11 - resto).ToString();
        }

        Console.WriteLine(digitosValidos.d1 + digitosValidos.d2);
        if (digitos != (digitosValidos.d1 + digitosValidos.d2))
        {
            return false;
        }


        return true;
    }
}
