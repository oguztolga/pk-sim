﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceSoap
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.n11.com/ws/schemas", ConfigurationName="ServiceReferenceSoap.CityServicePort")]
    public interface CityServicePort
    {
        
        // CODEGEN: Generating message contract since the operation GetCities is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReferenceSoap.GetCitiesResponse1 GetCities(ServiceReferenceSoap.GetCitiesRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetCitiesResponse1> GetCitiesAsync(ServiceReferenceSoap.GetCitiesRequest1 request);
        
        // CODEGEN: Generating message contract since the operation GetCity is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReferenceSoap.GetCityResponse1 GetCity(ServiceReferenceSoap.GetCityRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetCityResponse1> GetCityAsync(ServiceReferenceSoap.GetCityRequest1 request);
        
        // CODEGEN: Generating message contract since the operation GetNeighborhoods is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReferenceSoap.GetNeighborhoodsResponse1 GetNeighborhoods(ServiceReferenceSoap.GetNeighborhoodsRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetNeighborhoodsResponse1> GetNeighborhoodsAsync(ServiceReferenceSoap.GetNeighborhoodsRequest1 request);
        
        // CODEGEN: Generating message contract since the operation GetDistrict is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReferenceSoap.GetDistrictResponse1 GetDistrict(ServiceReferenceSoap.GetDistrictRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetDistrictResponse1> GetDistrictAsync(ServiceReferenceSoap.GetDistrictRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetCitiesRequest
    {
        
        private Authentication authField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Authentication auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.n11.com/ws/schemas")]
    public partial class Authentication
    {
        
        private string appKeyField;
        
        private string appSecretField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string appKey
        {
            get
            {
                return this.appKeyField;
            }
            set
            {
                this.appKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string appSecret
        {
            get
            {
                return this.appSecretField;
            }
            set
            {
                this.appSecretField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.n11.com/ws/schemas")]
    public partial class DistrictData
    {
        
        private string nameField;
        
        private long idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.n11.com/ws/schemas")]
    public partial class NeighborhoodData
    {
        
        private string nameField;
        
        private long idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.n11.com/ws/schemas")]
    public partial class CityData
    {
        
        private string cityCodeField;
        
        private long cityIdField;
        
        private string cityNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long cityId
        {
            get
            {
                return this.cityIdField;
            }
            set
            {
                this.cityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string cityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.n11.com/ws/schemas")]
    public partial class ResultInfo
    {
        
        private string statusField;
        
        private string errorCodeField;
        
        private string errorMessageField;
        
        private string errorCategoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string errorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public string errorCategory
        {
            get
            {
                return this.errorCategoryField;
            }
            set
            {
                this.errorCategoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetCitiesResponse
    {
        
        private ResultInfo resultField;
        
        private CityData[] citiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResultInfo result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("city", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CityData[] cities
        {
            get
            {
                return this.citiesField;
            }
            set
            {
                this.citiesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCitiesRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetCitiesRequest GetCitiesRequest;
        
        public GetCitiesRequest1()
        {
        }
        
        public GetCitiesRequest1(ServiceReferenceSoap.GetCitiesRequest GetCitiesRequest)
        {
            this.GetCitiesRequest = GetCitiesRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCitiesResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetCitiesResponse GetCitiesResponse;
        
        public GetCitiesResponse1()
        {
        }
        
        public GetCitiesResponse1(ServiceReferenceSoap.GetCitiesResponse GetCitiesResponse)
        {
            this.GetCitiesResponse = GetCitiesResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetCityRequest
    {
        
        private string cityCodeField;
        
        private Authentication authField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer", Order=0)]
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Authentication auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetCityResponse
    {
        
        private ResultInfo resultField;
        
        private CityData cityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResultInfo result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public CityData city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCityRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetCityRequest GetCityRequest;
        
        public GetCityRequest1()
        {
        }
        
        public GetCityRequest1(ServiceReferenceSoap.GetCityRequest GetCityRequest)
        {
            this.GetCityRequest = GetCityRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCityResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetCityResponse GetCityResponse;
        
        public GetCityResponse1()
        {
        }
        
        public GetCityResponse1(ServiceReferenceSoap.GetCityResponse GetCityResponse)
        {
            this.GetCityResponse = GetCityResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetNeighborhoodsRequest
    {
        
        private long districtIdField;
        
        private Authentication authField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long districtId
        {
            get
            {
                return this.districtIdField;
            }
            set
            {
                this.districtIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Authentication auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetNeighborhoodsResponse
    {
        
        private ResultInfo resultField;
        
        private NeighborhoodData[] neighborhoodsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResultInfo result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("neighborhood", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public NeighborhoodData[] neighborhoods
        {
            get
            {
                return this.neighborhoodsField;
            }
            set
            {
                this.neighborhoodsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNeighborhoodsRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetNeighborhoodsRequest GetNeighborhoodsRequest;
        
        public GetNeighborhoodsRequest1()
        {
        }
        
        public GetNeighborhoodsRequest1(ServiceReferenceSoap.GetNeighborhoodsRequest GetNeighborhoodsRequest)
        {
            this.GetNeighborhoodsRequest = GetNeighborhoodsRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNeighborhoodsResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetNeighborhoodsResponse GetNeighborhoodsResponse;
        
        public GetNeighborhoodsResponse1()
        {
        }
        
        public GetNeighborhoodsResponse1(ServiceReferenceSoap.GetNeighborhoodsResponse GetNeighborhoodsResponse)
        {
            this.GetNeighborhoodsResponse = GetNeighborhoodsResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetDistrictRequest
    {
        
        private string cityCodeField;
        
        private Authentication authField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer", Order=0)]
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Authentication auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetDistrictResponse
    {
        
        private ResultInfo resultField;
        
        private DistrictData[] districtsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResultInfo result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("district", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public DistrictData[] districts
        {
            get
            {
                return this.districtsField;
            }
            set
            {
                this.districtsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDistrictRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetDistrictRequest GetDistrictRequest;
        
        public GetDistrictRequest1()
        {
        }
        
        public GetDistrictRequest1(ServiceReferenceSoap.GetDistrictRequest GetDistrictRequest)
        {
            this.GetDistrictRequest = GetDistrictRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDistrictResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public ServiceReferenceSoap.GetDistrictResponse GetDistrictResponse;
        
        public GetDistrictResponse1()
        {
        }
        
        public GetDistrictResponse1(ServiceReferenceSoap.GetDistrictResponse GetDistrictResponse)
        {
            this.GetDistrictResponse = GetDistrictResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface CityServicePortChannel : ServiceReferenceSoap.CityServicePort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class CityServicePortClient : System.ServiceModel.ClientBase<ServiceReferenceSoap.CityServicePort>, ServiceReferenceSoap.CityServicePort
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CityServicePortClient() : 
                base(CityServicePortClient.GetDefaultBinding(), CityServicePortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CityServicePortSoap11.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CityServicePortClient(EndpointConfiguration endpointConfiguration) : 
                base(CityServicePortClient.GetBindingForEndpoint(endpointConfiguration), CityServicePortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CityServicePortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CityServicePortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CityServicePortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CityServicePortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CityServicePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceSoap.GetCitiesResponse1 ServiceReferenceSoap.CityServicePort.GetCities(ServiceReferenceSoap.GetCitiesRequest1 request)
        {
            return base.Channel.GetCities(request);
        }
        
        public ServiceReferenceSoap.GetCitiesResponse GetCities(ServiceReferenceSoap.GetCitiesRequest GetCitiesRequest)
        {
            ServiceReferenceSoap.GetCitiesRequest1 inValue = new ServiceReferenceSoap.GetCitiesRequest1();
            inValue.GetCitiesRequest = GetCitiesRequest;
            ServiceReferenceSoap.GetCitiesResponse1 retVal = ((ServiceReferenceSoap.CityServicePort)(this)).GetCities(inValue);
            return retVal.GetCitiesResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetCitiesResponse1> ServiceReferenceSoap.CityServicePort.GetCitiesAsync(ServiceReferenceSoap.GetCitiesRequest1 request)
        {
            return base.Channel.GetCitiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceSoap.GetCitiesResponse1> GetCitiesAsync(ServiceReferenceSoap.GetCitiesRequest GetCitiesRequest)
        {
            ServiceReferenceSoap.GetCitiesRequest1 inValue = new ServiceReferenceSoap.GetCitiesRequest1();
            inValue.GetCitiesRequest = GetCitiesRequest;
            return ((ServiceReferenceSoap.CityServicePort)(this)).GetCitiesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceSoap.GetCityResponse1 ServiceReferenceSoap.CityServicePort.GetCity(ServiceReferenceSoap.GetCityRequest1 request)
        {
            return base.Channel.GetCity(request);
        }
        
        public ServiceReferenceSoap.GetCityResponse GetCity(ServiceReferenceSoap.GetCityRequest GetCityRequest)
        {
            ServiceReferenceSoap.GetCityRequest1 inValue = new ServiceReferenceSoap.GetCityRequest1();
            inValue.GetCityRequest = GetCityRequest;
            ServiceReferenceSoap.GetCityResponse1 retVal = ((ServiceReferenceSoap.CityServicePort)(this)).GetCity(inValue);
            return retVal.GetCityResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetCityResponse1> ServiceReferenceSoap.CityServicePort.GetCityAsync(ServiceReferenceSoap.GetCityRequest1 request)
        {
            return base.Channel.GetCityAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceSoap.GetCityResponse1> GetCityAsync(ServiceReferenceSoap.GetCityRequest GetCityRequest)
        {
            ServiceReferenceSoap.GetCityRequest1 inValue = new ServiceReferenceSoap.GetCityRequest1();
            inValue.GetCityRequest = GetCityRequest;
            return ((ServiceReferenceSoap.CityServicePort)(this)).GetCityAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceSoap.GetNeighborhoodsResponse1 ServiceReferenceSoap.CityServicePort.GetNeighborhoods(ServiceReferenceSoap.GetNeighborhoodsRequest1 request)
        {
            return base.Channel.GetNeighborhoods(request);
        }
        
        public ServiceReferenceSoap.GetNeighborhoodsResponse GetNeighborhoods(ServiceReferenceSoap.GetNeighborhoodsRequest GetNeighborhoodsRequest)
        {
            ServiceReferenceSoap.GetNeighborhoodsRequest1 inValue = new ServiceReferenceSoap.GetNeighborhoodsRequest1();
            inValue.GetNeighborhoodsRequest = GetNeighborhoodsRequest;
            ServiceReferenceSoap.GetNeighborhoodsResponse1 retVal = ((ServiceReferenceSoap.CityServicePort)(this)).GetNeighborhoods(inValue);
            return retVal.GetNeighborhoodsResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetNeighborhoodsResponse1> ServiceReferenceSoap.CityServicePort.GetNeighborhoodsAsync(ServiceReferenceSoap.GetNeighborhoodsRequest1 request)
        {
            return base.Channel.GetNeighborhoodsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceSoap.GetNeighborhoodsResponse1> GetNeighborhoodsAsync(ServiceReferenceSoap.GetNeighborhoodsRequest GetNeighborhoodsRequest)
        {
            ServiceReferenceSoap.GetNeighborhoodsRequest1 inValue = new ServiceReferenceSoap.GetNeighborhoodsRequest1();
            inValue.GetNeighborhoodsRequest = GetNeighborhoodsRequest;
            return ((ServiceReferenceSoap.CityServicePort)(this)).GetNeighborhoodsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceSoap.GetDistrictResponse1 ServiceReferenceSoap.CityServicePort.GetDistrict(ServiceReferenceSoap.GetDistrictRequest1 request)
        {
            return base.Channel.GetDistrict(request);
        }
        
        public ServiceReferenceSoap.GetDistrictResponse GetDistrict(ServiceReferenceSoap.GetDistrictRequest GetDistrictRequest)
        {
            ServiceReferenceSoap.GetDistrictRequest1 inValue = new ServiceReferenceSoap.GetDistrictRequest1();
            inValue.GetDistrictRequest = GetDistrictRequest;
            ServiceReferenceSoap.GetDistrictResponse1 retVal = ((ServiceReferenceSoap.CityServicePort)(this)).GetDistrict(inValue);
            return retVal.GetDistrictResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceSoap.GetDistrictResponse1> ServiceReferenceSoap.CityServicePort.GetDistrictAsync(ServiceReferenceSoap.GetDistrictRequest1 request)
        {
            return base.Channel.GetDistrictAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceSoap.GetDistrictResponse1> GetDistrictAsync(ServiceReferenceSoap.GetDistrictRequest GetDistrictRequest)
        {
            ServiceReferenceSoap.GetDistrictRequest1 inValue = new ServiceReferenceSoap.GetDistrictRequest1();
            inValue.GetDistrictRequest = GetDistrictRequest;
            return ((ServiceReferenceSoap.CityServicePort)(this)).GetDistrictAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CityServicePortSoap11))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CityServicePortSoap11))
            {
                return new System.ServiceModel.EndpointAddress("https://api.n11.com/ws/cityService/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CityServicePortClient.GetBindingForEndpoint(EndpointConfiguration.CityServicePortSoap11);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CityServicePortClient.GetEndpointAddress(EndpointConfiguration.CityServicePortSoap11);
        }
        
        public enum EndpointConfiguration
        {
            
            CityServicePortSoap11,
        }
    }
}