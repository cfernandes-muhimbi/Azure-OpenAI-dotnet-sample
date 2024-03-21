# Azure-OpenAI-dotnet-sample
Basic code sample for Azure OpenAI api in C#

1. [What is Azure Open AI](#azure-openai-dotnet-sample)
2. [Prerequisites](#prerequisites)
3. [Important Concepts](#important-concepts)
   - [Temperature](#temperature)
   - [Nucleus Sampling](#nucleus-sampling)
   - [Frequency Penalty](#frequency-penalty)


### Check out the YouTube video:

[![Check out our latest video](https://i9.ytimg.com/vi_webp/uxuVny6cfBM/mq1.webp?sqp=CODb8q8G-oaymwEmCMACELQB8quKqQMa8AEB-AH-CYAC0AWKAgwIABABGCIgVih_MA8=&rs=AOn4CLDryPifRFUpElZNkWCDdXGSipbDPg)](https://www.youtube.com/watch?v=uxuVny6cfBM)




# What is Azure Open AI<a name="What is Azure Open AI"></a>

Azure OpenAI Service is an Azure AI service that allows access to OpenAI GPT-4, GPT-3, Codex, DALL-E, and Whisper models. Azure OpenAI Service provides REST API access to OpenAI’s powerful language models, which can be invoked by the programing language of your choice.

#  Prerequisites<a name="prerequisites"></a>

- .NET Framework 4.7.2 SDK or later.
- An IDE (Integrated Development Environment such as Visual Studio 2022).
- Power Automate for desktop v2.32 or later.
- The Actions SDK.

# Important Concepts<a name="important-concepts"></a>


### Temperature <a name="temperature"></a>

- In the context of Azure's OpenAI services, "temperature" refers to a parameter used in text generation models, such as GPT (Generative Pre-trained Transformer), to control the randomness of the generated text. Temperature influences the diversity and creativity of the generated text.
- When the temperature is low, the model tends to produce more predictable and conservative outputs, favoring high-confidence predictions.
- In contrast, higher temperatures introduce more randomness and diversity, allowing the model to explore a wider range of possibilities and generate more varied and imaginative text.
- In practical terms, adjusting the temperature allows users to fine-tune the balance between sticking closely to the input data (low temperature) and generating more novel and creative responses (high temperature).
- This parameter can be particularly useful for tasks like text generation, where a balance between coherence and creativity is desired.

### Nucleus sampling<a name="nucleus-sampling"></a>

- The nucleus sampling factor determines the size of the subset, or nucleus, of the probability distribution from which words are sampled
- Adjusting the nucleus sampling factor allows users to control the diversity In Azure's OpenAI services, "Nucleus Sampling Factor" is a parameter used in text generation models like GPT (Generative Pre-trained Transformer) to control the diversity of the generated text. - Nucleus sampling, also known as top-p sampling, is a method used during text generation to select the next word from a probability distribution over the vocabulary.
- Adjusting the nucleus sampling factor allows users to control the diversity of the generated text. A smaller factor results in more conservative sampling, favoring high-probability words and producing more predictable outputs. Conversely, a larger factor increases - diversity by allowing the model to consider a wider range of words, potentially leading to more creative and varied text generation.
- Overall, the nucleus sampling factor provides users with a flexible mechanism to fine-tune the balance between coherence and novelty in the generated text, depending on their specific preferences and application requirements.

### Frequency Penalty<a name="frequency-penalty"></a>

- In Azure's OpenAI services, "Frequency Penalty" is a parameter used in text generation models like GPT (Generative Pre-trained Transformer) to discourage repetitive or redundant text in generated outputs. 
- When generating text, the model may sometimes produce repetitive sequences or duplicate phrases, which can lead to less diverse and engaging outputs. Frequency Penalty addresses this issue by penalizing the model for repeatedly selecting the same words or phrases within a certain context window.
- The Frequency Penalty parameter allows users to control the degree to which repetitive text is discouraged. A higher frequency penalty imposes a stronger penalty on repeated words or phrases, encouraging the model to generate more diverse and varied outputs by avoiding redundancy. Conversely, a lower frequency penalty results in less discouragement of repetition, which may lead to more repetitive outputs.
- By adjusting the Frequency Penalty, users can fine-tune the balance between coherence and diversity in the generated text, ensuring that the model produces outputs that are both fluent and engaging. This parameter is particularly useful for tasks where generating novel and diverse text is important, such as creative writing, dialogue generation, and content creation.

Thank your for reading....



