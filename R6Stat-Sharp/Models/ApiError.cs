﻿using Newtonsoft.Json;

namespace R6Stats.Models
{
    /// <summary>
    /// Represents an API Error thrown by the <see href="https://r6stats.com/">R6 Stats API</see> after a bad request
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// Status code of the error
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

        /// <summary>
        /// Description of the error
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; private set; }
    }
}
