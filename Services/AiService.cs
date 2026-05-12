using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WinForms02.Models;

namespace WinForms02.Services;

public static class AiService
{
    private static readonly string helicopter = "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";
    public static async Task<string?> SendAsync(List<ChatMessage> messages)
    {
        using HttpClient client = new();
        client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", helicopter);
        client.DefaultRequestHeaders.Add("HTTP-Referer", "https://localhost");
        client.DefaultRequestHeaders.Add("X-OpenRouter-Title", "TOP GPT");

        var requestBody = new
        {
            model = "openrouter/free",
            messages = messages.Select(m => new
            {
                role = m.Role,
                content = m.Content
            }).ToArray(),
            temperature = 1.0
        };
        
        string json = JsonConvert.SerializeObject(requestBody);
        using StringContent content = new(json, Encoding.UTF8, "application/json");
        HttpResponseMessage res = 
            await client.PostAsync("https://openrouter.ai/api/v1/chat/completions", content);

        string responseJson = await res.Content.ReadAsStringAsync();
        if (!res.IsSuccessStatusCode)
        {
            MessageBox.Show($"Ошибка при запросе к API: {responseJson}");
            return null;
        }

        JObject data = JObject.Parse(responseJson);
        string? answer = data.SelectToken("choices[0].message.content")?.ToString();

        return answer;

    }
    
}
