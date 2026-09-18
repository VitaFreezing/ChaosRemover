using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ChaosRemover
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages should be displayed in the server console.")]
        public bool Debug { get; set; } = false;

        [Description("Silence the CASSIE announcement for standard Chaos Insurgency spawn waves (e.g. 'Attention all personnel...').")]
        public bool SilenceStandardWave { get; set; } = true;

        [Description("Silence the CASSIE announcement for Chaos Insurgency mini waves (e.g. 'Acquired additional hostile forces at Gate A...').")]
        public bool SilenceMiniWave { get; set; } = true;
    }
}
