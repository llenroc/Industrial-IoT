// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Vault.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Certificate model
    /// </summary>
    public partial class X509CertificateApiModel
    {
        /// <summary>
        /// Initializes a new instance of the X509CertificateApiModel class.
        /// </summary>
        public X509CertificateApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X509CertificateApiModel class.
        /// </summary>
        /// <param name="certificate">Raw data</param>
        /// <param name="subject">Subject</param>
        /// <param name="thumbprint">Thumbprint</param>
        /// <param name="serialNumber">Serial number</param>
        /// <param name="notBeforeUtc">Not before validity</param>
        /// <param name="notAfterUtc">Not after validity</param>
        public X509CertificateApiModel(object certificate, string subject = default(string), string thumbprint = default(string), string serialNumber = default(string), System.DateTime? notBeforeUtc = default(System.DateTime?), System.DateTime? notAfterUtc = default(System.DateTime?))
        {
            Subject = subject;
            Thumbprint = thumbprint;
            SerialNumber = serialNumber;
            NotBeforeUtc = notBeforeUtc;
            NotAfterUtc = notAfterUtc;
            Certificate = certificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets subject
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets serial number
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets not before validity
        /// </summary>
        [JsonProperty(PropertyName = "notBeforeUtc")]
        public System.DateTime? NotBeforeUtc { get; set; }

        /// <summary>
        /// Gets or sets not after validity
        /// </summary>
        [JsonProperty(PropertyName = "notAfterUtc")]
        public System.DateTime? NotAfterUtc { get; set; }

        /// <summary>
        /// Gets or sets raw data
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public object Certificate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Certificate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Certificate");
            }
        }
    }
}
