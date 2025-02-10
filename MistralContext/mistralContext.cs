using System;
using System.Threading.Tasks;
using System.IO;

namespace MistralChatApp.MistralContext {
    internal class MessageHistory {
        public static async Task AddPair() {
            string docPath = "./";//Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using StreamWriter outputFile = new(Path.Combine(docPath, "WriteTextAsync.txt"));
            await outputFile.WriteAsync("This is a sentence.");

        }
    };
};
