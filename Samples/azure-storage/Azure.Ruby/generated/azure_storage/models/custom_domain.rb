# encoding: utf-8

module Petstore
  module Models
    #
    # The custom domain assigned to this storage account. This can be set via
    # Update.
    #
    class CustomDomain

      include MsRestAzure

      # @return [String] Gets or sets the custom domain name. Name is the CNAME
      # source.
      attr_accessor :name

      # @return [Boolean] Indicates whether indirect CName validation is
      # enabled. Default value is false. This should only be set on updates
      attr_accessor :use_sub_domain


      #
      # Mapper for CustomDomain class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          required: false,
          serialized_name: 'CustomDomain',
          type: {
            name: 'Composite',
            class_name: 'CustomDomain',
            model_properties: {
              name: {
                required: true,
                serialized_name: 'name',
                type: {
                  name: 'String'
                }
              },
              use_sub_domain: {
                required: false,
                serialized_name: 'useSubDomain',
                type: {
                  name: 'Boolean'
                }
              }
            }
          }
        }
      end
    end
  end
end
