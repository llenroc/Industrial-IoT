/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Certificate request record model
 *
 */
class CertificateRequestRecordApiModel {
  /**
   * Create a CertificateRequestRecordApiModel.
   * @property {string} [requestId] Request id
   * @property {string} [entityId] Application id
   * @property {string} [groupId] Trust group
   * @property {string} [state] Request state. Possible values include: 'New',
   * 'Approved', 'Rejected', 'Failure', 'Completed', 'Accepted'
   * @property {string} [type] Request type. Possible values include:
   * 'SigningRequest', 'KeyPairRequest'
   * @property {object} [errorInfo] Error diagnostics
   * @property {object} [submitted] Request time
   * @property {string} [submitted.authorityId] User
   * @property {date} [submitted.time] Operation time
   * @property {object} [approved] Approved or rejected
   * @property {string} [approved.authorityId] User
   * @property {date} [approved.time] Operation time
   * @property {object} [accepted] Finished
   * @property {string} [accepted.authorityId] User
   * @property {date} [accepted.time] Operation time
   */
  constructor() {
  }

  /**
   * Defines the metadata of CertificateRequestRecordApiModel
   *
   * @returns {object} metadata of CertificateRequestRecordApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'CertificateRequestRecordApiModel',
      type: {
        name: 'Composite',
        className: 'CertificateRequestRecordApiModel',
        modelProperties: {
          requestId: {
            required: false,
            serializedName: 'requestId',
            type: {
              name: 'String'
            }
          },
          entityId: {
            required: false,
            serializedName: 'entityId',
            type: {
              name: 'String'
            }
          },
          groupId: {
            required: false,
            serializedName: 'groupId',
            type: {
              name: 'String'
            }
          },
          state: {
            required: false,
            serializedName: 'state',
            type: {
              name: 'Enum',
              allowedValues: [ 'New', 'Approved', 'Rejected', 'Failure', 'Completed', 'Accepted' ]
            }
          },
          type: {
            required: false,
            serializedName: 'type',
            type: {
              name: 'Enum',
              allowedValues: [ 'SigningRequest', 'KeyPairRequest' ]
            }
          },
          errorInfo: {
            required: false,
            serializedName: 'errorInfo',
            type: {
              name: 'Object'
            }
          },
          submitted: {
            required: false,
            serializedName: 'submitted',
            type: {
              name: 'Composite',
              className: 'VaultOperationContextApiModel'
            }
          },
          approved: {
            required: false,
            serializedName: 'approved',
            type: {
              name: 'Composite',
              className: 'VaultOperationContextApiModel'
            }
          },
          accepted: {
            required: false,
            serializedName: 'accepted',
            type: {
              name: 'Composite',
              className: 'VaultOperationContextApiModel'
            }
          }
        }
      }
    };
  }
}

module.exports = CertificateRequestRecordApiModel;
