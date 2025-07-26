using System.Text.Json.Serialization;
using System.Collections.Generic;
public class FeatureCollection
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
{
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Feature
{
    [JsonPropertyName("properties")]
    public FeatureProperties Properties { get; set; }
}

public class FeatureProperties
{
    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("mag")]
    public decimal Magnitude { get; set; }
}

