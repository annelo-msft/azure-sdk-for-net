// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Profile of network configuration. </summary>
    public partial class ContainerServiceNetworkProfile
    {
        /// <summary> Initializes a new instance of ContainerServiceNetworkProfile. </summary>
        public ContainerServiceNetworkProfile()
        {
            PodCidrs = new Core.ChangeTrackingList<string>();
            ServiceCidrs = new Core.ChangeTrackingList<string>();
            IPFamilies = new Core.ChangeTrackingList<IPFamily>();
        }

        /// <summary> Initializes a new instance of ContainerServiceNetworkProfile. </summary>
        /// <param name="networkPlugin"> Network plugin used for building the Kubernetes network. </param>
        /// <param name="networkPluginMode"> Network plugin mode used for building the Kubernetes network. </param>
        /// <param name="networkPolicy"> Network policy used for building the Kubernetes network. </param>
        /// <param name="networkMode"> This cannot be specified if networkPlugin is anything other than 'azure'. </param>
        /// <param name="ebpfDataplane"> The eBPF dataplane used for building the Kubernetes network. </param>
        /// <param name="podCidr"> A CIDR notation IP range from which to assign pod IPs when kubenet is used. </param>
        /// <param name="serviceCidr"> A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </param>
        /// <param name="dnsServiceIP"> An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </param>
        /// <param name="dockerBridgeCidr"> A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the Kubernetes service address range. </param>
        /// <param name="outboundType"> This can only be set at cluster creation time and cannot be changed later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype). </param>
        /// <param name="loadBalancerSku"> The default is 'standard'. See [Azure Load Balancer SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load balancer SKUs. </param>
        /// <param name="loadBalancerProfile"> Profile of the cluster load balancer. </param>
        /// <param name="natGatewayProfile"> Profile of the cluster NAT gateway. </param>
        /// <param name="podCidrs"> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </param>
        /// <param name="serviceCidrs"> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must not overlap with any Subnet IP ranges. </param>
        /// <param name="ipFamilies"> IP families are used to determine single-stack or dual-stack clusters. For single-stack, the expected value is IPv4. For dual-stack, the expected values are IPv4 and IPv6. </param>
        /// <param name="kubeProxyConfig"> Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy defaulting behavior. See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/ where &lt;version&gt; is represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be '1-23'. </param>
        internal ContainerServiceNetworkProfile(ContainerServiceNetworkPlugin? networkPlugin, ContainerServiceNetworkPluginMode? networkPluginMode, ContainerServiceNetworkPolicy? networkPolicy, ContainerServiceNetworkMode? networkMode, EbpfDataplane? ebpfDataplane, string podCidr, string serviceCidr, string dnsServiceIP, string dockerBridgeCidr, ContainerServiceOutboundType? outboundType, ContainerServiceLoadBalancerSku? loadBalancerSku, ManagedClusterLoadBalancerProfile loadBalancerProfile, ManagedClusterNatGatewayProfile natGatewayProfile, IList<string> podCidrs, IList<string> serviceCidrs, IList<IPFamily> ipFamilies, ContainerServiceNetworkProfileKubeProxyConfig kubeProxyConfig)
        {
            NetworkPlugin = networkPlugin;
            NetworkPluginMode = networkPluginMode;
            NetworkPolicy = networkPolicy;
            NetworkMode = networkMode;
            EbpfDataplane = ebpfDataplane;
            PodCidr = podCidr;
            ServiceCidr = serviceCidr;
            DnsServiceIP = dnsServiceIP;
            DockerBridgeCidr = dockerBridgeCidr;
            OutboundType = outboundType;
            LoadBalancerSku = loadBalancerSku;
            LoadBalancerProfile = loadBalancerProfile;
            NatGatewayProfile = natGatewayProfile;
            PodCidrs = podCidrs;
            ServiceCidrs = serviceCidrs;
            IPFamilies = ipFamilies;
            KubeProxyConfig = kubeProxyConfig;
        }

        /// <summary> Network plugin used for building the Kubernetes network. </summary>
        public ContainerServiceNetworkPlugin? NetworkPlugin { get; set; }
        /// <summary> Network plugin mode used for building the Kubernetes network. </summary>
        public ContainerServiceNetworkPluginMode? NetworkPluginMode { get; set; }
        /// <summary> Network policy used for building the Kubernetes network. </summary>
        public ContainerServiceNetworkPolicy? NetworkPolicy { get; set; }
        /// <summary> This cannot be specified if networkPlugin is anything other than 'azure'. </summary>
        public ContainerServiceNetworkMode? NetworkMode { get; set; }
        /// <summary> The eBPF dataplane used for building the Kubernetes network. </summary>
        public EbpfDataplane? EbpfDataplane { get; set; }
        /// <summary> A CIDR notation IP range from which to assign pod IPs when kubenet is used. </summary>
        public string PodCidr { get; set; }
        /// <summary> A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </summary>
        public string ServiceCidr { get; set; }
        /// <summary> An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </summary>
        public string DnsServiceIP { get; set; }
        /// <summary> A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the Kubernetes service address range. </summary>
        public string DockerBridgeCidr { get; set; }
        /// <summary> This can only be set at cluster creation time and cannot be changed later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype). </summary>
        public ContainerServiceOutboundType? OutboundType { get; set; }
        /// <summary> The default is 'standard'. See [Azure Load Balancer SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load balancer SKUs. </summary>
        public ContainerServiceLoadBalancerSku? LoadBalancerSku { get; set; }
        /// <summary> Profile of the cluster load balancer. </summary>
        public ManagedClusterLoadBalancerProfile LoadBalancerProfile { get; set; }
        /// <summary> Profile of the cluster NAT gateway. </summary>
        public ManagedClusterNatGatewayProfile NatGatewayProfile { get; set; }
        /// <summary> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </summary>
        public IList<string> PodCidrs { get; }
        /// <summary> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must not overlap with any Subnet IP ranges. </summary>
        public IList<string> ServiceCidrs { get; }
        /// <summary> IP families are used to determine single-stack or dual-stack clusters. For single-stack, the expected value is IPv4. For dual-stack, the expected values are IPv4 and IPv6. </summary>
        public IList<IPFamily> IPFamilies { get; }
        /// <summary> Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy defaulting behavior. See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/ where &lt;version&gt; is represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be '1-23'. </summary>
        public ContainerServiceNetworkProfileKubeProxyConfig KubeProxyConfig { get; set; }
    }
}
