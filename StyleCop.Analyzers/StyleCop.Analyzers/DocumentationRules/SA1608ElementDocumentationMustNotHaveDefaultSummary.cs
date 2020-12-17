﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.DocumentationRules {
        using System;
        using System.Collections.Generic;
        using System.Collections.Immutable;
        using System.Linq;
        using System.Xml.Linq;
        using Microsoft.CodeAnalysis;
        using Microsoft.CodeAnalysis.CSharp.Syntax;
        using Microsoft.CodeAnalysis.Diagnostics;
        using StyleCop.Analyzers.Helpers;
        using StyleCop.Analyzers.Settings.ObjectModel;

        /// <summary>
        /// The <c>&lt;summary&gt;</c> tag within an element's XML header documentation contains the
        /// default text generated by Visual Studio during the creation of the element.
        /// </summary>
        /// <remarks>
        /// <para>C# syntax provides a mechanism for inserting documentation for classes and
        /// elements directly into the code, through the use of XML documentation headers.</para>
        ///
        /// <para>Visual Studio provides helper functionality for adding new elements such as
        /// classes to a project. Visual Studio will create a default documentation header for the
        /// new class and fill in this header with default documentation text.</para>
        ///
        /// <para>A violation of this rule occurs when the <c>&lt;summary&gt;</c> tag for a code
        /// element still contains the default documentation text generated by Visual Studio.</para>
        /// </remarks>
        [DiagnosticAnalyzer(LanguageNames.CSharp)]
        internal class SA1608ElementDocumentationMustNotHaveDefaultSummary
            : ElementDocumentationBase {
                /// <summary>
                /// The ID for diagnostics produced by the <see
                /// cref="SA1608ElementDocumentationMustNotHaveDefaultSummary"/> analyzer.
                /// </summary>
                public const string DiagnosticId = "SA1608";
                private const string HelpLink =
                    "https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1608.md";

                private const string DefaultText = "Summary description for";

                private static readonly LocalizableString Title = new LocalizableResourceString(
                    nameof(DocumentationResources.SA1608Title),
                    DocumentationResources.ResourceManager, typeof(DocumentationResources));
                private static readonly LocalizableString MessageFormat =
                    new LocalizableResourceString(
                        nameof(DocumentationResources.SA1608MessageFormat),
                        DocumentationResources.ResourceManager, typeof(DocumentationResources));
                private static readonly LocalizableString Description =
                    new LocalizableResourceString(nameof(DocumentationResources.SA1608Description),
                                                  DocumentationResources.ResourceManager,
                                                  typeof(DocumentationResources));

                private static readonly DiagnosticDescriptor Descriptor = new DiagnosticDescriptor(
                    DiagnosticId, Title, MessageFormat, AnalyzerCategory.DocumentationRules,
                    DiagnosticSeverity.Warning, AnalyzerConstants.EnabledByDefault, Description,
                    HelpLink);

                public SA1608ElementDocumentationMustNotHaveDefaultSummary()
                    : base(inheritDocSuppressesWarnings
                           : true, matchElementName
                           : XmlCommentHelper.SummaryXmlTag) {}

                /// <inheritdoc/>
                public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; }
                = ImmutableArray.Create(Descriptor);

                /// <inheritdoc/>
                protected override void HandleXmlElement(SyntaxNodeAnalysisContext context,
                                                         StyleCopSettings settings,
                                                         bool needsComment,
                                                         IEnumerable<XmlNodeSyntax> syntaxList,
                                                         params Location[] diagnosticLocations) {
                        foreach (var syntax in syntaxList) {
                                var summaryElement = syntax as XmlElementSyntax;
                                if (summaryElement?.Content.FirstOrDefault()
                                        is XmlTextSyntax textElement) {
                                        string text = XmlCommentHelper.GetText(textElement, true);

                                        if (IsDefaultText(text)) {
                                                context.ReportDiagnostic(Diagnostic.Create(
                                                    Descriptor, summaryElement.GetLocation()));
                                                return;
                                        }
                                }
                        }
                }

                /// <inheritdoc/>
                protected override void HandleCompleteDocumentation(
                    SyntaxNodeAnalysisContext context, bool needsComment,
                    XElement completeDocumentation, params Location[] diagnosticLocations) {
                        // We are working with an <include> element
                        var includedSummaryElement =
                            completeDocumentation.Nodes().OfType<XElement>().FirstOrDefault(
                                element => element.Name == XmlCommentHelper.SummaryXmlTag);
                        if (includedSummaryElement != null) {
                                string text = includedSummaryElement.Value;

                                if (IsDefaultText(text)) {
                                        context.ReportDiagnostic(Diagnostic.Create(
                                            Descriptor, diagnosticLocations.First()));
                                        return;
                                }
                        }
                }

                private static bool IsDefaultText(string text) {
                        if (!string.IsNullOrEmpty(text)) {
                                if (text.TrimStart().StartsWith(DefaultText,
                                                                StringComparison.Ordinal)) {
                                        return true;
                                }
                        }

                        return false;
                }
        }
}
