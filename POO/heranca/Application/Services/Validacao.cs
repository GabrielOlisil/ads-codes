public static class Validacao
{

    private static string ChecarDigitoCpf(string cpf, int[] peso)
    {
        int soma = 0;

        for (int i = 0; i < peso.Length; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * peso[i];
        }

        var resto = soma % 11;

        if (resto < 2)
        {
            return "0";
        }
        return (11 - resto).ToString();
    }

    private static string ValidaFormatoCpf(string cpf)
    {
        cpf = cpf.Replace("-", "");
        cpf = cpf.Replace(".", "");

        if (cpf.Length != 11)
        {
            return string.Empty;
        }
        return cpf;
    }


    public static bool ValidaCPF(string cpf)
    {
        cpf = ValidaFormatoCpf(cpf);
        if (string.IsNullOrEmpty(cpf))
        {
            return false;
        }

        var numero = cpf.Substring(0, 9);
        var digitos = cpf.Substring(9, 2);

        (string d1, string d2) digitosValidos;

        digitosValidos.d1 = ChecarDigitoCpf(numero, new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 });

        if (digitosValidos.d1 != digitos[0].ToString())
        {
            return false;
        }

        numero = numero + digitosValidos.d1;
        var pesoValidacaoSegundo = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        digitosValidos.d2 = ChecarDigitoCpf(numero, pesoValidacaoSegundo);

        if (digitos[1].ToString() != digitosValidos.d2)
        {
            return false;
        }

        return true;
    }

    // Validar niv
    public static bool ValidarNiv(string niv)
    {

        niv = niv.Replace(".", "");

        if (niv.Length != 17)
        {
            return false;
        }

        if (niv.Any(n => "OIQ".Contains(n.ToString().ToUpper()))) return false;


        if (niv[^4..].Any(n => !char.IsNumber(n)))
        {
            return false;
        }

        return true;


    }

}
