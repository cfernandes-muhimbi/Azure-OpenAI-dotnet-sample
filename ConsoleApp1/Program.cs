// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Note: The Azure OpenAI client library for .NET is in preview.
// Install the .NET library via NuGet: dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.5
using Azure;
using Azure.AI.OpenAI;
using System.Configuration;

string sAttr;
sAttr = ConfigurationManager.AppSettings.Get("Key0");

string sUri;
sUri = ConfigurationManager.AppSettings.Get("KeyURI");

string sKeyModelName;
sKeyModelName = ConfigurationManager.AppSettings.Get("KeyModelName");

OpenAIClient client = new OpenAIClient(
  new Uri(sUri),
  new AzureKeyCredential(sUri));

Response<ChatCompletions> responseWithoutStream = await client.GetChatCompletionsAsync(
sKeyModelName,
new ChatCompletionsOptions()
{
    Messages =
  {
      new ChatMessage(ChatRole.System, "James Blunt Your beautiful song Lyrics"),

  },
    Temperature = (float)0.7,
    MaxTokens = 800,


    NucleusSamplingFactor = (float)0.95,
    FrequencyPenalty = 0,
    PresencePenalty = 0,
});


ChatCompletions response = responseWithoutStream.Value;
Console.WriteLine(response.Choices[0].Message.Content);
