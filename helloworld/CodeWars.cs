public static class Kata
{
    // return masked string
    public static string Maskify(string cc)
    {
        if (cc.Length <= 4)
        {
            return cc;
        }
        else if (cc.Length > 4)
        {
            int firstHalfCount = cc.Length - 4;
            var lastFour = cc.Substring(firstHalfCount);
            var crypted = new string('#', firstHalfCount);
            var full = crypted + lastFour;
            return full;
        }
        return "";
    }
}
