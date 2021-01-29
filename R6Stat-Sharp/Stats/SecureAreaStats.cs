﻿using Newtonsoft.Json;

namespace R6Stat_Sharp.Stats
{
    public class SecureAreaStats : GamemodeStat
    {
        [JsonProperty("kills_as_attacker_in_objective")]
        public int KillsAsAttackerInObj { get; private set; }

        [JsonProperty("kills_as_defender_in_objective")]
        public int KillsAsDeffenderInObj { get; private set; }

        [JsonProperty("times_objective_secured")]
        public int TimesObjSecured { get; private set; }
    }
}
