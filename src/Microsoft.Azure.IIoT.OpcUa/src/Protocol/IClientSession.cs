// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Protocol {
    using Microsoft.Azure.IIoT.OpcUa.Registry.Models;
    using Opc.Ua.Client;
    using System;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents a client session managed by the client host
    /// </summary>
    public interface IClientSession : IDisposable {

        /// <summary>
        /// Client certificate
        /// </summary>
        X509Certificate2 Certificate { get; set; }

        /// <summary>
        /// Whether the session is inactive based on its timeout setting.
        /// </summary>
        bool Inactive { get; }

        /// <summary>
        /// How many operations are currently pending for the session.
        /// </summary>
        int Pending { get; }

        /// <summary>
        /// Closes the session and cancelles any outstanding operations.
        /// </summary>
        /// <returns></returns>
        Task CloseAsync();

        /// <summary>
        /// Try schedule operation on the session
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serviceCall"></param>
        /// <param name="handler"></param>
        /// <param name="elevation"></param>
        /// <param name="completion"></param>
        /// <returns></returns>
        bool TryScheduleServiceCall<T>(Func<Session, Task<T>> serviceCall,
            Func<Exception, bool> handler, CredentialModel elevation,
            out Task<T> completion);
    }
}
