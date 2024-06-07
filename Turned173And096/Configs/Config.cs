using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace Turned173And096.Configs
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public List<PlayerRoles.RoleTypeId> TurnedClasses = new List<PlayerRoles.RoleTypeId>() 
        {
            PlayerRoles.RoleTypeId.Tutorial,
        };
    }
}
