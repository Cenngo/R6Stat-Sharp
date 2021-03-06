﻿using Newtonsoft.Json;
using R6Stats.Response.Interfaces;
using R6Stats.Stats;
using R6Stats.Stats.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace R6Stats.Response
{
    /// <summary>
    /// Contains weapon stats of a player
    /// </summary>
    public class WeaponsResponse : BaseResponse, IWeaponResponse
    {
        [JsonProperty("weapons")]
        private List<WeaponStat> _weapons;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyDictionary<string, WeaponStat> Weapons => _weapons.ToDictionary(x => x.Weapon.ToLower().Replace(' ', '_'), x => x);
    }
}
