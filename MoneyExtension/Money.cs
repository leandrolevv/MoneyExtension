namespace MoneyExtension;
public static class Money
{
    public static int ToCents(this decimal amount){
        if (amount == 0)
            return 0;
        
        var valor = amount.ToString("N2").Replace(".", "").Replace(",", "");
        if(string.IsNullOrEmpty(valor))
            return 0;

        int.TryParse(valor, out var result);
        return result;
    }
}
