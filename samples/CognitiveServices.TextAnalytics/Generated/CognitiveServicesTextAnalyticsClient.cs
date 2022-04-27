// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using CognitiveServices.TextAnalytics.Models;

namespace CognitiveServices.TextAnalytics
{
    /// <summary> The CognitiveServicesTextAnalytics service client. </summary>
    public partial class CognitiveServicesTextAnalyticsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal CognitiveServicesTextAnalyticsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of CognitiveServicesTextAnalyticsClient for mocking. </summary>
        protected CognitiveServicesTextAnalyticsClient()
        {
        }

        /// <summary> Initializes a new instance of CognitiveServicesTextAnalyticsClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public CognitiveServicesTextAnalyticsClient(string endpoint, AzureKeyCredential credential, CognitiveServicesTextAnalyticsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new CognitiveServicesTextAnalyticsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "Ocp-Apim-Subscription-Key"));
            RestClient = new CognitiveServicesTextAnalyticsRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of CognitiveServicesTextAnalyticsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus.api.cognitive.microsoft.com). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal CognitiveServicesTextAnalyticsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new CognitiveServicesTextAnalyticsRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> The API returns a list of general named entities in a given document. For the list of supported entity types, check &lt;a href=&quot;https://aka.ms/taner&quot;&gt;Supported Entity Types in Text Analytics API&lt;/a&gt;. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EntitiesResult>> EntitiesRecognitionGeneralAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.EntitiesRecognitionGeneral");
            scope.Start();
            try
            {
                return await RestClient.EntitiesRecognitionGeneralAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of general named entities in a given document. For the list of supported entity types, check &lt;a href=&quot;https://aka.ms/taner&quot;&gt;Supported Entity Types in Text Analytics API&lt;/a&gt;. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EntitiesResult> EntitiesRecognitionGeneral(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.EntitiesRecognitionGeneral");
            scope.Start();
            try
            {
                return RestClient.EntitiesRecognitionGeneral(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of recognized entities with links to a well-known knowledge base. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EntityLinkingResult>> EntitiesLinkingAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.EntitiesLinking");
            scope.Start();
            try
            {
                return await RestClient.EntitiesLinkingAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of recognized entities with links to a well-known knowledge base. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EntityLinkingResult> EntitiesLinking(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.EntitiesLinking");
            scope.Start();
            try
            {
                return RestClient.EntitiesLinking(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of strings denoting the key phrases in the input text. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. Documents can now contain a language field to indicate the text language. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyPhraseResult>> KeyPhrasesAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.KeyPhrases");
            scope.Start();
            try
            {
                return await RestClient.KeyPhrasesAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of strings denoting the key phrases in the input text. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. Documents can now contain a language field to indicate the text language. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyPhraseResult> KeyPhrases(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.KeyPhrases");
            scope.Start();
            try
            {
                return RestClient.KeyPhrases(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns the detected language and a numeric score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LanguageResult>> LanguagesAsync(LanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.Languages");
            scope.Start();
            try
            {
                return await RestClient.LanguagesAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns the detected language and a numeric score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LanguageResult> Languages(LanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.Languages");
            scope.Start();
            try
            {
                return RestClient.Languages(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a sentiment prediction, as well as sentiment scores for each sentiment class (Positive, Negative, and Neutral) for the document and each sentence within it. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SentimentResponse>> SentimentAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.Sentiment");
            scope.Start();
            try
            {
                return await RestClient.SentimentAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a sentiment prediction, as well as sentiment scores for each sentiment class (Positive, Negative, and Neutral) for the document and each sentence within it. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain input and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SentimentResponse> Sentiment(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CognitiveServicesTextAnalyticsClient.Sentiment");
            scope.Start();
            try
            {
                return RestClient.Sentiment(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
