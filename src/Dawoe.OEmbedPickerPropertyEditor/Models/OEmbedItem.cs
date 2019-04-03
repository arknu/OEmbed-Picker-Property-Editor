﻿namespace Dawoe.OEmbedPickerPropertyEditor.Models
{
    using System.Web;

    using Newtonsoft.Json;

    /// <summary>
    /// Represents a item picked in the editor
    /// </summary>
    public class OEmbedItem
    {
        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the preview.
        /// </summary>
        [JsonProperty(PropertyName = "preview")]
        public IHtmlString Preview { get; set; }
    }
}
