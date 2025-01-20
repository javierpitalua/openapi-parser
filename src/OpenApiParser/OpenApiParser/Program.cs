using System;
using OpenApiParser.Core;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Example JSON string (in real scenarios, this can be loaded from a file or API)
string openApiJson = File.ReadAllText("openapi.json");

// Parse the OpenAPI JSON metadata
var apiMetadata = Metadata.ParseOpenApiJson(openApiJson);

// Display some basic API info
Metadata.DisplayApiInfo(apiMetadata);

// Display paths
Metadata.DisplayPaths(apiMetadata);