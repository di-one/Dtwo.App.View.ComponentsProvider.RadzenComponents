using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Theming
{
    public static class Variant
    {
        public static Radzen.Variant DtwoVariantToRadzenVariant(API.View.Components.Theming.EVariant variant)
        {
            switch (variant)
            {
                case API.View.Components.Theming.EVariant.Outline:
                    return Radzen.Variant.Outlined;
                case API.View.Components.Theming.EVariant.Flat:
                    return Radzen.Variant.Flat;
                case API.View.Components.Theming.EVariant.Filled:
                    return Radzen.Variant.Filled;
            }

            return Radzen.Variant.Flat;
        }
    }
}
