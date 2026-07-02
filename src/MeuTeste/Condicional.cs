public class Condicional
{
    public static string VerificarNumero(int x)
    {
        if (x > 0)
            return $"{x} é um número posistivo";
        else
            return $"{x} não é um número posistivo";
    }
}