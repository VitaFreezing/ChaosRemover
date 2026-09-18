using System;
using Exiled.API.Features;

namespace ChaosRemover
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin? Instance { get; private set; }

        public override string Name => "ChaosRemover";
        public override string Author => "Vita";
        public override string Prefix => "ChaosRemover";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        private EventHandlers? _eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            _eventHandlers = new EventHandlers(Config);

            Exiled.Events.Handlers.Cassie.SendingCassieMessage += _eventHandlers.OnSendingCassieMessage;

            Log.Info($"{Name} v{Version} has been successfully enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            if (_eventHandlers != null)
            {
                Exiled.Events.Handlers.Cassie.SendingCassieMessage -= _eventHandlers.OnSendingCassieMessage;
                _eventHandlers = null;
            }

            Instance = null;

            Log.Info($"{Name} v{Version} has been disabled.");
            base.OnDisabled();
        }
    }
}
