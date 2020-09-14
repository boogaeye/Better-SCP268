using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Enums;

namespace HatTeslaDisable_EXILED2
{
    public class HatTeslaDisable : Plugin<Config>
    {
        private static readonly Lazy<HatTeslaDisable> LazyInstance = new Lazy<HatTeslaDisable>(valueFactory: () => new HatTeslaDisable());
        static public HatTeslaDisable instance => LazyInstance.Value;
        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        private HatTeslaDisable()
        {

        }
        public override void OnEnabled()
        {
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            throw new NotImplementedException();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        private void UnregisterEvents()
        {
            throw new NotImplementedException();
        }
    }
}
