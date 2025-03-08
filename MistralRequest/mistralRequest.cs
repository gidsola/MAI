using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using MAI.MistralConfig;

namespace MAI.MistralRequest
{
    internal class MistralChat
    {
        readonly HttpClient client = new();

        /// <summary>
        /// Creates a request message for the chat completion methods.
        /// </summary>
        /// <param name="content">User Input</param>
        /// <param name="stream">Perform streamed request?</param>
        /// <returns>HttpRequestMessage</returns>
        private HttpRequestMessage CreateChatRequestMessage(string content, bool? stream = false)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {MistralChatConfig.ChatConfig["ApiKey"]}");

                object body = new
                {
                    model = MistralChatConfig.ChatConfig["Model"],
                    top_p = MistralChatConfig.ChatConfig["Top_p"],
                    max_tokens = MistralChatConfig.ChatConfig["Max_tokens"],
                    stream,
                    safe_prompt = MistralChatConfig.ChatConfig["Safe_prompt"],
                    messages = new List<dynamic> {
                        new { role = "system", content = MistralChatConfig.ChatConfig["SystemPrompt"] },
                        new { role = "user", content }
                    }
                };

                return new(HttpMethod.Post, MistralChatConfig.ChatConfig["Endpoint"])
                {
                    Content = new StringContent(
                        JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                    )
                };
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while creating the request message:" + e.Message);
                return null;
            }
        }

        /// <summary>
        /// Performs the chat completion endpoint request.
        /// </summary>
        /// <param name="content"></param>
        /// <returns>
        /// Model response or an error.
        /// </returns>
        /// <see cref="https://docs.mistral.ai/api/#tag/chat/operation/chat_completion_v1_chat_completions_post"/>
        public async Task<string> ChatCompletion(string content)
        {
            try
            {
                using HttpRequestMessage requestMessage = CreateChatRequestMessage(content);
                if (requestMessage == null)
                {
                    return "null";
                }
                using HttpResponseMessage result = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead);
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<dynamic>(
                        await result.Content.ReadAsStringAsync()
                    ).choices[0].message.content;
                }
                return result.ReasonPhrase;
            }
            catch (Exception e)
            {
                return "error in requester: " + e;
            };
        }

        /// <summary>
        /// Performs a streamed chat completion endpoint request.
        /// </summary>
        /// <param name="content"></param>
        /// <returns>
        /// Model response or an error.
        /// </returns>
        /// <see cref="https://docs.mistral.ai/api/#tag/chat/operation/chat_completion_v1_chat_completions_post"/>
        public async Task<string> StreamingChatCompletion(string content)
        {
            try
            {
                using HttpRequestMessage requestMessage = CreateChatRequestMessage(content, true);
                if (requestMessage == null)
                {
                    return "null";
                }
                using HttpResponseMessage result = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead); // all for this guy..
                if (result.IsSuccessStatusCode)
                {
                    using StreamReader reader = new(await result.Content.ReadAsStreamAsync());
                    StringBuilder responseBuilder = new();
                    string chunk;

                    while ((chunk = await reader.ReadLineAsync()) != null)
                    { // i will never like this..
                        if (chunk.StartsWith("data: ") && chunk != "data: [DONE]")
                        {
                            dynamic item = JsonConvert.DeserializeObject(chunk.Substring("data: ".Length));
                            responseBuilder.Append(item.choices[0].delta.content);
                        };
                    };
                    return responseBuilder.ToString();
                };
                return result.ReasonPhrase;
            }
            catch (Exception e)
            {
                return "error in requester: " + e;
            };
        }
    };

    internal class MistralVision { }; // TODO
};
