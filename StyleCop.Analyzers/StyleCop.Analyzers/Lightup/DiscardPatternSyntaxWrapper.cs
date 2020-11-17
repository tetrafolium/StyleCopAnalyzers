﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;

    internal partial struct DiscardPatternSyntaxWrapper : ISyntaxWrapper<CSharpSyntaxNode>
    {
        public static explicit operator DiscardPatternSyntaxWrapper(PatternSyntaxWrapper node)
        {
            return (DiscardPatternSyntaxWrapper)node.SyntaxNode;
        }

        public static implicit operator PatternSyntaxWrapper(DiscardPatternSyntaxWrapper wrapper)
        {
            return PatternSyntaxWrapper.FromUpcast(wrapper.node);
        }

        public DiscardPatternSyntaxWrapper WithUnderscoreToken(SyntaxToken identifier)
        {
            return new DiscardPatternSyntaxWrapper(WithUnderscoreTokenAccessor(this.SyntaxNode, identifier));
        }
    }
}
