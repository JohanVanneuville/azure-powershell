// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// APIs for managing software update configurations.
    /// </summary>
    public partial class AutomationClient : ServiceClient<AutomationClient>, IAutomationClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the ISourceControlOperations.
        /// </summary>
        public virtual ISourceControlOperations SourceControl { get; private set; }

        /// <summary>
        /// Gets the IAgentRegistrationInformationOperations.
        /// </summary>
        public virtual IAgentRegistrationInformationOperations AgentRegistrationInformation { get; private set; }

        /// <summary>
        /// Gets the IDscNodeOperations.
        /// </summary>
        public virtual IDscNodeOperations DscNode { get; private set; }

        /// <summary>
        /// Gets the INodeReportsOperations.
        /// </summary>
        public virtual INodeReportsOperations NodeReports { get; private set; }

        /// <summary>
        /// Gets the IDscNodeConfigurationOperations.
        /// </summary>
        public virtual IDscNodeConfigurationOperations DscNodeConfiguration { get; private set; }

        /// <summary>
        /// Gets the IDscCompilationJobOperations.
        /// </summary>
        public virtual IDscCompilationJobOperations DscCompilationJob { get; private set; }

        /// <summary>
        /// Gets the IDscCompilationJobStreamOperations.
        /// </summary>
        public virtual IDscCompilationJobStreamOperations DscCompilationJobStream { get; private set; }

        /// <summary>
        /// Gets the ICertificateOperations.
        /// </summary>
        public virtual ICertificateOperations Certificate { get; private set; }

        /// <summary>
        /// Gets the ICredentialOperations.
        /// </summary>
        public virtual ICredentialOperations Credential { get; private set; }

        /// <summary>
        /// Gets the IJobScheduleOperations.
        /// </summary>
        public virtual IJobScheduleOperations JobSchedule { get; private set; }

        /// <summary>
        /// Gets the IScheduleOperations.
        /// </summary>
        public virtual IScheduleOperations Schedule { get; private set; }

        /// <summary>
        /// Gets the IActivityOperations.
        /// </summary>
        public virtual IActivityOperations Activity { get; private set; }

        /// <summary>
        /// Gets the IModuleOperations.
        /// </summary>
        public virtual IModuleOperations Module { get; private set; }

        /// <summary>
        /// Gets the IObjectDataTypesOperations.
        /// </summary>
        public virtual IObjectDataTypesOperations ObjectDataTypes { get; private set; }

        /// <summary>
        /// Gets the IFieldsOperations.
        /// </summary>
        public virtual IFieldsOperations Fields { get; private set; }

        /// <summary>
        /// Gets the IVariableOperations.
        /// </summary>
        public virtual IVariableOperations Variable { get; private set; }

        /// <summary>
        /// Gets the IConnectionOperations.
        /// </summary>
        public virtual IConnectionOperations Connection { get; private set; }

        /// <summary>
        /// Gets the IConnectionTypeOperations.
        /// </summary>
        public virtual IConnectionTypeOperations ConnectionType { get; private set; }

        /// <summary>
        /// Gets the ISourceControlSyncJobOperations.
        /// </summary>
        public virtual ISourceControlSyncJobOperations SourceControlSyncJob { get; private set; }

        /// <summary>
        /// Gets the ISourceControlSyncJobStreamsOperations.
        /// </summary>
        public virtual ISourceControlSyncJobStreamsOperations SourceControlSyncJobStreams { get; private set; }

        /// <summary>
        /// Gets the IDscConfigurationOperations.
        /// </summary>
        public virtual IDscConfigurationOperations DscConfiguration { get; private set; }

        /// <summary>
        /// Gets the IJobOperations.
        /// </summary>
        public virtual IJobOperations Job { get; private set; }

        /// <summary>
        /// Gets the IJobStreamOperations.
        /// </summary>
        public virtual IJobStreamOperations JobStream { get; private set; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationsOperations.
        /// </summary>
        public virtual ISoftwareUpdateConfigurationsOperations SoftwareUpdateConfigurations { get; private set; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationRunsOperations.
        /// </summary>
        public virtual ISoftwareUpdateConfigurationRunsOperations SoftwareUpdateConfigurationRuns { get; private set; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationMachineRunsOperations.
        /// </summary>
        public virtual ISoftwareUpdateConfigurationMachineRunsOperations SoftwareUpdateConfigurationMachineRuns { get; private set; }

        /// <summary>
        /// Gets the IAutomationAccountOperations.
        /// </summary>
        public virtual IAutomationAccountOperations AutomationAccount { get; private set; }

        /// <summary>
        /// Gets the IStatisticsOperations.
        /// </summary>
        public virtual IStatisticsOperations Statistics { get; private set; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        public virtual IUsagesOperations Usages { get; private set; }

        /// <summary>
        /// Gets the IKeysOperations.
        /// </summary>
        public virtual IKeysOperations Keys { get; private set; }

        /// <summary>
        /// Gets the IWebhookOperations.
        /// </summary>
        public virtual IWebhookOperations Webhook { get; private set; }

        /// <summary>
        /// Gets the IRunbookDraftOperations.
        /// </summary>
        public virtual IRunbookDraftOperations RunbookDraft { get; private set; }

        /// <summary>
        /// Gets the IRunbookOperations.
        /// </summary>
        public virtual IRunbookOperations Runbook { get; private set; }

        /// <summary>
        /// Gets the ITestJobStreamsOperations.
        /// </summary>
        public virtual ITestJobStreamsOperations TestJobStreams { get; private set; }

        /// <summary>
        /// Gets the ITestJobOperations.
        /// </summary>
        public virtual ITestJobOperations TestJob { get; private set; }

        /// <summary>
        /// Gets the IHybridRunbookWorkersOperations.
        /// </summary>
        public virtual IHybridRunbookWorkersOperations HybridRunbookWorkers { get; private set; }

        /// <summary>
        /// Gets the IHybridRunbookWorkerGroupOperations.
        /// </summary>
        public virtual IHybridRunbookWorkerGroupOperations HybridRunbookWorkerGroup { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AutomationClient.Dispose(). False: will not dispose provided httpClient</param>
        protected AutomationClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AutomationClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AutomationClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AutomationClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AutomationClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AutomationClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            SourceControl = new SourceControlOperations(this);
            AgentRegistrationInformation = new AgentRegistrationInformationOperations(this);
            DscNode = new DscNodeOperations(this);
            NodeReports = new NodeReportsOperations(this);
            DscNodeConfiguration = new DscNodeConfigurationOperations(this);
            DscCompilationJob = new DscCompilationJobOperations(this);
            DscCompilationJobStream = new DscCompilationJobStreamOperations(this);
            Certificate = new CertificateOperations(this);
            Credential = new CredentialOperations(this);
            JobSchedule = new JobScheduleOperations(this);
            Schedule = new ScheduleOperations(this);
            Activity = new ActivityOperations(this);
            Module = new ModuleOperations(this);
            ObjectDataTypes = new ObjectDataTypesOperations(this);
            Fields = new FieldsOperations(this);
            Variable = new VariableOperations(this);
            Connection = new ConnectionOperations(this);
            ConnectionType = new ConnectionTypeOperations(this);
            SourceControlSyncJob = new SourceControlSyncJobOperations(this);
            SourceControlSyncJobStreams = new SourceControlSyncJobStreamsOperations(this);
            DscConfiguration = new DscConfigurationOperations(this);
            Job = new JobOperations(this);
            JobStream = new JobStreamOperations(this);
            SoftwareUpdateConfigurations = new SoftwareUpdateConfigurationsOperations(this);
            SoftwareUpdateConfigurationRuns = new SoftwareUpdateConfigurationRunsOperations(this);
            SoftwareUpdateConfigurationMachineRuns = new SoftwareUpdateConfigurationMachineRunsOperations(this);
            AutomationAccount = new AutomationAccountOperations(this);
            Statistics = new StatisticsOperations(this);
            Usages = new UsagesOperations(this);
            Keys = new KeysOperations(this);
            Webhook = new WebhookOperations(this);
            RunbookDraft = new RunbookDraftOperations(this);
            Runbook = new RunbookOperations(this);
            TestJobStreams = new TestJobStreamsOperations(this);
            TestJob = new TestJobOperations(this);
            HybridRunbookWorkers = new HybridRunbookWorkersOperations(this);
            HybridRunbookWorkerGroup = new HybridRunbookWorkerGroupOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
