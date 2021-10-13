// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EnableState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnableState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class EnableStateEnumExtension
    {
        internal static string ToSerializedValue(this EnableState? value)
        {
            return value == null ? null : ((EnableState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EnableState value)
        {
            switch( value )
            {
                case EnableState.Enabled:
                    return "Enabled";
                case EnableState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static EnableState? ParseEnableState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return EnableState.Enabled;
                case "Disabled":
                    return EnableState.Disabled;
            }
            return null;
        }
    }
}
