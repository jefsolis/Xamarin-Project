﻿using Newtonsoft.Json;

namespace HolaMoviles.Modelos
{
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class LabelInfo
    {
        [JsonProperty("catalog-number", Required = Required.Default)]
        public string CatalogNumber { get; private set; }

        public Label Label => this._label;

        [JsonProperty("label", Required = Required.AllowNull)]
        private Label _label = null;

        public override string ToString()
        {
            var text = string.Empty;
            if (this.Label != null)
            {
                text += this.Label;
                if (this.CatalogNumber != null)
                    text += ": ";
            }
            if (this.CatalogNumber != null)
                text += this.CatalogNumber;
            return text;
        }

    }

}