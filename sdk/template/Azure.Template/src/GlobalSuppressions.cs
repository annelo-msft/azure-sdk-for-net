// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "<Pending>", Scope = "type", Target = "~T:Azure.Template.TypeFormatters")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:Azure.Core.Pipeline.ClientDiagnostics.ExtractAzureErrorContent(System.String)~Azure.ResponseError")]
[assembly: SuppressMessage("Design", "CA1055:URI-like return values should not be strings", Justification = "<Pending>", Scope = "member", Target = "~M:Azure.Template.TypeFormatters.ToBase64UrlString(System.Byte[])~System.String")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:Azure.Template.TypeFormatters.ToBase64UrlString(System.Byte[])~System.String")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:Azure.Template.TypeFormatters.FromBase64UrlString(System.String)~System.Byte[]")]
