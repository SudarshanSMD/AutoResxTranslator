﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;

namespace AutoResxTranslator
{
    /// <summary>
    /// Translation service using Microsoft Cogntive service.
    /// 
    /// ref: https://azure.microsoft.com/en-in/services/cognitive-services/translator-text-api/
    /// </summary>
    public class MSTranslateService
    {
        private static string host = "https://api-apc.cognitive.microsofttranslator.com";
        private static string subscriptionKey = "<YOUR-SUBSCRIPTION-KEY-HERE>";
        private static string region = "centralindia";

        public static async System.Threading.Tasks.Task<string> TranslateAsync(
            string text,
            string fromLanguage,
            string toLanguage)
        {
            if (fromLanguage.Equals("auto") || fromLanguage.Equals(""))
            {
                fromLanguage = null;
            }

            string route = "/translate?api-version=3.0&to=" + toLanguage + "&from=" + fromLanguage;

            try
            {
                object[] body = new object[] { new { Text = text } };
                var requestBody = JsonConvert.SerializeObject(body);

                using (var client = new HttpClient())
                using (var request = new HttpRequestMessage())
                {
                    // Build the request.
                    request.Method = HttpMethod.Post;
                    request.RequestUri = new Uri(host + route);
                    request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                    request.Headers.Add("Ocp-Apim-Subscription-Region", region);

                    // Send the request and get response.
                    HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // Read response as a string.
                        string resultFromMS = await response.Content.ReadAsStringAsync();
                        TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(resultFromMS);
                        // Iterate over the deserialized results.
                        foreach (TranslationResult o in deserializedOutput)
                        {
                            // Iterate over the results, return the first result
                            foreach (Translation t in o.Translations)
                            {
                                return t.Text;
                            }
                        }
                    }
                    else
                    {
                        return "Translation failed! Exception: " + response.ReasonPhrase;
                    }
                }
            }
            catch (Exception e)
            {
                return "Translation failed! Exception: " + e.Message;
            }
            return null;
        }
    }

    /// <summary>
    /// The C# classes that represents the JSON returned by the Translator Text API.
    /// </summary>
    public class TranslationResult
    {
        public DetectedLanguage DetectedLanguage { get; set; }
        public TextResult SourceText { get; set; }
        public Translation[] Translations { get; set; }
    }

    public class DetectedLanguage
    {
        public string Language { get; set; }
        public float Score { get; set; }
    }

    public class TextResult
    {
        public string Text { get; set; }
        public string Script { get; set; }
    }

    public class Translation
    {
        public string Text { get; set; }
        public TextResult Transliteration { get; set; }
        public string To { get; set; }
        public Alignment Alignment { get; set; }
        public SentenceLength SentLen { get; set; }
    }

    public class Alignment
    {
        public string Proj { get; set; }
    }

    public class SentenceLength
    {
        public int[] SrcSentLen { get; set; }
        public int[] TransSentLen { get; set; }
    }
}