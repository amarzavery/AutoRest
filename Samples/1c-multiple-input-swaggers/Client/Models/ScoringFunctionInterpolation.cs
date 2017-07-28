// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Searchservice.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ScoringFunctionInterpolation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScoringFunctionInterpolation
    {
        [EnumMember(Value = "linear")]
        Linear,
        [EnumMember(Value = "constant")]
        Constant,
        [EnumMember(Value = "quadratic")]
        Quadratic,
        [EnumMember(Value = "logarithmic")]
        Logarithmic
    }
    internal static class ScoringFunctionInterpolationEnumExtension
    {
        internal static string ToSerializedValue(this ScoringFunctionInterpolation? value)  =>
            value == null ? null : ((ScoringFunctionInterpolation)value).ToSerializedValue();

        internal static string ToSerializedValue(this ScoringFunctionInterpolation value)
        {
            switch( value )
            {
                case ScoringFunctionInterpolation.Linear:
                    return "linear";
                case ScoringFunctionInterpolation.Constant:
                    return "constant";
                case ScoringFunctionInterpolation.Quadratic:
                    return "quadratic";
                case ScoringFunctionInterpolation.Logarithmic:
                    return "logarithmic";
            }
            return null;
        }

        internal static ScoringFunctionInterpolation? ParseScoringFunctionInterpolation(this string value)
        {
            switch( value )
            {
                case "linear":
                    return ScoringFunctionInterpolation.Linear;
                case "constant":
                    return ScoringFunctionInterpolation.Constant;
                case "quadratic":
                    return ScoringFunctionInterpolation.Quadratic;
                case "logarithmic":
                    return ScoringFunctionInterpolation.Logarithmic;
            }
            return null;
        }
    }
}
