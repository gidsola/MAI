
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MistralChatApp.MistralConfig {
    /// <summary>
    /// Mistral chat completion config class
    /// </summary>
    public partial class MistralChatConfig {
        /// <summary>
        /// Chat config object
        /// </summary>
        public static Dictionary<string, dynamic> ChatConfig { get; set; }

        /// <summary>
        /// Chat config initialization.
        /// </summary>
        public static void InitializeChatConfig() {

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
            };

        }
    };

    /// <summary>
    /// Pixtral vision completion config
    /// </summary>
    public class MistralVisionConfig { }; // TODO
};
