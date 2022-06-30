
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
        #region members

        private PluginInitContext _context;

        #endregion

        #region wox overrides

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            List<Result> resultList = new List<Result>();

            AddScreenshotCommand(resultList, query);
            AddColorPickerCommand(resultList, query);
            AddScreenColorPicker(resultList, query);
            AddRuller(resultList, query);

            return resultList;
        }

        #endregion

        #region commands

        private void AddScreenshotCommand(List<Result> resultList, Query query)
        {
            if (StringTools.IsEqualOnStart(query.Search, "screenshot", "capture", "regionscreenshot"))
            {
                resultList.Add(MakeCommand.CaptureRegionScreenshot());
            }
        }

        private void AddColorPickerCommand(List<Result> resultList, Query query)
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

        #endregion

    }
}
