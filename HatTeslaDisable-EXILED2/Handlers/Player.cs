using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using CustomPlayerEffects;
namespace HatTeslaDisable_EXILED2.Handlers
{
    class Player
    {
        public void OnTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.ReferenceHub.playerEffectsController.GetEffect<Scp268>().Intensity >= 1 && HatTeslaDisable.instance.Config.disableTeslaHat)
            {
                ev.IsTriggerable = false;
            }
        }
        public void OnHurt(HurtingEventArgs ev)
        {
            if (ev.Target.ReferenceHub.playerEffectsController.GetEffect<Scp268>().Intensity >= 1 && HatTeslaDisable.instance.Config.hatGodMode)
            {
                ev.IsAllowed = false;
            }
        }
    }
}
