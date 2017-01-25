// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ClientToServer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// info about document saved
    /// </summary>
    public partial class DidSaveTextDocumentParams
    {
        /// <summary>
        /// Initializes a new instance of the DidSaveTextDocumentParams class.
        /// </summary>
        public DidSaveTextDocumentParams() { }

        /// <summary>
        /// Initializes a new instance of the DidSaveTextDocumentParams class.
        /// </summary>
        /// <param name="text">Optional the content when saved. Depends on the
        /// includeText value when the save notifcation was requested.</param>
        public DidSaveTextDocumentParams(TextDocumentIdentifier textDocument = default(TextDocumentIdentifier), string text = default(string))
        {
            TextDocument = textDocument;
            Text = text;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }

        /// <summary>
        /// Gets or sets optional the content when saved. Depends on the
        /// includeText value when the save notifcation was requested.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

    }
}

