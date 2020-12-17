﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
        using Microsoft.CodeAnalysis;

        internal static class OperationKindEx {
                public const OperationKind Invalid = (OperationKind) 0x1;
                public const OperationKind Block = (OperationKind) 0x2;
                public const OperationKind VariableDeclarationGroup = (OperationKind) 0x3;
                public const OperationKind Switch = (OperationKind) 0x4;
                public const OperationKind Loop = (OperationKind) 0x5;
                public const OperationKind Labeled = (OperationKind) 0x6;
                public const OperationKind Branch = (OperationKind) 0x7;
                public const OperationKind Empty = (OperationKind) 0x8;
                public const OperationKind Return = (OperationKind) 0x9;
                public const OperationKind YieldBreak = (OperationKind) 0xa;
                public const OperationKind Lock = (OperationKind) 0xb;
                public const OperationKind Try = (OperationKind) 0xc;
                public const OperationKind Using = (OperationKind) 0xd;
                public const OperationKind YieldReturn = (OperationKind) 0xe;
                public const OperationKind ExpressionStatement = (OperationKind) 0xf;
                public const OperationKind LocalFunction = (OperationKind) 0x10;
                public const OperationKind Stop = (OperationKind) 0x11;
                public const OperationKind End = (OperationKind) 0x12;
                public const OperationKind RaiseEvent = (OperationKind) 0x13;
                public const OperationKind Literal = (OperationKind) 0x14;
                public const OperationKind Conversion = (OperationKind) 0x15;
                public const OperationKind Invocation = (OperationKind) 0x16;
                public const OperationKind ArrayElementReference = (OperationKind) 0x17;
                public const OperationKind LocalReference = (OperationKind) 0x18;
                public const OperationKind ParameterReference = (OperationKind) 0x19;
                public const OperationKind FieldReference = (OperationKind) 0x1a;
                public const OperationKind MethodReference = (OperationKind) 0x1b;
                public const OperationKind PropertyReference = (OperationKind) 0x1c;
                public const OperationKind EventReference = (OperationKind) 0x1e;
                public const OperationKind Unary = (OperationKind) 0x1f;
                public const OperationKind Binary = (OperationKind) 0x20;
                public const OperationKind Conditional = (OperationKind) 0x21;
                public const OperationKind Coalesce = (OperationKind) 0x22;
                public const OperationKind AnonymousFunction = (OperationKind) 0x23;
                public const OperationKind ObjectCreation = (OperationKind) 0x24;
                public const OperationKind TypeParameterObjectCreation = (OperationKind) 0x25;
                public const OperationKind ArrayCreation = (OperationKind) 0x26;
                public const OperationKind InstanceReference = (OperationKind) 0x27;
                public const OperationKind IsType = (OperationKind) 0x28;
                public const OperationKind Await = (OperationKind) 0x29;
                public const OperationKind SimpleAssignment = (OperationKind) 0x2a;
                public const OperationKind CompoundAssignment = (OperationKind) 0x2b;
                public const OperationKind Parenthesized = (OperationKind) 0x2c;
                public const OperationKind EventAssignment = (OperationKind) 0x2d;
                public const OperationKind ConditionalAccess = (OperationKind) 0x2e;
                public const OperationKind ConditionalAccessInstance = (OperationKind) 0x2f;
                public const OperationKind InterpolatedString = (OperationKind) 0x30;
                public const OperationKind AnonymousObjectCreation = (OperationKind) 0x31;
                public const OperationKind ObjectOrCollectionInitializer = (OperationKind) 0x32;
                public const OperationKind MemberInitializer = (OperationKind) 0x33;
                public const OperationKind CollectionElementInitializer = (OperationKind) 0x34;
                public const OperationKind NameOf = (OperationKind) 0x35;
                public const OperationKind Tuple = (OperationKind) 0x36;
                public const OperationKind DynamicObjectCreation = (OperationKind) 0x37;
                public const OperationKind DynamicMemberReference = (OperationKind) 0x38;
                public const OperationKind DynamicInvocation = (OperationKind) 0x39;
                public const OperationKind DynamicIndexerAccess = (OperationKind) 0x3a;
                public const OperationKind TranslatedQuery = (OperationKind) 0x3b;
                public const OperationKind DelegateCreation = (OperationKind) 0x3c;
                public const OperationKind DefaultValue = (OperationKind) 0x3d;
                public const OperationKind TypeOf = (OperationKind) 0x3e;
                public const OperationKind SizeOf = (OperationKind) 0x3f;
                public const OperationKind AddressOf = (OperationKind) 0x40;
                public const OperationKind IsPattern = (OperationKind) 0x41;
                public const OperationKind Increment = (OperationKind) 0x42;
                public const OperationKind Throw = (OperationKind) 0x43;
                public const OperationKind Decrement = (OperationKind) 0x44;
                public const OperationKind DeconstructionAssignment = (OperationKind) 0x45;
                public const OperationKind DeclarationExpression = (OperationKind) 0x46;
                public const OperationKind OmittedArgument = (OperationKind) 0x47;
                public const OperationKind FieldInitializer = (OperationKind) 0x48;
                public const OperationKind VariableInitializer = (OperationKind) 0x49;
                public const OperationKind PropertyInitializer = (OperationKind) 0x4a;
                public const OperationKind ParameterInitializer = (OperationKind) 0x4b;
                public const OperationKind ArrayInitializer = (OperationKind) 0x4c;
                public const OperationKind VariableDeclarator = (OperationKind) 0x4d;
                public const OperationKind VariableDeclaration = (OperationKind) 0x4e;
                public const OperationKind Argument = (OperationKind) 0x4f;
                public const OperationKind CatchClause = (OperationKind) 0x50;
                public const OperationKind SwitchCase = (OperationKind) 0x51;
                public const OperationKind CaseClause = (OperationKind) 0x52;
                public const OperationKind InterpolatedStringText = (OperationKind) 0x53;
                public const OperationKind Interpolation = (OperationKind) 0x54;
                public const OperationKind ConstantPattern = (OperationKind) 0x55;
                public const OperationKind DeclarationPattern = (OperationKind) 0x56;
                public const OperationKind TupleBinary = (OperationKind) 0x57;
                public const OperationKind MethodBody = (OperationKind) 0x58;
                public const OperationKind ConstructorBody = (OperationKind) 0x59;
                public const OperationKind Discard = (OperationKind) 0x5a;
                public const OperationKind FlowCapture = (OperationKind) 0x5b;
                public const OperationKind FlowCaptureReference = (OperationKind) 0x5c;
                public const OperationKind IsNull = (OperationKind) 0x5d;
                public const OperationKind CaughtException = (OperationKind) 0x5e;
                public const OperationKind StaticLocalInitializationSemaphore
                    = (OperationKind) 0x5f;
                public const OperationKind FlowAnonymousFunction = (OperationKind) 0x60;
                public const OperationKind CoalesceAssignment = (OperationKind) 0x61;
                public const OperationKind Range = (OperationKind) 0x63;
                public const OperationKind ReDim = (OperationKind) 0x65;
                public const OperationKind ReDimClause = (OperationKind) 0x66;
                public const OperationKind RecursivePattern = (OperationKind) 0x67;
                public const OperationKind DiscardPattern = (OperationKind) 0x68;
                public const OperationKind SwitchExpression = (OperationKind) 0x69;
                public const OperationKind SwitchExpressionArm = (OperationKind) 0x6a;
                public const OperationKind PropertySubpattern = (OperationKind) 0x6b;
                public const OperationKind UsingDeclaration = (OperationKind) 0x6c;
                public const OperationKind NegatedPattern = (OperationKind) 0x6d;
                public const OperationKind BinaryPattern = (OperationKind) 0x6e;
                public const OperationKind TypePattern = (OperationKind) 0x6f;
                public const OperationKind RelationalPattern = (OperationKind) 0x70;
                public const OperationKind With = (OperationKind) 0x71;
        }
}
