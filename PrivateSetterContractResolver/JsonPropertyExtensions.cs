using System;

namespace Newtonsoft.Json.Serialization
{
    internal static class JsonPropertyExtensions
    {
        public static bool IsModifiable(this JsonProperty jsonProperty)
        {
            if (jsonProperty == null) {
                throw new ArgumentNullException(nameof(jsonProperty));
            }

            return jsonProperty.Readable && jsonProperty.Writable;
        }
    }
}
