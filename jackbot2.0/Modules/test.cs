
using Discord;
using Discord.Commands;
using jack.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jackbotV2.Modules
{
    [Name("Owner")]
    public class test : ModuleBase
    {
        private static MemoryStream GenerateStreamFromString(string value)
        {
            return new MemoryStream(Encoding.Unicode.GetBytes(value ?? ""));
        }

        [Command("Archive"), Summary("Archives a channel and uploads a JSON"), Remarks("Archive #ChannelName 50")]
        public async Task ArchiveCommand(IMessageChannel Channel, int Amount = 9000)
        {
            if (Amount >= 10000)
            {
                await ReplyAsync("Amount must by less than 9000!");
                return;
            }

            var listOfMessages = new List<IMessage>(await Channel.GetMessagesAsync(Amount).Flatten());

            List<ArchiveModel> list = new List<ArchiveModel>(listOfMessages.Capacity);
            foreach (var message in listOfMessages) list.Add(new ArchiveModel
            {
                Author = message.Author.Username,
                Message = message.Content,
                Timestamp = message.Timestamp,
            });
            var jsonSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            var json = JsonConvert.SerializeObject(list, Formatting.Indented, jsonSettings);
            await (await Context.User.GetOrCreateDMChannelAsync()).SendFileAsync(GenerateStreamFromString(json), $"{Channel.Name}.json");
            await ReplyAsync($"{Channel.Name}'s Archive has been sent to your DM.");
        }

    }
}
