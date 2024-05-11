using Dtwo.API.View.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Forms
{
    public static class Button
    {
        public static Radzen.ButtonSize DtwoButtonSizeToRadzenButtonSize(EButtonSize buttonSize)
        {
            switch (buttonSize)
            {
                case EButtonSize.Small:
                    return Radzen.ButtonSize.Small;
                case EButtonSize.Medium:
                    return Radzen.ButtonSize.Medium;
                case EButtonSize.Large:
                    return Radzen.ButtonSize.Large;
                default:
                    return Radzen.ButtonSize.Medium;
            }
        }
    }
}
