using Dtwo.API.View.Components;
using Microsoft.Extensions.DependencyInjection;
using Radzen;
using System.Diagnostics;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents
{
    public class RadzenComponentsSettings : ComponentsProviderSettings
    {
        private List<string> m_styles = new List<string>
        {
            "themes/Dtwo.App.View.ComponentsProvider.RadzenComponents/css/material3-dark.css",
            "themes/Dtwo.App.View.ComponentsProvider.RadzenComponents/css/style.css",
        };
        public override List<string> Styles => m_styles;


        private List<string> m_scripts = new List<string>
        {
            "themes/Dtwo.App.View.ComponentsProvider.RadzenComponents/Radzen.Blazor/Radzen.Blazor.js"
        };
        public override List<string> Scripts => m_scripts;


        public override void Init(IServiceCollection service)
        {
            service.AddRadzenComponents();
        }
    }
}
