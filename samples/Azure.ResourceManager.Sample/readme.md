# Azure.ResourceManager.Sample
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
azure-arm: true
require: $(this-folder)/../../readme.md
input-file: 
  - $(this-folder)/cdn.json
  - $(this-folder)/afdx.json
  - $(this-folder)/cdnwebapplicationfirewall.json
namespace: Azure.ResourceManager.Cdn
library-name: Cdn
clear-output-folder: true
skip-csproj: true
output-folder: Generated/
modelerfour:
  lenient-model-deduplication: true
operation-group-to-resource-type:
  NameAvailability: Microsoft.Cdn/checkNameAvailability
  Probe: Microsoft.Cdn/validateProbe
  ResourceUsage: Microsoft.Cdn/checkResourceUsage
  EdgeNodes: Microsoft.Cdn/edgenodes
  AFDProfilesUsage: Microsoft.Cdn/profiles/usages
  AFDProfilesHostName: Microsoft.Cdn/profiles/checkHostNameAvailability
  Validate: Microsoft.Cdn/validateSecret
  LogAnalyticsMetrics: Microsoft.Cdn/profiles/getLogAnalyticsMetrics
  LogAnalyticsRankings: Microsoft.Cdn/profiles/getLogAnalyticsRankings
  LogAnalyticsLocations: Microsoft.Cdn/profiles/getLogAnalyticsLocations
  LogAnalyticsResources: Microsoft.Cdn/profiles/getLogAnalyticsResources
  WafLogAnalyticsMetrics: Microsoft.Cdn/profiles/getWafLogAnalyticsMetrics
  WafLogAnalyticsRankings: Microsoft.Cdn/profiles/getWafLogAnalyticsRankings
  ManagedRuleSets: Microsoft.Cdn/CdnWebApplicationFirewallManagedRuleSets
operation-group-to-resource:
  NameAvailability: NonResource
  Probe: NonResource
  ResourceUsage: NonResource
  EdgeNodes: NonResource
  AFDProfilesUsage: NonResource
  AFDProfilesHostName: NonResource
  Validate: NonResource
  LogAnalyticsMetrics: NonResource
  LogAnalyticsRankings: NonResource
  LogAnalyticsLocations: NonResource
  LogAnalyticsResources: NonResource
  WafLogAnalyticsMetrics: NonResource
  WafLogAnalyticsRankings: NonResource
operation-group-to-parent:
  NameAvailability: tenant
  Probe: subscriptions
  ResourceUsage: subscriptions
  AFDProfilesUsage: Microsoft.Cdn/profiles
  AFDProfilesHostName: Microsoft.Cdn/profiles
  Validate: subscriptions
  Rules: Microsoft.Cdn/profiles/ruleSets
operation-groups-to-omit:
  RuleSets
directive:
  - from: swagger-document
    where: "$.definitions.DeliveryRuleAction.properties.name.x-ms-enum"
    transform: $.name="DeliveryRuleActionName"
```
