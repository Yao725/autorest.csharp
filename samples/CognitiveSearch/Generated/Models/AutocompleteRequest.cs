// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> Parameters for fuzzy matching, and other autocomplete query behaviors. </summary>
    public partial class AutocompleteRequest
    {
        /// <summary> Initializes a new instance of AutocompleteRequest. </summary>
        /// <param name="searchText"> The search text on which to base autocomplete results. </param>
        /// <param name="suggesterName"> The name of the suggester as specified in the suggesters collection that&apos;s part of the index definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchText"/> or <paramref name="suggesterName"/> is null. </exception>
        public AutocompleteRequest(string searchText, string suggesterName)
        {
            Argument.AssertNotNull(searchText, nameof(searchText));
            Argument.AssertNotNull(suggesterName, nameof(suggesterName));

            SearchText = searchText;
            SuggesterName = suggesterName;
        }

        /// <summary> The search text on which to base autocomplete results. </summary>
        public string SearchText { get; }
        /// <summary> Specifies the mode for Autocomplete. The default is &apos;oneTerm&apos;. Use &apos;twoTerms&apos; to get shingles and &apos;oneTermWithContext&apos; to use the current context while producing auto-completed terms. </summary>
        public AutocompleteMode? AutocompleteMode { get; set; }
        /// <summary> An OData expression that filters the documents used to produce completed terms for the Autocomplete result. </summary>
        public string Filter { get; set; }
        /// <summary> A value indicating whether to use fuzzy matching for the autocomplete query. Default is false. When set to true, the query will autocomplete terms even if there&apos;s a substituted or missing character in the search text. While this provides a better experience in some scenarios, it comes at a performance cost as fuzzy autocomplete queries are slower and consume more resources. </summary>
        public bool? UseFuzzyMatching { get; set; }
        /// <summary> A string tag that is appended to hit highlights. Must be set with highlightPreTag. If omitted, hit highlighting is disabled. </summary>
        public string HighlightPostTag { get; set; }
        /// <summary> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. If omitted, hit highlighting is disabled. </summary>
        public string HighlightPreTag { get; set; }
        /// <summary> A number between 0 and 100 indicating the percentage of the index that must be covered by an autocomplete query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 80. </summary>
        public double? MinimumCoverage { get; set; }
        /// <summary> The comma-separated list of field names to consider when querying for auto-completed terms. Target fields must be included in the specified suggester. </summary>
        public string SearchFields { get; set; }
        /// <summary> The name of the suggester as specified in the suggesters collection that&apos;s part of the index definition. </summary>
        public string SuggesterName { get; }
        /// <summary> The number of auto-completed terms to retrieve. This must be a value between 1 and 100. The default is 5. </summary>
        public int? Top { get; set; }
    }
}
