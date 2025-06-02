public static class RfcValidator
{
    public static bool IsValid(string rfc)
    {
        if (string.IsNullOrWhiteSpace(rfc)) return false;
        rfc = rfc.Trim().ToUpper();
        var regex = new System.Text.RegularExpressions.Regex(@"^[A-Z]{4}\d{6}[A-Z0-9]{3}$");
        return regex.IsMatch(rfc);
    }
}