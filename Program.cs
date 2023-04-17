Console.WriteLine(UtilDate.HoraAtual());

static class UtilDate
{
    public static string HoraAtual()
    {
        return DateTime.Now.Hour.ToString();
    }
}
