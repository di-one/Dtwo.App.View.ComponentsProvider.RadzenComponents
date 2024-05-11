using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.App.View.ComponentsProvider.RadzenComponents.Feedback
{
    public static class ProgressBar
    {
        public static Radzen.ProgressBarCircularSize DtwoCircularSizeToRadzenCircularSize(Dtwo.API.View.Components.Feedback.ECircularProgressBarSize circularSize)
        {
            switch (circularSize)
            {
                case Dtwo.API.View.Components.Feedback.ECircularProgressBarSize.Small:
                    return Radzen.ProgressBarCircularSize.Small;
                case Dtwo.API.View.Components.Feedback.ECircularProgressBarSize.Medium:
                    return Radzen.ProgressBarCircularSize.Medium;
                case Dtwo.API.View.Components.Feedback.ECircularProgressBarSize.Large:
                    return Radzen.ProgressBarCircularSize.Large;
                default:
                    return Radzen.ProgressBarCircularSize.Medium;
            }
        }

        public static Radzen.ProgressBarMode DtwoProgressBarModeToRadzenProgressBarMode(Dtwo.API.View.Components.Feedback.EProgressBarMode progressBarMode)
        {
            switch (progressBarMode)
            {
                case Dtwo.API.View.Components.Feedback.EProgressBarMode.Determinate:
                    return Radzen.ProgressBarMode.Determinate;
                case Dtwo.API.View.Components.Feedback.EProgressBarMode.Indeterminate:
                    return Radzen.ProgressBarMode.Indeterminate;
                default:
                    return Radzen.ProgressBarMode.Determinate;
            }
        }

        public static Radzen.ProgressBarStyle DtwoProgressBarStyleToRadzenProgressBarStyle(Dtwo.API.View.Components.Feedback.EProgressBarStyle progressBarStyle)
        {
            switch (progressBarStyle)
            {
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Primary:
                    return Radzen.ProgressBarStyle.Primary;
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Secondary:
                    return Radzen.ProgressBarStyle.Secondary;
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Success:
                    return Radzen.ProgressBarStyle.Success;
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Danger:
                    return Radzen.ProgressBarStyle.Danger;
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Warning:
                    return Radzen.ProgressBarStyle.Warning;
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Info:
                    return Radzen.ProgressBarStyle.Info;
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Light:
                    return Radzen.ProgressBarStyle.Light;
                case Dtwo.API.View.Components.Feedback.EProgressBarStyle.Dark:
                    return Radzen.ProgressBarStyle.Dark;
                default:
                    return Radzen.ProgressBarStyle.Primary;
            }
        }
    }
}
