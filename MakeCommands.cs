using System.Diagnostics;

namespace Wox.Plugin.ShareX
{
    internal static class MakeCommand
    {
        #region api
        
        internal static Result CaptureRegionScreenshot()
        {
            return new Result
            {
                Title = "capture custom region",
                SubTitle = "screenshot",
                Score = 50,
                IcoPath = "Images\\screenshot.png",
                Action = e =>
                {
                    RunShareXCommandLine(ActionType.RectangleRegion);
                    return true;
                }
            };
        }

        internal static Result CaptureActiveWindowScreenshot()
        {
            return new Result
            {
                Title = "capture active window",
                SubTitle = "screenshot",
                Score = 50,
                IcoPath = "Images\\screenshot.png",
                Action = e =>
                {
                    RunShareXCommandLine(ActionType.ActiveWindow);
                    return true;
                }
            };
        }
        
        internal static Result CaptureGIF_CustomRegion()
        {
            return new Result
            {
                Title = "capture gif - custom region",
                SubTitle = "capture gif",
                Score = 50,
                IcoPath = "Images\\record.png",
                Action = e =>
                {
                    RunShareXCommandLine(ActionType.ScreenRecorderGIFCustomRegion);
                    return true;
                }
            };
        }

        internal static Result CaptureGIF_ActiveWindow()
        {
            return new Result
            {
                Title = "capture gif - active window",
                SubTitle = "capture gif ",
                Score = 50,
                IcoPath = "Images\\record.png",
                Action = e =>
                {
                    RunShareXCommandLine(ActionType.ScreenRecorderGIFActiveWindow);
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
                    RunShareXCommandLine(ActionType.ColorPicker);
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
                    RunShareXCommandLine(ActionType.ScreenColorPicker);
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
                    RunShareXCommandLine(ActionType.Ruler);
                    return true;
                }
            };
        }

        #endregion
        
        #region private

        private enum ActionType
        {
            None,
            // Upload
            FileUpload,
            FolderUpload,
            ClipboardUpload,
            ClipboardUploadWithContentViewer,
            UploadText,
            UploadURL,
            DragDropUpload,
            ShortenURL,
            TweetMessage,
            StopUploads,
            // Screen capture
            PrintScreen,
            ActiveWindow,
            ActiveMonitor,
            RectangleRegion,
            RectangleLight,
            RectangleTransparent,
            CustomRegion,
            LastRegion,
            ScrollingCapture,
            AutoCapture,
            StartAutoCapture,
            // Screen record
            ScreenRecorder,
            ScreenRecorderActiveWindow,
            ScreenRecorderCustomRegion,
            StartScreenRecorder,
            ScreenRecorderGIF,
            ScreenRecorderGIFActiveWindow,
            ScreenRecorderGIFCustomRegion,
            StartScreenRecorderGIF,
            StopScreenRecording,
            AbortScreenRecording,
            // Tools
            ColorPicker,
            ScreenColorPicker,
            Ruler,
            ImageEditor,
            ImageEffects,
            ImageViewer,
            ImageCombiner,
            ImageSplitter,
            ImageThumbnailer,
            VideoConverter,
            VideoThumbnailer,
            OCR,
            QRCode,
            QRCodeDecodeFromScreen,
            HashCheck,
            IndexFolder,
            ClipboardViewer,
            BorderlessWindow,
            InspectWindow,
            MonitorTest,
            DNSChanger,
            // Other
            DisableHotkeys,
            OpenMainWindow,
            OpenScreenshotsFolder,
            OpenHistory,
            OpenImageHistory,
            ToggleActionsToolbar,
            ToggleTrayMenu,
            ExitShareX
        }
        
        private static void RunShareXCommandLine(ActionType option)
        {
            Process process = new Process();
            process.StartInfo.FileName = Paths.ShareXAppPath;
            process.StartInfo.Arguments = "-" + option.ToString();
            process.Start();
        }

        #endregion
    }
}
