# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from .resource import Resource


class FlattenedProduct(Resource):
    """Flattened product.

    Variables are only populated by the server, and will be ignored when
    sending a request.

    :ivar id: Resource Id
    :vartype id: str
    :ivar type: Resource Type
    :vartype type: str
    :param tags:
    :type tags: dict
    :param location: Resource Location
    :type location: str
    :ivar name: Resource Name
    :vartype name: str
    :param pname:
    :type pname: str
    :param flattened_product_type:
    :type flattened_product_type: str
    :ivar provisioning_state_values: Possible values include: 'Succeeded',
     'Failed', 'canceled', 'Accepted', 'Creating', 'Created', 'Updating',
     'Updated', 'Deleting', 'Deleted', 'OK'
    :vartype provisioning_state_values: str or :class:`enum
     <fixtures.acceptancetestsmodelflattening.models.enum>`
    :param provisioning_state:
    :type provisioning_state: str
    """

    _validation = {
        'id': {'readonly': True},
        'type': {'readonly': True},
        'name': {'readonly': True},
        'provisioning_state_values': {'readonly': True},
    }

    _attribute_map = {
        'id': {'key': 'id', 'type': 'str'},
        'type': {'key': 'type', 'type': 'str'},
        'tags': {'key': 'tags', 'type': '{str}'},
        'location': {'key': 'location', 'type': 'str'},
        'name': {'key': 'name', 'type': 'str'},
        'pname': {'key': 'properties.p\\.name', 'type': 'str'},
        'flattened_product_type': {'key': 'properties.type', 'type': 'str'},
        'provisioning_state_values': {'key': 'properties.provisioningStateValues', 'type': 'str'},
        'provisioning_state': {'key': 'properties.provisioningState', 'type': 'str'},
    }

    def __init__(self, tags=None, location=None, pname=None, flattened_product_type=None, provisioning_state=None):
        super(FlattenedProduct, self).__init__(tags=tags, location=location)
        self.pname = pname
        self.flattened_product_type = flattened_product_type
        self.provisioning_state_values = None
        self.provisioning_state = provisioning_state
