// <copyright file="Option.cs" company="APIMatic">
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
    /// Option.
    /// </summary>
    public class Option
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Option"/> class.
        /// </summary>
        public Option()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Option"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mandatory">mandatory.</param>
        /// <param name="name">name.</param>
        /// <param name="selected">selected.</param>
        /// <param name="typeId">type_id.</param>
        public Option(
            int? id = null,
            int? mandatory = null,
            string name = null,
            int? selected = null,
            int? typeId = null)
        {
            this.Id = id;
            this.Mandatory = mandatory;
            this.Name = name;
            this.Selected = selected;
            this.TypeId = typeId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Mandatory.
        /// </summary>
        [JsonProperty("mandatory", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mandatory { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Selected.
        /// </summary>
        [JsonProperty("selected", NullValueHandling = NullValueHandling.Ignore)]
        public int? Selected { get; set; }

        /// <summary>
        /// Gets or sets TypeId.
        /// </summary>
        [JsonProperty("type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TypeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Option : ({string.Join(", ", toStringOutput)})";
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

            return obj is Option other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Mandatory == null && other.Mandatory == null) || (this.Mandatory?.Equals(other.Mandatory) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Selected == null && other.Selected == null) || (this.Selected?.Equals(other.Selected) == true)) &&
                ((this.TypeId == null && other.TypeId == null) || (this.TypeId?.Equals(other.TypeId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Mandatory = {(this.Mandatory == null ? "null" : this.Mandatory.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Selected = {(this.Selected == null ? "null" : this.Selected.ToString())}");
            toStringOutput.Add($"this.TypeId = {(this.TypeId == null ? "null" : this.TypeId.ToString())}");
        }
    }
}