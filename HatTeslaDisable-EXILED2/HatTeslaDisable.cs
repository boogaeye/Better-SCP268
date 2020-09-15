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
        public override PluginPriority Priority { get; } = PluginPriority.Low;
        private HatTeslaDisable()
        {

        }
        public override void OnEnabled()
        {
            RegisterEvents();
        }
        Handlers.Player player;
        private void RegisterEvents()
        {
            player = new Handlers.Player();
            Exiled.Events.Handlers.Player.TriggeringTesla += player.OnTesla;
            Exiled.Events.Handlers.Player.Hurting += player.OnHurt;
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= player.OnTesla;
            Exiled.Events.Handlers.Player.Hurting -= player.OnHurt;
        }
        public override void OnReloaded()
        {
            
        }
    }
}
