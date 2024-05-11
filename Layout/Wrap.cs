using Dtwo.API.View.Components.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Layout
{
    public static class Wrap
    {
        public static Radzen.FlexWrap DtwoWrapToRadzenWrap(EWrap wrap)
        {
            return wrap switch
            {
                EWrap.NoWrap => Radzen.FlexWrap.NoWrap,
                EWrap.Wrap => Radzen.FlexWrap.Wrap,
                EWrap.WrapReverse => Radzen.FlexWrap.WrapReverse,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
