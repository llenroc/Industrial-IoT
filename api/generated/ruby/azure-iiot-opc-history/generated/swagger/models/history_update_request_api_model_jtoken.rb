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
    # Request node history update
    #
    class HistoryUpdateRequestApiModelJToken
      # @return [String] Node to update
      attr_accessor :node_id

      # @return [Array<String>] An optional path from NodeId instance to
      # the actual node.
      attr_accessor :browse_path

      # @return The HistoryUpdateDetailsType extension object
      # encoded as json Variant and containing the tunneled
      # update request for the Historian server. The value
      # is updated at edge using above node address.
      attr_accessor :details

      # @return [RequestHeaderApiModel] Optional request header
      attr_accessor :header


      #
      # Mapper for HistoryUpdateRequestApiModelJToken class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'HistoryUpdateRequestApiModel[JToken]',
          type: {
            name: 'Composite',
            class_name: 'HistoryUpdateRequestApiModelJToken',
            model_properties: {
              node_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'nodeId',
                type: {
                  name: 'String'
                }
              },
              browse_path: {
                client_side_validation: true,
                required: false,
                serialized_name: 'browsePath',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              details: {
                client_side_validation: true,
                required: true,
                serialized_name: 'details',
                type: {
                  name: 'Object'
                }
              },
              header: {
                client_side_validation: true,
                required: false,
                serialized_name: 'header',
                type: {
                  name: 'Composite',
                  class_name: 'RequestHeaderApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
