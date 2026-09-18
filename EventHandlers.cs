using System;
using Cassie;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Cassie;
using Respawning.Waves;

namespace ChaosRemover
{
    public class EventHandlers
    {
        private readonly Config _config;

        public EventHandlers(Config config)
        {
            _config = config;
        }

        public void OnSendingCassieMessage(SendingCassieMessageEventArgs ev)
        {
            if (ev.Announcement is CassieWaveAnnouncement waveAnn)
            {
                if (_config.SilenceStandardWave && waveAnn.Wave is ChaosSpawnWave)
                {
                    Log.Debug("Blocked standard Chaos Insurgency spawn announcement (matched ChaosSpawnWave).");
                    ev.IsAllowed = false;
                    return;
                }

                if (_config.SilenceMiniWave && waveAnn.Wave is ChaosMiniWave)
                {
                    Log.Debug("Blocked mini Chaos Insurgency spawn announcement (matched ChaosMiniWave).");
                    ev.IsAllowed = false;
                    return;
                }
            }

            if (!string.IsNullOrEmpty(ev.Words))
            {
                string upper = ev.Words.ToUpperInvariant();

                if (_config.SilenceStandardWave &&
                    (upper.Contains("CHAOSINSURGENCY") || upper.Contains("CHAOS INSURGENCY")) &&
                    upper.Contains("GATE A"))
                {
                    Log.Debug($"Blocked standard Chaos Insurgency Cassie announcement by pattern: '{ev.Words}'.");
                    ev.IsAllowed = false;
                    return;
                }

                if (_config.SilenceMiniWave &&
                    (upper.Contains("ADDITIONAL HOSTILEFORCES AT GATE A") ||
                     upper.Contains("ADDITIONAL HOSTILE FORCES AT GATE A") ||
                     (upper.Contains("HOSTILE") && upper.Contains("GATE A") && upper.Contains("DEFENSEMODULEUPDATED"))))
                {
                    Log.Debug($"Blocked mini Chaos Cassie announcement by pattern: '{ev.Words}'.");
                    ev.IsAllowed = false;
                    return;
                }
            }
        }
    }
}
