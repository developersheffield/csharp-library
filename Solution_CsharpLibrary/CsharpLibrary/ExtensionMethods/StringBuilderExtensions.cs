using System.Text;

namespace CsharpLibrary.ExtensionMethods
{
    public static class StringBuilderExtensions
    {
        public static void AppendLineFormat(this StringBuilder stringBuilder, string format, params object[] args)
        {
            stringBuilder.AppendFormat(format, args);
            stringBuilder.AppendLine();
        }
    }
}
