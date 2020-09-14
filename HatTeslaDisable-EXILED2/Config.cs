using Exiled.API.Interfaces;
using System.ComponentModel;

namespace HatTeslaDisable_EXILED2
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("sets if the hat has to be held(and character not visable) to disable tesla gates for that person")]
        public bool teslaHatHold { get; set; } = false;
        [Description("sets if the person is invisable it doesnt allow damage to hurt the person while not visable")]
        public bool hatGodMode { get; set; } = false;
    }
}
