// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using LoadBalancer.Definition;
    using LoadBalancer.Update;
    using LoadBalancerPrivateFrontend.Definition;
    using LoadBalancerPrivateFrontend.Update;
    using LoadBalancerPrivateFrontend.UpdateDefinition;
    using LoadBalancerPublicFrontend.Definition;
    using LoadBalancerPublicFrontend.Update;
    using LoadBalancerPublicFrontend.UpdateDefinition;
    using Models;
    using HasPrivateIPAddress.Definition;
    using HasPrivateIPAddress.UpdateDefinition;
    using HasPrivateIPAddress.Update;
    using HasPublicIPAddress.Definition;
    using HasPublicIPAddress.UpdateDefinition;
    using HasPublicIPAddress.Update;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.HasSubnet.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResourceActions;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update;
    using System.Collections.Generic;

    internal partial class LoadBalancerFrontendImpl 
    {
        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        LoadBalancer.Update.IUpdate Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResourceActions.IInUpdateAlt<LoadBalancer.Update.IUpdate>.Attach()
        {
            return this.Attach() as LoadBalancer.Update.IUpdate;
        }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasName.Name
        {
            get
            {
                return this.Name();
            }
        }

        /// <summary>
        /// Gets the resource ID of the associated public IP address.
        /// </summary>
        string Microsoft.Azure.Management.Network.Fluent.IHasPublicIPAddress.PublicIPAddressId
        {
            get
            {
                return this.PublicIPAddressId();
            }
        }

        /// <return>The associated public IP address.</return>
        Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress Microsoft.Azure.Management.Network.Fluent.IHasPublicIPAddress.GetPublicIPAddress()
        {
            return this.GetPublicIPAddress() as Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress;
        }

        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        LoadBalancer.Update.IUpdate Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update.IInUpdate<LoadBalancer.Update.IUpdate>.Attach()
        {
            return this.Attach() as LoadBalancer.Update.IUpdate;
        }

        /// <summary>
        /// Attaches the child definition to the parent resource definiton.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        LoadBalancer.Definition.IWithPublicFrontendOrBackend Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition.IInDefinition<LoadBalancer.Definition.IWithPublicFrontendOrBackend>.Attach()
        {
            return this.Attach() as LoadBalancer.Definition.IWithPublicFrontendOrBackend;
        }

        /// <summary>
        /// Assigns the specified subnet to this resource.
        /// </summary>
        /// <param name="parentNetworkResourceId">The resource ID of the virtual network the subnet is part of.</param>
        /// <param name="subnetName">The name of the subnet.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend> Microsoft.Azure.Management.ResourceManager.Fluent.Core.HasSubnet.Definition.IWithSubnet<LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>>.WithExistingSubnet(string parentNetworkResourceId, string subnetName)
        {
            return this.WithExistingSubnet(parentNetworkResourceId, subnetName) as LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <summary>
        /// Assigns the specified static private IP address within the associated subnet.
        /// </summary>
        /// <param name="ipAddress">A static IP address within the associated private IP range.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate> HasPrivateIPAddress.UpdateDefinition.IWithPrivateIPAddress<LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>>.WithPrivateIPAddressStatic(string ipAddress)
        {
            return this.WithPrivateIPAddressStatic(ipAddress) as LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Enables dynamic private IP address allocation within the associated subnet.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate> HasPrivateIPAddress.UpdateDefinition.IWithPrivateIPAddress<LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>>.WithPrivateIPAddressDynamic()
        {
            return this.WithPrivateIPAddressDynamic() as LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Assigns the specified static private IP address within the associated subnet.
        /// </summary>
        /// <param name="ipAddress">A static IP address within the associated private IP range.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend> HasPrivateIPAddress.Definition.IWithPrivateIPAddress<LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>>.WithPrivateIPAddressStatic(string ipAddress)
        {
            return this.WithPrivateIPAddressStatic(ipAddress) as LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <summary>
        /// Enables dynamic private IP address allocation within the associated subnet.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend> HasPrivateIPAddress.Definition.IWithPrivateIPAddress<LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>>.WithPrivateIPAddressDynamic()
        {
            return this.WithPrivateIPAddressDynamic() as LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <summary>
        /// Assigns the specified static private IP address within the associated subnet.
        /// </summary>
        /// <param name="ipAddress">A static IP address within the associated private IP range.</param>
        /// <return>The next stage of the update.</return>
        LoadBalancerPrivateFrontend.Update.IUpdate HasPrivateIPAddress.Update.IWithPrivateIPAddress<LoadBalancerPrivateFrontend.Update.IUpdate>.WithPrivateIPAddressStatic(string ipAddress)
        {
            return this.WithPrivateIPAddressStatic(ipAddress) as LoadBalancerPrivateFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Enables dynamic private IP address allocation within the associated subnet.
        /// </summary>
        /// <return>The next stage of the update.</return>
        LoadBalancerPrivateFrontend.Update.IUpdate HasPrivateIPAddress.Update.IWithPrivateIPAddress<LoadBalancerPrivateFrontend.Update.IUpdate>.WithPrivateIPAddressDynamic()
        {
            return this.WithPrivateIPAddressDynamic() as LoadBalancerPrivateFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Gets the private IP address associated with this resource.
        /// </summary>
        string Microsoft.Azure.Management.Network.Fluent.IHasPrivateIPAddress.PrivateIPAddress
        {
            get
            {
                return this.PrivateIPAddress();
            }
        }

        /// <summary>
        /// Gets the private IP address allocation method within the associated subnet.
        /// </summary>
        IPAllocationMethod Microsoft.Azure.Management.Network.Fluent.IHasPrivateIPAddress.PrivateIPAllocationMethod
        {
            get
            {
                return this.PrivateIPAllocationMethod();
            }
        }

        /// <summary>
        /// Gets the name of the subnet associated with this resource.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasSubnet.SubnetName
        {
            get
            {
                return this.SubnetName();
            }
        }

        /// <summary>
        /// Gets the resource ID of the virtual network whose subnet is associated with this resource.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasSubnet.NetworkId
        {
            get
            {
                return this.NetworkId();
            }
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="publicIPAddress">An existing public IP address.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPublicFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPublicFrontendOrBackend> HasPublicIPAddress.Definition.IWithExistingPublicIPAddress<LoadBalancerPublicFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPublicFrontendOrBackend>>.WithExistingPublicIPAddress(IPublicIPAddress publicIPAddress)
        {
            return this.WithExistingPublicIPAddress(publicIPAddress) as LoadBalancerPublicFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPublicFrontendOrBackend>;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="resourceId">The resource ID of an existing public IP address.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPublicFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPublicFrontendOrBackend> HasPublicIPAddress.Definition.IWithExistingPublicIPAddress<LoadBalancerPublicFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPublicFrontendOrBackend>>.WithExistingPublicIPAddress(string resourceId)
        {
            return this.WithExistingPublicIPAddress(resourceId) as LoadBalancerPublicFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPublicFrontendOrBackend>;
        }

        /// <summary>
        /// Removes the existing reference to a public IP address.
        /// </summary>
        /// <return>The next stage of the update.</return>
        LoadBalancerPublicFrontend.Update.IUpdate HasPublicIPAddress.Update.IWithExistingPublicIPAddress<LoadBalancerPublicFrontend.Update.IUpdate>.WithoutPublicIPAddress()
        {
            return this.WithoutPublicIPAddress() as LoadBalancerPublicFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="publicIPAddress">An existing public IP address.</param>
        /// <return>The next stage of the update.</return>
        LoadBalancerPublicFrontend.Update.IUpdate HasPublicIPAddress.Update.IWithExistingPublicIPAddress<LoadBalancerPublicFrontend.Update.IUpdate>.WithExistingPublicIPAddress(IPublicIPAddress publicIPAddress)
        {
            return this.WithExistingPublicIPAddress(publicIPAddress) as LoadBalancerPublicFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="resourceId">The resource ID of an existing public IP address.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPublicFrontend.Update.IUpdate HasPublicIPAddress.Update.IWithExistingPublicIPAddress<LoadBalancerPublicFrontend.Update.IUpdate>.WithExistingPublicIPAddress(string resourceId)
        {
            return this.WithExistingPublicIPAddress(resourceId) as LoadBalancerPublicFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="publicIPAddress">An existing public IP address.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPublicFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate> HasPublicIPAddress.UpdateDefinition.IWithExistingPublicIPAddress<LoadBalancerPublicFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>>.WithExistingPublicIPAddress(IPublicIPAddress publicIPAddress)
        {
            return this.WithExistingPublicIPAddress(publicIPAddress) as LoadBalancerPublicFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="resourceId">The resource ID of an existing public IP address.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPublicFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate> HasPublicIPAddress.UpdateDefinition.IWithExistingPublicIPAddress<LoadBalancerPublicFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>>.WithExistingPublicIPAddress(string resourceId)
        {
            return this.WithExistingPublicIPAddress(resourceId) as LoadBalancerPublicFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Attaches the child definition to the parent resource definition.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        LoadBalancer.Definition.IWithPrivateFrontendOrBackend Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResourceActions.IInDefinitionAlt<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>.Attach()
        {
            return this.Attach() as LoadBalancer.Definition.IWithPrivateFrontendOrBackend;
        }

        /// <summary>
        /// Gets the inbound NAT pools on this load balancer that use this frontend, indexed by their names.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.ILoadBalancerInboundNatPool> Microsoft.Azure.Management.Network.Fluent.ILoadBalancerFrontend.InboundNatPools
        {
            get
            {
                return this.InboundNatPools() as System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.ILoadBalancerInboundNatPool>;
            }
        }

        /// <summary>
        /// Gets true if the frontend is public, i.e. it has a public IP address associated with it.
        /// </summary>
        bool Microsoft.Azure.Management.Network.Fluent.ILoadBalancerFrontend.IsPublic
        {
            get
            {
                return this.IsPublic();
            }
        }

        /// <summary>
        /// Gets the inbound NAT rules on this load balancer that use this frontend, indexed by their names.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.ILoadBalancerInboundNatRule> Microsoft.Azure.Management.Network.Fluent.ILoadBalancerFrontend.InboundNatRules
        {
            get
            {
                return this.InboundNatRules() as System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.ILoadBalancerInboundNatRule>;
            }
        }

        /// <return>
        /// Associated subnet
        /// Note this makes a separate call to Azure.
        /// </return>
        Microsoft.Azure.Management.Network.Fluent.ISubnet Microsoft.Azure.Management.Network.Fluent.ILoadBalancerPrivateFrontend.GetSubnet()
        {
            return this.GetSubnet() as Microsoft.Azure.Management.Network.Fluent.ISubnet;
        }

        /// <summary>
        /// Gets the associated load balancing rules from this load balancer, indexed by their names.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.ILoadBalancingRule> Microsoft.Azure.Management.Network.Fluent.IHasLoadBalancingRules.LoadBalancingRules
        {
            get
            {
                return this.LoadBalancingRules() as System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.ILoadBalancingRule>;
            }
        }

        /// <summary>
        /// Assigns the specified subnet to this private frontend of the internal load balancer.
        /// </summary>
        /// <param name="network">The virtual network the subnet exists in.</param>
        /// <param name="subnetName">The name of a subnet.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate> LoadBalancerPrivateFrontend.UpdateDefinition.IWithSubnet<LoadBalancer.Update.IUpdate>.WithExistingSubnet(INetwork network, string subnetName)
        {
            return this.WithExistingSubnet(network, subnetName) as LoadBalancerPrivateFrontend.UpdateDefinition.IWithAttach<LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Assigns the specified subnet to this private frontend of an internal load balancer.
        /// </summary>
        /// <param name="network">The virtual network the subnet exists in.</param>
        /// <param name="subnetName">The name of a subnet.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend> LoadBalancerPrivateFrontend.Definition.IWithSubnet<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>.WithExistingSubnet(INetwork network, string subnetName)
        {
            return this.WithExistingSubnet(network, subnetName) as LoadBalancerPrivateFrontend.Definition.IWithAttach<LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <summary>
        /// Assigns the specified subnet to this private frontend of the internal load balancer.
        /// </summary>
        /// <param name="network">The virtual network the subnet exists in.</param>
        /// <param name="subnetName">The name of a subnet.</param>
        /// <return>The next stage of the definition.</return>
        LoadBalancerPrivateFrontend.Update.IUpdate LoadBalancerPrivateFrontend.Update.IWithSubnet.WithExistingSubnet(INetwork network, string subnetName)
        {
            return this.WithExistingSubnet(network, subnetName) as LoadBalancerPrivateFrontend.Update.IUpdate;
        }
    }
}