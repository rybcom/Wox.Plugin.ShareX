using System.Diagnostics;

namespace Wox.Plugin.ShareX
{
    internal static class MakeCommand
    {
        private static void RunShareXCommandLine(string argument)
        {
            Process process = new Process();
            process.StartInfo.FileName = Paths.ShareXAppPath;
            process.StartInfo.Arguments = "-" + argument;
            process.Start();
        }

        internal static Result CaptureRegionScreenshot()
        {
            return new Result
            {
                Title = "capture region",
                SubTitle = "screenshot",
                Score = 50,
                IcoPath = "Images\\region-screenshot.png",
                Action = e =>
                {
                    RunShareXCommandLine("RectangleRegion");
                    return true;
                }
            };
        }

        internal static Result ShowColorPicker()
        {
            return new Result
            {
                Title = "color picker",
                SubTitle = "color picker",
                Score = 50,
                IcoPath = "Images\\color-picker.png",
                Action = e =>
                {
                    RunShareXCommandLine("ColorPicker");
                    return true;
                }
            };
        }

        internal static Result ShowScreenColorPicker()
        {
            return new Result
            {
                Title = "screen color picker",
                SubTitle = "color picker",
                Score = 50,
                IcoPath = "Images\\screen-color-picker.png",
                Action = e =>
                {
                    RunShareXCommandLine("ScreenColorPicker");
                    return true;
                }
            };
        }

        internal static Result ShowRuler()
        {
            return new Result
            {
                Title = "ruler",
                SubTitle = "ruler tool",
                Score = 50,
                IcoPath = "Images\\ruler.png",
                Action = e =>
                {
                    RunShareXCommandLine("Ruler");
                    return true;
                }
            };
        }

    }
}
