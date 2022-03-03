// <copyright file="Color.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Dalili.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Dalili.Standard;
    using Dalili.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Color.
    /// </summary>
    public class Color
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class.
        /// </summary>
        public Color()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class.
        /// </summary>
        /// <param name="colorProp">color.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="size">size.</param>
        public Color(
            string colorProp,
            string quantity,
            string size)
        {
            this.ColorProp = colorProp;
            this.Quantity = quantity;
            this.Size = size;
        }

        /// <summary>
        /// Gets or sets ColorProp.
        /// </summary>
        [JsonProperty("color")]
        public string ColorProp { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Color : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Color other &&
                ((this.ColorProp == null && other.ColorProp == null) || (this.ColorProp?.Equals(other.ColorProp) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColorProp = {(this.ColorProp == null ? "null" : this.ColorProp == string.Empty ? "" : this.ColorProp)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity == string.Empty ? "" : this.Quantity)}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size == string.Empty ? "" : this.Size)}");
        }
    }
}