using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Layout
{
    public class Orientation
    {
        public static Radzen.Orientation DtwoOrientationToRadzenOrientation(API.View.Components.Layout.EStackOrientation orientation)
        {
            switch (orientation)
            {
                case API.View.Components.Layout.EStackOrientation.Horizontal:
                    return Radzen.Orientation.Horizontal;
                case API.View.Components.Layout.EStackOrientation.Vertical:
                    return Radzen.Orientation.Vertical;
            }

            return Radzen.Orientation.Horizontal;
        }

        public static API.View.Components.Layout.EStackOrientation RadzenOrientationToDtwoOrientation(Radzen.Orientation orientation)
        {
            switch (orientation)
            {
                case Radzen.Orientation.Horizontal:
                    return API.View.Components.Layout.EStackOrientation.Horizontal;
                case Radzen.Orientation.Vertical:
                    return API.View.Components.Layout.EStackOrientation.Vertical;
            }

            return API.View.Components.Layout.EStackOrientation.Horizontal;
        }
    }
}
