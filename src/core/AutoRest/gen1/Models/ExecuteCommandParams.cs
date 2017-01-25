// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ClientToServer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// params to request command exec at server
    /// </summary>
    public partial class ExecuteCommandParams
    {
        /// <summary>
        /// Initializes a new instance of the ExecuteCommandParams class.
        /// </summary>
        public ExecuteCommandParams() { }

        /// <summary>
        /// Initializes a new instance of the ExecuteCommandParams class.
        /// </summary>
        /// <param name="command">the cmd to exec</param>
        /// <param name="arguments">args to the cmd</param>
        public ExecuteCommandParams(string command = default(string), IList<object> arguments = default(IList<object>))
        {
            Command = command;
            Arguments = arguments;
        }

        /// <summary>
        /// Gets or sets the cmd to exec
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

        /// <summary>
        /// Gets or sets args to the cmd
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public IList<object> Arguments { get; set; }

    }
}

