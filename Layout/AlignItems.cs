using Dtwo.API.View.Components.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Layout
{
    public static class AlignItems
    {
        public static Radzen.AlignItems DtwoAlignItemsToRadzenAlignItems(EAlignItems alignItems)
        {
            Radzen.AlignItems radzenAlignItems = Radzen.AlignItems.Normal;

            switch(alignItems)
            {
                case EAlignItems.Center:
                    radzenAlignItems = Radzen.AlignItems.Center;
                    break;
                case EAlignItems.Normal:
                    radzenAlignItems = Radzen.AlignItems.Normal;
                    break;
                case EAlignItems.Start:
                    radzenAlignItems = Radzen.AlignItems.Start;
                    break;
                case EAlignItems.End:
                    radzenAlignItems = Radzen.AlignItems.End;
                    break;
                    case EAlignItems.Stretch:
                    radzenAlignItems = Radzen.AlignItems.Stretch;
                    break;
            }

            return radzenAlignItems;

        }
    }
}
