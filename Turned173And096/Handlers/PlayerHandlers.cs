using Exiled.Events.EventArgs.Player;
using Exiled.API.Features.Roles;
using Exiled.API.Features;

namespace Turned173And096.Handlers
{
    class PlayerHandlers
    {
        private void TurnedAddScp(Player player)
        {
            Scp096Role.TurnedPlayers.Add(player);
            Scp173Role.TurnedPlayers.Add(player);
        }

        private void TurnedRemoveScp(Player player)
        {
            Scp096Role.TurnedPlayers.Remove(player);
            Scp173Role.TurnedPlayers.Remove(player);
        }

        public void OnSpawning(SpawningEventArgs ev)
        {
            if (Turned173And096.Singleton.Config.TurnedClasses.Contains(ev.Player.Role.Type))
            {
                TurnedAddScp(ev.Player);
            } else
            {
                TurnedRemoveScp(ev.Player);
            }
        }
    }
}
