// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Services.Twin.v1.Models {
    using Microsoft.Azure.IIoT.OpcUa.Twin.Models;
    using Newtonsoft.Json;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Publish request
    /// </summary>
    public class PublishStartRequestApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        public PublishStartRequestApiModel() { }

        /// <summary>
        /// Create api model from service model
        /// </summary>
        /// <param name="model"></param>
        public PublishStartRequestApiModel(PublishStartRequestModel model) {
            Item = model.Item == null ? null :
                new PublishedItemApiModel(model.Item);
            Diagnostics = model.Diagnostics == null ? null :
                new DiagnosticsApiModel(model.Diagnostics);
        }

        /// <summary>
        /// Create service model from api model
        /// </summary>
        public PublishStartRequestModel ToServiceModel() {
            return new PublishStartRequestModel {
                Item = Item?.ToServiceModel(),
                Diagnostics = Diagnostics?.ToServiceModel()
            };
        }

        /// <summary>
        /// Item to publish
        /// </summary>
        [JsonProperty(PropertyName = "item")]
        [Required]
        public PublishedItemApiModel Item { get; set; }

        /// <summary>
        /// Optional diagnostics configuration
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics",
            NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(null)]
        public DiagnosticsApiModel Diagnostics { get; set; }
    }
}
