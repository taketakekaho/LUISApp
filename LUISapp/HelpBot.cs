using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Microsoft.Bot.Sample.HelpBot
{
    [LuisModel("your Luis ID", "your Luis key")]
    [Serializable]
    public class HelpBotDialog : LuisDialog<object>
    {

        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string message = $"ごめんなさい。勉強不足でわかりませんでした。\n\n推測されるキーワードは次のものです。？\n\n" + string.Join(", ", result.Intents.Select(i => i.Intent)　+ "\n\n再度言い換えて入力してもらえるでしょうか。");
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("Broken")]
        [LuisIntent("NotConnect")]
        public async Task Broken(IDialogContext context, LuisResult result)
        {
            string message;
            if (result.Entities.Count == 0)
            {
                 message = ($"何のトラブルですか？もう一度、言い換えて教えてもらえませんか？");
            } else { 
                message = ($"" + result.Entities[0].Entity + "のトラブルですね。\n\n");
                message = message + ($"[こちら](https://www.google.co.jp/search?q="+ result.Entities[0].Entity + "のトラブル)を参照ください。");
            }
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }
    }
}