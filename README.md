# PrivateSetterContractResolver
This small library provides a JSON.Net contract resolver to (de-)serialize properties with private setters or getter-only auto properties on a model.

    Install-Package PrivateSetterContractResolver

You can activate the contract resolver using the JsonSettings when (de-)serializing json:

```c#
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

JsonSerializerSettings settings = new JsonSerializerSettings() {
    ContractResolver = new PrivateSetterContractResolver()
};

// Use constructor to instantiate the model object
ApiResult model = new ApiResult("Error message");

// Serialize using public getters of the properties
string serialized = JsonConvert.SerializeObject(model, settings);
// { "success": false, "errorMessage": "Error message" }

// Deserialize by using no constructor and directly setting the backing field of the getter-only auto properties
model = JsonConvert.DeserializeObject<Model>(serialized, settings);
// model has same state right after instantiation
```

This contract resolver will not invoke any constructor when deserializing. The combination of setting getter-only auto properties and not using any initialization allows for a very resticted model class for creating valid model instances at runtime without affecting the deserialization process of the receiver. An example would be:

```c#
public class ApiResult {
    /// <summary>
    /// Creates a successful result with no error message.
    /// </summary>
    public ApiResult() {
        // This default constructor will NOT be called on deserialization
        Success = true;
    }

    /// <summary>
    /// Creates a failed result with <paramref name="errorMessage"/> as message.
    /// </summary>
    /// <param name="errorMessage">The error message</param>
    public ApiResult(string errorMessage) {
        Success = false;
        ErrorMessage = errorMessage;
    }

    public bool Success { get; }
    public string ErrorMessage { get; }
}
```

This model implements a default constructor in which the model is set in a successful state. This parameterless constructor would be called by default and the Success-Property wouldn't be changed to it's real value anymore since it's a getter-only auto property. With the PrivateSetterContractResolver however no constructor will be called at all and the getter-only property will be set to the correct value.

Using uninitialized objects can be dangerous, so use this contract resolver only in places where initialization is generally not needed (like in serializing api models).
