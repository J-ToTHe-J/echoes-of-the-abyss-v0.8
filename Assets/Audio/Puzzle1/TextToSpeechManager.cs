using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EdenAI;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string provider = "openai";
        string text = "Which of the following sentences uses the correct form of the verb in the past perfect tense?";
        string audioFormat = "mp3";
        TextToSpeechOption option = TextToSpeechOption.FEMALE;
        string language = "en";
        string voiceModel = "en-US_Justin_Standard";

        EdenAIApi edenAI = new EdenAIApi();
        TextToSpeechResponse response = await edenAI.SendTextToSpeechRequest(provider,
            text, audioFormat, option, language, voiceModel: voiceModel);
    }
}
