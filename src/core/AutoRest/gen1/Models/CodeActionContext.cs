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
    /// Contains additional diagnostic information about the context in which a
    /// code action is run.
    /// </summary>
    public partial class CodeActionContext
    {
        /// <summary>
        /// Initializes a new instance of the CodeActionContext class.
        /// </summary>
        public CodeActionContext() { }

        /// <summary>
        /// Initializes a new instance of the CodeActionContext class.
        /// </summary>
        /// <param name="diagnostics">An array of diagnostics.</param>
        public CodeActionContext(IList<Diagnostic> diagnostics = default(IList<Diagnostic>))
        {
            Diagnostics = diagnostics;
        }

        /// <summary>
        /// Gets or sets an array of diagnostics.
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public IList<Diagnostic> Diagnostics { get; set; }

    }
}

