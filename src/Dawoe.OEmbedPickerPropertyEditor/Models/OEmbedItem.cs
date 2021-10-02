// <copyright file="OEmbedItem.cs" company="Umbraco community">
// Copyright (c) Dave Woestenborghs and contributors. Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>

#if NET472
using System.Web;
#else
using Microsoft.AspNetCore.Html;
#endif
using Newtonsoft.Json;

namespace Dawoe.OEmbedPickerPropertyEditor.Models
{
    /// <summary>
    /// Represents a item picked in the editor.
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
        /// Gets the embed code.
        /// </summary>
        [JsonIgnore]
#if NET472
        public IHtmlString EmbedCode => new HtmlString(this.Preview);
#else
        public IHtmlContent EmbedCode => new HtmlString(this.Preview);
#endif

        /// <summary>
        /// Gets or sets the preview.
        /// </summary>
        [JsonProperty(PropertyName = "preview")]
        internal string Preview { get; set; }

        /// <inheritdoc />
        public override string ToString() => this.Preview;
    }
}
