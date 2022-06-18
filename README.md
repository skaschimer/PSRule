# PSRule

A cross-platform module to validate infrastructure as code (IaC) and objects using PowerShell rules.
PSRule works great and integrates with popular continuous integration (CI) systems.

[![Open in vscode.dev](https://img.shields.io/badge/Open%20in-vscode.dev-blue)][1]

Features of PSRule include:

- [DevOps][2] - Built to support DevOps culture and tools.
- [Extensible][3] - Define tests using YAML, JSON, or PowerShell format.
- [Reusable][4] - Reuse and share rules across teams or organizations.

  [1]: https://vscode.dev/github/microsoft/PSRule
  [2]: https://microsoft.github.io/PSRule/latest/features/#devops
  [3]: https://microsoft.github.io/PSRule/latest/features/#extensible
  [4]: https://microsoft.github.io/PSRule/latest/features/#reusable

## Project objectives

1. **Extensible**:
   - Provide an execution environment (tools and language) to validate infrastructure code.
   - Handling of common concerns such as input/ output/ reporting should be handled by the engine.
   - Language must be flexible enough to support a wide range of use cases.
2. **DevOps**:
   - Validation should support and enhance DevOps workflows by providing fast feedback in pull requests.
   - Allow quality gates to be implemented between environments such development, test, and production.
3. **Cross-platform**:
   - A wide range of platforms can be used to author and deploy infrastructure code.
PSRule must support rule validation and authoring on Linux, MacOS, and Windows.
   - Runs in a Linux container.
For continuous integration (CI) systems that do not support PowerShell, run in a container.
4. **Reusable**:
   - Validation should plug and play, reusable across teams and organizations.
   - Any reusable validation will have exceptions.
Rules must be able to be disabled where they are not applicable.

Continue reading the [PSRule design specification][5].

  [5]: docs/specs/design-spec.md

## Support

This project uses GitHub Issues to track bugs and feature requests.
Please search the existing issues before filing new issues to avoid duplicates.

- For new issues, file your bug or feature request as a new [issue][6].
- For help, discussion, and support questions about using this project, join or start a [discussion][7].

Support for this project/ product is limited to the resources listed above.

  [6]: https://github.com/Microsoft/PSRule/issues
  [7]: https://github.com/microsoft/PSRule/discussions

## Getting the module

You can download and install the PSRule module from the PowerShell Gallery.

Module | Description | Downloads / instructions
------ | ----------- | ------------------------
PSRule | Validate infrastructure as code (IaC) and objects using PowerShell rules. | [latest][module-psrule] / [instructions][install]

For rule and integration modules see [related projects](#related-projects).

## Getting extensions

Companion extensions are available for the following platforms.

Platform           | Description | Downloads / instructions
--------           | ----------- | ------------------------
Azure Pipelines    | Validate infrastructure as code (IaC) and DevOps repositories using Azure Pipelines. | [latest][extension-pipelines] / [instructions][install]
GitHub Actions     | Validate infrastructure as code (IaC) and DevOps repositories using GitHub Actions. | [latest][extension-actions] / [instructions][install]
Visual Studio Code | Visual Studio Code extension for PSRule. | [latest][extension-vscode] / [instructions][install]

## Getting started

For an quickstart example of using PSRule see [Create a standalone rule](https://microsoft.github.io/PSRule/v2/quickstart/standalone-rule/).
For specific use cases see [scenarios](#scenarios).

For frequently asked questions, see the [FAQ](https://microsoft.github.io/PSRule/v2/faq/).

### Scenarios

For walk through examples of PSRule usage see:

- [Validate Azure resource configuration](https://microsoft.github.io/PSRule/v2/scenarios/azure-resources/azure-resources/)
- [Validate Azure resources tags](https://microsoft.github.io/PSRule/v2/scenarios/azure-tags/azure-tags/)
- [Validate Kubernetes resources](https://microsoft.github.io/PSRule/v2/scenarios/kubernetes-resources/kubernetes-resources/)
- [Using within continuous integration](https://microsoft.github.io/PSRule/v2/scenarios/validation-pipeline/validation-pipeline/)
- [Packaging rules in a module](https://microsoft.github.io/PSRule/v2/authoring/packaging-rules/)
- [Writing rule help](https://microsoft.github.io/PSRule/v2/authoring/writing-rule-help/)

## Language reference

PSRule extends PowerShell with domain specific language (DSL) keywords, cmdlets and automatic variables.

### Keywords

The following language keywords are used by the `PSRule` module:

- [Rule](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#rule) - A rule definition.
- [Exists](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#exists) - Assert that a field or property must exist.
- [Match](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#match) - Assert that the field must match any of the regular expressions.
- [AnyOf](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#anyof) - Assert that any of the child expressions must be true.
- [AllOf](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#allof) - Assert that all of the child expressions must be true.
- [Within](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#within) - Assert that the field must match any of the values.
- [TypeOf](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#typeof) - Assert that the object must be of a specific type.
- [Reason](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#reason) - Return a reason for why the rule failed.
- [Recommend](https://microsoft.github.io/PSRule/v2/keywords/PSRule/en-US/about_PSRule_Keywords/#recommend) - Return a recommendation to resolve the issue and pass the rule.

### Commands

The following commands exist in the `PSRule` module:

- [Assert-PSRule](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Assert-PSRule/) - Evaluate objects against matching rules and assert any failures.
- [Export-PSRuleBaseline](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Export-PSRuleBaseline/) - Exports a list of baselines to a file.
- [Get-PSRule](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Get-PSRule/) - Get a list of rule definitions.
- [Get-PSRuleBaseline](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Get-PSRuleBaseline/) - Get a list of baselines.
- [Get-PSRuleHelp](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Get-PSRuleHelp/) - Get documentation for a rule.
- [Get-PSRuleTarget](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Get-PSRuleTarget/) - Get a list of target objects.
- [Invoke-PSRule](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Invoke-PSRule/) - Evaluate objects against matching rules and output the results.
- [New-PSRuleOption](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/New-PSRuleOption/) - Create options to configure PSRule execution.
- [Set-PSRuleOption](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Set-PSRuleOption/) - Sets options that configure PSRule execution.
- [Test-PSRuleTarget](https://microsoft.github.io/PSRule/v2/commands/PSRule/en-US/Test-PSRuleTarget/) - Pass or fail objects against matching rules.

### Concepts

The following conceptual topics exist in the `PSRule` module:

- [Assert](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/)
  - [Contains](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#contains)
  - [Count](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#count)
  - [EndsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#endswith)
  - [FileHeader](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#fileheader)
  - [FilePath](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#filepath)
  - [Greater](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#greater)
  - [GreaterOrEqual](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#greaterorequal)
  - [HasDefaultValue](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#hasdefaultvalue)
  - [HasField](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#hasfield)
  - [HasFields](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#hasfields)
  - [HasFieldValue](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#hasfieldvalue)
  - [HasJsonSchema](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#hasjsonschema)
  - [In](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#in)
  - [IsArray](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#isarray)
  - [IsBoolean](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#isboolean)
  - [IsDateTime](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#isdatetime)
  - [IsInteger](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#isinteger)
  - [IsLower](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#islower)
  - [IsNumeric](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#isnumeric)
  - [IsString](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#isstring)
  - [IsUpper](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#isupper)
  - [JsonSchema](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#jsonschema)
  - [Less](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#less)
  - [LessOrEqual](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#lessorequal)
  - [Like](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#like)
  - [Match](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#match)
  - [NotContains](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notcontains)
  - [NotCount](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notcount)
  - [NotEndsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notendswith)
  - [NotHasField](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#nothasfield)
  - [NotIn](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notin)
  - [NotLike](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notlike)
  - [NotMatch](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notmatch)
  - [NotNull](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notnull)
  - [NotStartsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notstartswith)
  - [NotWithinPath](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#notwithinpath)
  - [Null](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#null)
  - [NullOrEmpty](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#nullorempty)
  - [TypeOf](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#typeof)
  - [SetOf](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#setof)
  - [StartsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#startswith)
  - [Subset](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#subset)
  - [Version](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#version)
  - [WithinPath](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Assert/#withinpath)
- [Badges](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Badges/)
- [Baselines](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Baseline/)
  - [Baseline specs](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Baseline/#baseline-specs)
  - [Baseline scopes](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Baseline/#baseline-scopes)
- [Conventions](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Conventions/)
  - [Using conventions](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Conventions/#using-conventions)
  - [Defining conventions](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Conventions/#defining-conventions)
  - [Begin Process End blocks](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Conventions/#begin-process-end-blocks)
  - [Including with options](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Conventions/#including-with-options)
  - [Using within modules](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Conventions/#using-within-modules)
  - [Execution order](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Conventions/#execution-order)
- [Docs](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Docs/)
  - [Getting documentation](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Docs/#getting-documentation)
  - [Online help](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Docs/#online-help)
  - [Creating documentation](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Docs/#creating-documentation)
- [Expressions](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/)
  - [AllOf](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#allof)
  - [AnyOf](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#anyof)
  - [Contains](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#contains)
  - [Count](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#count)
  - [EndsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#endswith)
  - [Exists](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#exists)
  - [Equals](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#equals)
  - [Field](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#field)
  - [Greater](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#greater)
  - [GreaterOrEquals](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#greaterorequals)
  - [HasDefault](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#hasdefault)
  - [HasSchema](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#hasschema)
  - [HasValue](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#hasvalue)
  - [In](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#in)
  - [IsLower](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#islower)
  - [IsString](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#isstring)
  - [IsArray](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#isarray)
  - [IsBoolean](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#isboolean)
  - [IsDateTime](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#isdatetime)
  - [IsInteger](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#isinteger)
  - [IsNumeric](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#isnumeric)
  - [IsUpper](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#isupper)
  - [Less](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#less)
  - [LessOrEquals](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#lessorequals)
  - [Like](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#like)
  - [Match](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#match)
  - [Name](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#name)
  - [Not](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#not)
  - [NotContains](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notcontains)
  - [NotCount](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notcount)
  - [NotEndsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notendswith)
  - [NotEquals](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notequals)
  - [NotIn](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notin)
  - [NotLike](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notlike)
  - [NotMatch](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notmatch)
  - [NotStartsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notstartswith)
  - [NotWithinPath](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#notwithinpath)
  - [SetOf](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#setof)
  - [Source](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#source)
  - [StartsWith](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#startswith)
  - [Subset](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#subset)
  - [Type](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#type)
  - [WithinPath](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#withinpath)
  - [Version](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Expressions/#version)
- [Options](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/)
  - [Binding.Field](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#bindingfield)
  - [Binding.IgnoreCase](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#bindingignorecase)
  - [Binding.NameSeparator](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#bindingnameseparator)
  - [Binding.PreferTargetInfo](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#bindingprefertargetinfo)
  - [Binding.TargetName](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#bindingtargetname)
  - [Binding.TargetType](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#bindingtargettype)
  - [Binding.UseQualifiedName](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#bindingusequalifiedname)
  - [Configuration](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#configuration)
  - [Convention.Include](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#conventioninclude)
  - [Execution.AliasReferenceWarning](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#executionaliasreferencewarning)
  - [Execution.LanguageMode](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#executionlanguagemode)
  - [Execution.InconclusiveWarning](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#executioninconclusivewarning)
  - [Execution.NotProcessedWarning](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#executionnotprocessedwarning)
  - [Execution.SuppressedRuleWarning](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#executionsuppressedrulewarning)
  - [Execution.InvariantCultureWarning](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#executioninvariantculturewarning)
  - [Include.Module](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#includemodule)
  - [Include.Path](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#includepath)
  - [Input.Format](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#inputformat)
  - [Input.IgnoreGitPath](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#inputignoregitpath)
  - [Input.IgnoreObjectSource](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#inputignoreobjectsource)
  - [Input.IgnoreRepositoryCommon](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#inputignorerepositorycommon)
  - [Input.ObjectPath](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#inputobjectpath)
  - [Input.PathIgnore](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#inputpathignore)
  - [Input.TargetType](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#inputtargettype)
  - [Logging.LimitDebug](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#logginglimitdebug)
  - [Logging.LimitVerbose](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#logginglimitverbose)
  - [Logging.RuleFail](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#loggingrulefail)
  - [Logging.RulePass](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#loggingrulepass)
  - [Output.As](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputas)
  - [Output.Banner](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputbanner)
  - [Output.Culture](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputculture)
  - [Output.Encoding](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputencoding)
  - [Output.Footer](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputfooter)
  - [Output.Format](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputformat)
  - [Output.JsonIndent](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputjsonindent)
  - [Output.Outcome](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputoutcome)
  - [Output.Path](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputpath)
  - [Output.SarifProblemsOnly](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputsarifproblemsonly)
  - [Output.Style](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#outputstyle)
  - [Requires](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#requires)
  - [Rule.Baseline](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#rulebaseline)
  - [Rule.Include](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#ruleinclude)
  - [Rule.IncludeLocal](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#ruleincludelocal)
  - [Rule.Exclude](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#ruleexclude)
  - [Rule.Tag](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#ruletag)
  - [Suppression](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Options/#suppression)
- [Rules](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Rules/)
- [Selectors](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Selectors/)
- [Suppression Groups](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_SuppressionGroups/)
- [Variables](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Variables/)
  - [$Assert](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Variables/#assert)
  - [$Configuration](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Variables/#configuration)
  - [$LocalizedData](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Variables/#localizeddata)
  - [$PSRule](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Variables/#psrule)
  - [$Rule](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Variables/#rule)
  - [$TargetObject](https://microsoft.github.io/PSRule/v2/concepts/PSRule/en-US/about_PSRule_Variables/#targetobject)

### Schemas

PSRule uses the following schemas:

- [Options](schemas/PSRule-options.schema.json) - Schema for PSRule YAML options file.
- [Language](schemas/PSRule-language.schema.json) - Schema for PSRule resources such as baselines.
- [Resources](schemas/PSRule-resources.schema.json) - Schema for PSRule resources documents used with JSON.

## Related projects

For a list of projects and integrations see [Related projects](https://microsoft.github.io/PSRule/v2/related-projects/).

## Changes and versioning

Modules in this repository use [semantic versioning](https://semver.org/) to declare breaking changes.
For a list of module changes please see the [change log](CHANGELOG.md).

> Pre-release module versions are created on major commits and can be installed from the PowerShell Gallery.
> Pre-release versions should be considered experimental.
> Modules and change log details for pre-releases will be removed as stable releases are made available.

## Contributing

This project welcomes contributions and suggestions.
If you are ready to contribute, please visit the [contribution guide](CONTRIBUTING.md).

## Code of Conduct

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Maintainers

- [Bernie White](https://github.com/BernieWhite)
- [Armaan Mcleod](https://github.com/ArmaanMcleod)

## License

This project is [licensed under the MIT License](LICENSE).

[install]: https://microsoft.github.io/PSRule/v2/install-instructions/
[module-psrule]: https://www.powershellgallery.com/packages/PSRule
[extension-vscode]: https://marketplace.visualstudio.com/items?itemName=bewhite.psrule-vscode
[extension-pipelines]: https://marketplace.visualstudio.com/items?itemName=bewhite.ps-rule
[extension-actions]: https://github.com/marketplace/actions/psrule
