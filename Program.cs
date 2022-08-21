
using System.Collections.Generic;
using mroot_lib;

namespace Wox.Plugin.ShareX
{
    static class Paths
    {
        public static string ShareXAppPath => mroot.get_enviro_var_value("sharex");
    }

    public class WoxVPNExtension : IPlugin
    {

        #region wox overrides

        public void Init(PluginInitContext context)
        {
        }

        public List<Result> Query(Query query)
        {
            List<Result> resultList = new List<Result>();

            AddScreenshots(resultList, query);
            AddGifCaptures(resultList, query);
            AddColorMixer(resultList, query);
            AddScreenColorPicker(resultList, query);
            AddRuller(resultList, query);

            return resultList;
        }

        #endregion

        #region commands

        private void AddScreenshots(List<Result> resultList, Query query)
        {
            if (StringTools.IsEqualOnStart(query.Search, "screenshot", "capture"))
            {
                resultList.Add(MakeCommand.CaptureRegionScreenshot());
                resultList.Add(MakeCommand.CaptureActiveWindowScreenshot());
            }
        }

        private void AddColorMixer(List<Result> resultList, Query query)
        {
            if (StringTools.IsEqualOnStart(query.Search, "colorpicker"))
            {
                resultList.Add(MakeCommand.ShowColorPicker());
            }
        }

        private void AddScreenColorPicker(List<Result> resultList, Query query)
        {
            if (StringTools.IsEqualOnStart(query.Search, "colorpicker-screen"))
            {
                resultList.Add(MakeCommand.ShowScreenColorPicker());
            }
        }
      
        private void AddRuller(List<Result> resultList, Query query)
        {
            if (StringTools.IsEqualOnStart(query.Search, "ruler"))
            {
                resultList.Add(MakeCommand.ShowRuler());
            }
        }

        private void AddGifCaptures(List<Result> resultList, Query query)
        {
            if (StringTools.IsEqualOnStart(query.Search, "gif","capture"))
            {
                resultList.Add(MakeCommand.CaptureGIF_CustomRegion());
                resultList.Add(MakeCommand.CaptureGIF_ActiveWindow());
            }
        }

        #endregion

    }
}
