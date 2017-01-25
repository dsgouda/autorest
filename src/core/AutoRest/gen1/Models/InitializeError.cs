// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ClientToServer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error object for unsuccessful initialization
    /// </summary>
    public partial class InitializeError
    {
        /// <summary>
        /// Initializes a new instance of the InitializeError class.
        /// </summary>
        public InitializeError() { }

        /// <summary>
        /// Initializes a new instance of the InitializeError class.
        /// </summary>
        /// <param name="retry">Indicates whether the client should retry to
        /// send the initilize request after showing the message provided in
        /// the ResponseError.</param>
        public InitializeError(bool? retry = default(bool?))
        {
            Retry = retry;
        }

        /// <summary>
        /// Gets or sets indicates whether the client should retry to send the
        /// initilize request after showing the message provided in the
        /// ResponseError.
        /// </summary>
        [JsonProperty(PropertyName = "retry")]
        public bool? Retry { get; set; }

    }
}

