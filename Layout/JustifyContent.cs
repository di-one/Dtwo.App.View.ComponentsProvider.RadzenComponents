using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Layout
{
    public static class JustifyContent
    {
        public static Radzen.JustifyContent DtwoJustifyContentToRadzenJustifyContent(API.View.Components.Layout.EJustifyContent justifyContent)
        {
            Radzen.JustifyContent radzenJustifyContent = Radzen.JustifyContent.Normal;

            switch(justifyContent)
            {
                case API.View.Components.Layout.EJustifyContent.Start:
                        radzenJustifyContent = Radzen.JustifyContent.Start;
                    break;
                    case API.View.Components.Layout.EJustifyContent.End:
                        radzenJustifyContent = Radzen.JustifyContent.End;
                    break;
                    case API.View.Components.Layout.EJustifyContent.Center:
                        radzenJustifyContent = Radzen.JustifyContent.Center;
                    break;
                    case API.View.Components.Layout.EJustifyContent.SpaceBetween:
                        radzenJustifyContent = Radzen.JustifyContent.SpaceBetween;
                    break;
                    case API.View.Components.Layout.EJustifyContent.SpaceAround:
                        radzenJustifyContent = Radzen.JustifyContent.SpaceAround;
                    break;
                    case API.View.Components.Layout.EJustifyContent.SpaceEvenly:
                        radzenJustifyContent = Radzen.JustifyContent.SpaceEvenly;
                    break;
                    case API.View.Components.Layout.EJustifyContent.Stretch:
                        radzenJustifyContent = Radzen.JustifyContent.Stretch;
                    break;
                    case API.View.Components.Layout.EJustifyContent.Right:
                        radzenJustifyContent = Radzen.JustifyContent.Right;
                    break;
                    case API.View.Components.Layout.EJustifyContent.Left:
                        radzenJustifyContent = Radzen.JustifyContent.Left;
                    break;
                    case API.View.Components.Layout.EJustifyContent.Normal:
                        radzenJustifyContent = Radzen.JustifyContent.Normal;
                    break;
            }

            return radzenJustifyContent;
        }
    }
}
