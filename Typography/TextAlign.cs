using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Typography
{
    public static class TextAlign
    {
        public static Radzen.TextAlign DtwoTextAlignToRadzenTextAlign(Dtwo.API.View.Components.Typography.ETextAlign textAlign)
        {
            return textAlign switch
            {
                API.View.Components.Typography.ETextAlign.Center => Radzen.TextAlign.Center,
                API.View.Components.Typography.ETextAlign.Justify => Radzen.TextAlign.Justify,
                API.View.Components.Typography.ETextAlign.Left => Radzen.TextAlign.Left,
                API.View.Components.Typography.ETextAlign.Right => Radzen.TextAlign.Right,
                API.View.Components.Typography.ETextAlign.End => Radzen.TextAlign.End,
                _ => throw new NotImplementedException()
            };
        }
    }
}
