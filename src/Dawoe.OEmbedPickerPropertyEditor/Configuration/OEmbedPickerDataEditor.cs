﻿namespace Dawoe.OEmbedPickerPropertyEditor.Configuration
{
    using Umbraco.Core.Logging;
    using Umbraco.Core.PropertyEditors;

    /// <summary>
    /// Represents the OEmbed picker data editor
    /// </summary>
    [DataEditor(Constants.DataEditorAlias, "OEmbed Picker", "~/App_Plugins/Dawoe.OEmbedPickerPropertyEditor/views/editor.html", ValueType = "JSON", Group = "pickers", Icon = "icon-tv")]
    public class OEmbedPickerDataEditor : DataEditor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OEmbedPickerDataEditor"/> class.
        /// </summary>
        /// <param name="logger">
        /// The logger.
        /// </param>
        public OEmbedPickerDataEditor(ILogger logger)
            : base(logger)
        {
        }

        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new OEmbedPickerConfigurationEditor();
    }
}
