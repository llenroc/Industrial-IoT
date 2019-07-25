# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.history
  module Models
    #
    # History read continuation result
    #
    class HistoryReadNextResponseApiModelJToken
      # @return History as json encoded extension object
      attr_accessor :history

      # @return [String] Continuation token if more results pending.
      attr_accessor :continuation_token

      # @return [ServiceResultApiModel] Service result in case of error
      attr_accessor :error_info


      #
      # Mapper for HistoryReadNextResponseApiModelJToken class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'HistoryReadNextResponseApiModel[JToken]',
          type: {
            name: 'Composite',
            class_name: 'HistoryReadNextResponseApiModelJToken',
            model_properties: {
              history: {
                client_side_validation: true,
                required: false,
                serialized_name: 'history',
                type: {
                  name: 'Object'
                }
              },
              continuation_token: {
                client_side_validation: true,
                required: false,
                serialized_name: 'continuationToken',
                type: {
                  name: 'String'
                }
              },
              error_info: {
                client_side_validation: true,
                required: false,
                serialized_name: 'errorInfo',
                type: {
                  name: 'Composite',
                  class_name: 'ServiceResultApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
