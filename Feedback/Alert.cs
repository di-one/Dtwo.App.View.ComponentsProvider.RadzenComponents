using Dtwo.API.View.Components.Feedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Feedback
{
    public static class Alert
    {
        public static EAlertStyle RadzenAlertStyleToDtwoAlertStyle(Radzen.AlertStyle alertType)
        {
            switch (alertType)
            {
                case Radzen.AlertStyle.Success:
                    return EAlertStyle.Success;
                case Radzen.AlertStyle.Info:
                    return EAlertStyle.Info;
                case Radzen.AlertStyle.Warning:
                    return EAlertStyle.Warning;
                case Radzen.AlertStyle.Danger:
                    return EAlertStyle.Danger;
            }

            return EAlertStyle.Info;
        }

        public static Radzen.AlertStyle DtwoAlertStyleToRadzenAlertStyle(EAlertStyle alertType)
        {
            switch (alertType)
            {
                case EAlertStyle.Success:
                    return Radzen.AlertStyle.Success;
                case EAlertStyle.Info:
                    return Radzen.AlertStyle.Info;
                case EAlertStyle.Warning:
                    return Radzen.AlertStyle.Warning;
                case EAlertStyle.Danger:
                    return Radzen.AlertStyle.Danger;
            }

            return Radzen.AlertStyle.Info;
        }
    }
}
