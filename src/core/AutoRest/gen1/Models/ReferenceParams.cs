// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ClientToServer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// request object to fetch references
    /// </summary>
    public partial class ReferenceParams : TextDocumentPositionParams
    {
        /// <summary>
        /// Initializes a new instance of the ReferenceParams class.
        /// </summary>
        public ReferenceParams() { }

        /// <summary>
        /// Initializes a new instance of the ReferenceParams class.
        /// </summary>
        /// <param name="includeDeclaration">Include the declaration of the
        /// current symbol.</param>
        public ReferenceParams(TextDocumentIdentifier textDocument = default(TextDocumentIdentifier), Position position = default(Position), bool? includeDeclaration = default(bool?))
            : base(textDocument, position)
        {
            IncludeDeclaration = includeDeclaration;
        }

        /// <summary>
        /// Gets or sets include the declaration of the current symbol.
        /// </summary>
        [JsonProperty(PropertyName = "includeDeclaration")]
        public bool? IncludeDeclaration { get; set; }

    }
}

