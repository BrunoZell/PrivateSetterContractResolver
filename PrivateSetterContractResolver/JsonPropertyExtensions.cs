using Newtonsoft.Json.Serialization;
using System;

namespace PrivateSetterContractResolver {
    static class JsonPropertyExtensions {
        public static bool IsModifiable(this JsonProperty jsonProperty) {
            if (jsonProperty == null) {
                throw new ArgumentNullException(nameof(jsonProperty));
            }

            return jsonProperty.Readable && jsonProperty.Writable;
        }
    }
}
