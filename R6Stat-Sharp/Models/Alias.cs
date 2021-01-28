﻿using Newtonsoft.Json;
using R6Stat_Sharp.Response.Interfaces;
using System;

namespace R6Stat_Sharp.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class Alias : IAlias
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; internal set; }

        [JsonProperty("last_seen_at")]
        internal string _lastSeenAt;

        /// <summary>
        /// The last use date for the given alias
        /// </summary>
        [JsonIgnore]
        public DateTime LastSeenAt => DateTime.Parse(_lastSeenAt);
    }
}
