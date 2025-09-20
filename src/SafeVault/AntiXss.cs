
using System.Text.Encodings.Web;

namespace SafeVault;

public static class AntiXss
{
    public static string Encode(string? s) => s is null ? string.Empty : HtmlEncoder.Default.Encode(s);
}
