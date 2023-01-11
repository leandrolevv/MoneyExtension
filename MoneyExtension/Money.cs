namespace MoneyExtension;
public static class Money
{
    public static int ToCents(this double amount){
        if (amount == 0)
            return 0;
        
        var valor = amount.ToString("N2").Replace(".", "").Replace(",", "");
        int.TryParse(valor, out var result);
        return result;
    }
}
