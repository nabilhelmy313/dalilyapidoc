// <copyright file="Property.cs" company="APIMatic">
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
    /// Property.
    /// </summary>
    public class Property
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Property"/> class.
        /// </summary>
        public Property()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Property"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mandatory">mandatory.</param>
        /// <param name="name">name.</param>
        /// <param name="options">options.</param>
        /// <param name="selected">selected.</param>
        /// <param name="typeId">type_id.</param>
        /// <param name="mValue">value.</param>
        public Property(
            int id,
            int mandatory,
            string name,
            List<Models.Option> options,
            int selected,
            int typeId,
            string mValue)
        {
            this.Id = id;
            this.Mandatory = mandatory;
            this.Name = name;
            this.Options = options;
            this.Selected = selected;
            this.TypeId = typeId;
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Mandatory.
        /// </summary>
        [JsonProperty("mandatory")]
        public int Mandatory { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options")]
        public List<Models.Option> Options { get; set; }

        /// <summary>
        /// Gets or sets Selected.
        /// </summary>
        [JsonProperty("selected")]
        public int Selected { get; set; }

        /// <summary>
        /// Gets or sets TypeId.
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Property : ({string.Join(", ", toStringOutput)})";
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

            return obj is Property other &&
                this.Id.Equals(other.Id) &&
                this.Mandatory.Equals(other.Mandatory) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true)) &&
                this.Selected.Equals(other.Selected) &&
                this.TypeId.Equals(other.TypeId) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Mandatory = {this.Mandatory}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : $"[{string.Join(", ", this.Options)} ]")}");
            toStringOutput.Add($"this.Selected = {this.Selected}");
            toStringOutput.Add($"this.TypeId = {this.TypeId}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
        }
    }
}