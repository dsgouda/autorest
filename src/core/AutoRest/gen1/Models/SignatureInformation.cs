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
    /// Represents the signature of something callable. A signature can have a
    /// label, like a function-name, a doc-comment, and a set of parameters.
    /// </summary>
    public partial class SignatureInformation : LabelAndDocumentation
    {
        /// <summary>
        /// Initializes a new instance of the SignatureInformation class.
        /// </summary>
        public SignatureInformation() { }

        /// <summary>
        /// Initializes a new instance of the SignatureInformation class.
        /// </summary>
        /// <param name="label">label for item</param>
        /// <param name="documentation">doc for item</param>
        /// <param name="parameters">The parameters of this signature.</param>
        public SignatureInformation(string label = default(string), string documentation = default(string), IList<ParameterInformation> parameters = default(IList<ParameterInformation>))
            : base(label, documentation)
        {
            Parameters = parameters;
        }

        /// <summary>
        /// Gets or sets the parameters of this signature.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<ParameterInformation> Parameters { get; set; }

    }
}

