using System.Web.UI.WebControls;

namespace CsharpLibrary.ExtensionMethods
{
    public static class RepeaterItemEventArgsExtensions
    {
        public static bool IsListItem(this RepeaterItemEventArgs repeaterItemEventArgs)
        {
            return repeaterItemEventArgs.Item.ItemType == ListItemType.Item || repeaterItemEventArgs.Item.ItemType == ListItemType.AlternatingItem;
        }
    }
}
