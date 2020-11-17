﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    internal partial struct RefTypeSyntaxWrapper : ISyntaxWrapper<TypeSyntax>
    {
        public RefTypeSyntaxWrapper WithRefKeyword(SyntaxToken refKeyword)
        {
            return new RefTypeSyntaxWrapper(WithRefKeywordAccessor(this.SyntaxNode, refKeyword));
        }

        public RefTypeSyntaxWrapper WithReadOnlyKeyword(SyntaxToken readOnlyKeyword)
        {
            return new RefTypeSyntaxWrapper(WithReadOnlyKeywordAccessor(this.SyntaxNode, readOnlyKeyword));
        }

        public RefTypeSyntaxWrapper WithType(TypeSyntax type)
        {
            return new RefTypeSyntaxWrapper(WithTypeAccessor(this.SyntaxNode, type));
        }
    }
}
