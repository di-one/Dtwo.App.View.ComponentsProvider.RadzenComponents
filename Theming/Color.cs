using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Theming
{
    public static class Color
    {
        public static API.View.Components.Theming.EColor RadzenButtonStyleToDtwoColor(Radzen.ButtonStyle buttonStyle)
        {
            switch (buttonStyle)
            {
                case Radzen.ButtonStyle.Primary:
                    return API.View.Components.Theming.EColor.Primary;
                    case Radzen.ButtonStyle.Secondary:
                    return API.View.Components.Theming.EColor.Secondary;
                    case Radzen.ButtonStyle.Success:
                    return API.View.Components.Theming.EColor.Success;
                    case Radzen.ButtonStyle.Info:
                    return API.View.Components.Theming.EColor.Info;
                    case Radzen.ButtonStyle.Warning:
                    return API.View.Components.Theming.EColor.Warning;
                    case Radzen.ButtonStyle.Danger:
                    return API.View.Components.Theming.EColor.Danger;
                    case Radzen.ButtonStyle.Light:
                    return API.View.Components.Theming.EColor.Light;
                    case Radzen.ButtonStyle.Dark:
                    return API.View.Components.Theming.EColor.Dark;
            }

            return API.View.Components.Theming.EColor.Primary;
        }

        public static Radzen.ButtonStyle DtwoColorToRadzenButtonStyle(API.View.Components.Theming.EColor color)
        {
            switch(color)
            {
                case API.View.Components.Theming.EColor.Primary:
                    return Radzen.ButtonStyle.Primary;
                case API.View.Components.Theming.EColor.Secondary:
                    return Radzen.ButtonStyle.Secondary;
                case API.View.Components.Theming.EColor.Success:
                    return Radzen.ButtonStyle.Success;
                case API.View.Components.Theming.EColor.Info:
                    return Radzen.ButtonStyle.Info;
                case API.View.Components.Theming.EColor.Warning:
                    return Radzen.ButtonStyle.Warning;
                case API.View.Components.Theming.EColor.Danger:
                    return Radzen.ButtonStyle.Danger;
                case API.View.Components.Theming.EColor.Light:
                    return Radzen.ButtonStyle.Light;
                case API.View.Components.Theming.EColor.Dark:
                    return Radzen.ButtonStyle.Dark;
            }

            return Radzen.ButtonStyle.Primary;
        }
    }
}
