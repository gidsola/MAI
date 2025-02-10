
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MistralChatApp.MistralConfig {
    /// <summary>
    /// Mistral chat completion config
    /// </summary>
    public partial class MistralChatConfig {
        /// <summary>
        /// Provides updated info to instanced classes. Likely to replace the constructed public set.
        /// </summary>
        public static Dictionary<string, dynamic> ChatConfig { get; set; }
        public string SystemPrompt { get; set; }
        public string ApiKey { get; set; }
        public string Endpoint { get; set; }
        public string Model { get; set; }
        public double Top_p { get; set; }
        public int Max_tokens { get; set; }
        public bool Stream { get; set; }
        public bool Safe_prompt { get; set; }
        public MistralChatConfig() {

            if (File.Exists("config.json")) {
                string json = File.ReadAllText("config.json");
                ChatConfig = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            }
            else {
                ChatConfig = new Dictionary<string, dynamic> {
                    { "SystemPrompt", "You are a polite, personal assistant. Answer concisely and accurately." },
                    { "ApiKey", "ENTER API KEY HERE" },
                    { "Model", "mistral-small-latest" },
                    { "Endpoint", "https://api.mistral.ai/v1/chat/completions" },
                    { "Top_p", 0.87 },
                    { "Max_tokens", 1048 },
                    { "Stream", false },
                    { "Safe_prompt", false }
                };
            }

            SystemPrompt = ChatConfig["SystemPrompt"];
            ApiKey = ChatConfig["ApiKey"];
            Endpoint = ChatConfig["Endpoint"];
            Model = ChatConfig["Model"];
            Top_p = ChatConfig["Top_p"];
            Max_tokens = (int)ChatConfig["Max_tokens"];
            Stream = ChatConfig["Stream"];
            Safe_prompt = ChatConfig["Safe_prompt"];

        }
    };

    /// <summary>
    /// Pixtral vision completion config
    /// </summary>
    public class MistralVisionConfig { }; // TODO
};
