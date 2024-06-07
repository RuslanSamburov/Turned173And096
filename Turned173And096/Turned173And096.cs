using Exiled.API.Features;
using System;
using Turned173And096.Configs;
using Turned173And096.Handlers;

namespace Turned173And096
{
    public class Turned173And096 : Plugin<Config>
    {
        public override string Author => "Руслан0308c";
        public override string Name => "Turned173And096";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 3);

        public static Turned173And096 Singleton { get; private set; }

        private PlayerHandlers _PlayerHandlers = new PlayerHandlers();

        public override void OnEnabled()
        {
            Singleton = this;

            if (!Config.IsEnabled)
            {
                Log.Warn("Plugin " + Name + " disabled!");
                return;
            }

            Exiled.Events.Handlers.Player.Spawning += _PlayerHandlers.OnSpawning;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;

            Exiled.Events.Handlers.Player.Spawning -= _PlayerHandlers.OnSpawning;

            base.OnDisabled();
        }
    }
}
