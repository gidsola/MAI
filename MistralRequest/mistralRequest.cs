using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using MistralChatApp.MistralConfig;
using System.IO;
using System.Data;

namespace MistralChatApp.MistralRequest {

    internal class MistralChat {

        readonly HttpClient client = new();

        /// <summary>
        /// Performs the chat completion endpoint request.
        /// </summary>
        /// <param name="content"></param>
        /// <returns>
        /// Model response or an error.
        /// </returns>
        /// <see cref="https://docs.mistral.ai/api/#tag/chat/operation/chat_completion_v1_chat_completions_post"/>
        public async Task<string> ChatCompletion(string content) {
            try {

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {MistralChatConfig.ChatConfig["ApiKey"]}");

                dynamic body = new {
                    model = MistralChatConfig.ChatConfig["Model"],
                    top_p = MistralChatConfig.ChatConfig["Top_p"],
                    max_tokens = MistralChatConfig.ChatConfig["Max_tokens"],
                    stream = MistralChatConfig.ChatConfig["Stream"],
                    safe_prompt = MistralChatConfig.ChatConfig["Safe_prompt"],
                    messages = new List<dynamic> {
                        new { role = "system", content = MistralChatConfig.ChatConfig["SystemPrompt"] },
                        new { role = "user", content }
                    }
                };

                using var result = await client.PostAsync(
                    MistralChatConfig.ChatConfig["Endpoint"],
                    new StringContent(
                        JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                    )
                );

                if (result.IsSuccessStatusCode) {
                    string responseString = await result.Content.ReadAsStringAsync();
                    dynamic responseObject = JsonConvert.DeserializeObject(responseString)!;
                    string response = responseObject.choices[0].message.content;
                    return response;
                }
                else throw new Exception("it didn't go vroom"); // change to reflect info from details
            }
            catch (Exception e) { // get specific; details from request when error
                return "error in requester: " + e;
            };
        }

        public async Task<string> StreamingChatCompletion(string content) {
            try {

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {MistralChatConfig.ChatConfig["ApiKey"]}");

                object body = new {
                    model = MistralChatConfig.ChatConfig["Model"],
                    top_p = MistralChatConfig.ChatConfig["Top_p"],
                    max_tokens = MistralChatConfig.ChatConfig["Max_tokens"],
                    stream = true,
                    safe_prompt = MistralChatConfig.ChatConfig["Safe_prompt"],
                    messages = new List<dynamic> {
                        new { role = "system", content = MistralChatConfig.ChatConfig["SystemPrompt"] },
                        new { role = "user", content }
                    }
                };

                using HttpRequestMessage request = new (HttpMethod.Post, MistralChatConfig.ChatConfig["Endpoint"]) {
                    Content = new StringContent(
                        JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                    )
                };

                using HttpResponseMessage result = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead); // all for this guy..
                if (result.IsSuccessStatusCode) {
                    using StreamReader reader = new (await result.Content.ReadAsStreamAsync());
                    StringBuilder responseBuilder = new ();
                    string chunk;

                    while ((chunk = await reader.ReadLineAsync()) != null) { // i will never like this..
                        if (chunk.StartsWith("data: ") && chunk != "data: [DONE]") {
                            dynamic item = JsonConvert.DeserializeObject(chunk.Substring("data: ".Length));
                            responseBuilder.Append(item.choices[0].delta.content);
                        };
                    };
                    return responseBuilder.ToString();
                };
                return result.ReasonPhrase;
            }
            catch (Exception e)
            { // get specific; details from request when error
                return "error in requester: " + e;
            };
        }
    };

    internal class MistralVision { }; // TODO
};
