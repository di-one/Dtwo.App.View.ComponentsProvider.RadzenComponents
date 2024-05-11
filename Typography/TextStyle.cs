using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Typography
{
    public static class TextStyle
    {
        public static Radzen.Blazor.TextStyle DtwoTextStyleToRadzenTextStyle(Dtwo.API.View.Components.Typography.ETextStyle textStyle)
        {
            return textStyle switch
            {
                API.View.Components.Typography.ETextStyle.H1 => Radzen.Blazor.TextStyle.H1,
                API.View.Components.Typography.ETextStyle.H2 => Radzen.Blazor.TextStyle.H2,
                API.View.Components.Typography.ETextStyle.H3 => Radzen.Blazor.TextStyle.H3,
                API.View.Components.Typography.ETextStyle.H4 => Radzen.Blazor.TextStyle.H4,
                API.View.Components.Typography.ETextStyle.H5 => Radzen.Blazor.TextStyle.H5,
                API.View.Components.Typography.ETextStyle.H6 => Radzen.Blazor.TextStyle.H6,
                API.View.Components.Typography.ETextStyle.Subtitle1 => Radzen.Blazor.TextStyle.Subtitle1,
                API.View.Components.Typography.ETextStyle.Subtitle2 => Radzen.Blazor.TextStyle.Subtitle2,
                API.View.Components.Typography.ETextStyle.Body1 => Radzen.Blazor.TextStyle.Body1,
                API.View.Components.Typography.ETextStyle.Body2 => Radzen.Blazor.TextStyle.Body2,
                API.View.Components.Typography.ETextStyle.Caption => Radzen.Blazor.TextStyle.Caption,
                API.View.Components.Typography.ETextStyle.Button => Radzen.Blazor.TextStyle.Button,
                API.View.Components.Typography.ETextStyle.Overline => Radzen.Blazor.TextStyle.Overline,
                _ => throw new NotImplementedException()
            };
        }
    }
}
