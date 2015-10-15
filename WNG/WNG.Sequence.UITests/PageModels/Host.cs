using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;

namespace WNG.Sequence.UITests.PageModels
{
    public static class Host
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string Url;

        static Host()
        {
            Instance.Run("WNG.Sequence", 8888, config => config.WithRouteConfig(RouteConfig.RegisterRoutes));
            Url = Instance.Application.Browser.Url;
        }
    }
}
