// <copyright file="Product.cs" company="APIMatic">
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
    /// Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="productId">product_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="colorId">color_id.</param>
        /// <param name="sizeId">size_id.</param>
        public Product(
            int productId,
            int quantity,
            string colorId,
            string sizeId)
        {
            this.ProductId = productId;
            this.Quantity = quantity;
            this.ColorId = colorId;
            this.SizeId = sizeId;
        }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets ColorId.
        /// </summary>
        [JsonProperty("color_id")]
        public string ColorId { get; set; }

        /// <summary>
        /// Gets or sets SizeId.
        /// </summary>
        [JsonProperty("size_id")]
        public string SizeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Product : ({string.Join(", ", toStringOutput)})";
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

            return obj is Product other &&
                this.ProductId.Equals(other.ProductId) &&
                this.Quantity.Equals(other.Quantity) &&
                ((this.ColorId == null && other.ColorId == null) || (this.ColorId?.Equals(other.ColorId) == true)) &&
                ((this.SizeId == null && other.SizeId == null) || (this.SizeId?.Equals(other.SizeId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductId = {this.ProductId}");
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
            toStringOutput.Add($"this.ColorId = {(this.ColorId == null ? "null" : this.ColorId == string.Empty ? "" : this.ColorId)}");
            toStringOutput.Add($"this.SizeId = {(this.SizeId == null ? "null" : this.SizeId == string.Empty ? "" : this.SizeId)}");
        }
    }
}