using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using MistralChatApp.MistralConfig;

namespace MistralChatApp.MistralRequest {

    internal class MistralChat {

        readonly HttpClient client = new();
        readonly MistralChatConfig mistralChatConfig = new();

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
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {mistralChatConfig.ApiKey}");

                dynamic body = new {
                    model = mistralChatConfig.Model,
                    top_p = mistralChatConfig.Top_p,
                    max_tokens = mistralChatConfig.Max_tokens,
                    stream = mistralChatConfig.Stream,
                    safe_prompt = mistralChatConfig.Safe_prompt,
                    messages = new List<dynamic> {
                        new { role = "system", content = mistralChatConfig.SystemPrompt },
                        new { role = "user", content }
                    }
                };

                using var result = await client.PostAsync(
                    mistralChatConfig.Endpoint,
                    new StringContent(
                        JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                    )
                );

                if (result.IsSuccessStatusCode) {
                    string responseString = result.Content.ReadAsStringAsync().Result;// seems like a '.then' likely to change
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
    };

    internal class MistralVision { }; // TODO
};
