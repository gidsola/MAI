using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MAI.GetImgApi
{
    internal class GetImg
    {
        private readonly HttpClient client = new();
        private const string apiKey = "";
        private const string baseUrl = "https://api.getimg.ai/v1/";

        private HttpRequestMessage CreateImageGenRequestMessage(string family, string model, string prompt)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                string endpoint = $"{baseUrl + family}/text-to-image";

                // stable_diffusion
                object body = new
                {
                    model,
                    prompt,
                    negative_prompt = "text, labels, disfigured, deformation, ugly, blurry, missing limbs, missing legs, missing arms, JPEG artifacts, multiple eyes, multiple fingers, multiple arms, multiple legs, multiple heads, multiple bodies, multiple faces, multiple mouths, multiple noses, multiple ears, multiple hands, multiple feet, multiple tails, multiple wings, multiple horns, multiple fins, multiple tentacles, multiple paws, multiple claws, multiple hooves, multiple antlers, multiple tusks, multiple beaks, multiple snouts, multiple trunks",
                    width = 768,
                    height = 768,
                    steps = 50,
                    //seed= 0,
                    guidance = 1.5,
                    output_format = "png",
                };

                return new(HttpMethod.Post, endpoint)
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

        public async Task<string> CreateImage(string family, string model, string prompt)
        {
            try
            {
                using HttpRequestMessage requestMessage = CreateImageGenRequestMessage(family, model, prompt);
                if (requestMessage == null)
                {
                    return "null";
                }
                using HttpResponseMessage result = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead);
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<dynamic>(
                        await result.Content.ReadAsStringAsync()
                    );

                }
                return result.ReasonPhrase;
            }
            catch (Exception e)
            {
                return "error in requester: " + e;
            };
        }
    };
};
