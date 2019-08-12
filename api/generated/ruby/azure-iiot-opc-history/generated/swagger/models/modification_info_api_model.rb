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
    # Modification information
    #
    class ModificationInfoApiModel
      # @return [DateTime] Modification time
      attr_accessor :modification_time

      # @return [HistoryUpdateOperation] Operation. Possible values include:
      # 'Insert', 'Replace', 'Update', 'Delete'
      attr_accessor :update_type

      # @return [String] User who made the change
      attr_accessor :user_name


      #
      # Mapper for ModificationInfoApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'ModificationInfoApiModel',
          type: {
            name: 'Composite',
            class_name: 'ModificationInfoApiModel',
            model_properties: {
              modification_time: {
                client_side_validation: true,
                required: false,
                serialized_name: 'modificationTime',
                type: {
                  name: 'DateTime'
                }
              },
              update_type: {
                client_side_validation: true,
                required: false,
                serialized_name: 'updateType',
                type: {
                  name: 'Enum',
                  module: 'HistoryUpdateOperation'
                }
              },
              user_name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'userName',
                type: {
                  name: 'String'
                }
              }
            }
          }
        }
      end
    end
  end
end