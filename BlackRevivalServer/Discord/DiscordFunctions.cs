using Discord;
using Discord.WebSocket;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Discord
{
    public static class DiscordFunctions
    {
        public static string CurrentBuild;
        public static async Task SetBotStatusAsync(DiscordSocketClient client)
        {
            JObject config = GetConfig();

            string currently = config["currently"]?.Value<string>().ToLower();
            string statusText = config["playing_status"]?.Value<string>();
            string onlineStatus = config["status"]?.Value<string>().ToLower();
            string currentBuild = config["build"]?.Value<string>().ToLower();

            string title = config["online_title"]?.Value<string>();
            string message = config["online_message"]?.Value<string>();

            CurrentBuild = currentBuild;
            // Set the online status
            if (!string.IsNullOrEmpty(onlineStatus))
            {
                UserStatus userStatus = onlineStatus switch
                {
                    "dnd" => UserStatus.DoNotDisturb,
                    "idle" => UserStatus.Idle,
                    "offline" => UserStatus.Invisible,
                    _ => UserStatus.Online
                };

                await client.SetStatusAsync(userStatus);
                Console.WriteLine($"{DateTime.Now.TimeOfDay:hh\\:mm\\:ss} | Online status set | {userStatus}");
            }

            // Set the playing status
            if (!string.IsNullOrEmpty(currently) && !string.IsNullOrEmpty(statusText))
            {
                ActivityType activity = currently switch
                {
                    "listening" => ActivityType.Listening,
                    "watching" => ActivityType.Watching,
                    "streaming" => ActivityType.Streaming,
                    _ => ActivityType.Playing
                };

                await client.SetGameAsync(statusText, type: activity);

                //                Alpha build updated!!!
                //Version
                //7.12(r7046)
                //Let's dance 🕺 💃

                EmbedBuilder embed = new EmbedBuilder()
               .WithColor(0, 225, 225)
               .WithTitle(title)
               .WithDescription(
                   $"**Build:** **{currentBuild}**\n" +
                    $"{message}");

                await client.GetGuild(1030924692770525294).GetTextChannel(1037223795922059295).SendMessageAsync($"", embed: embed.Build());
                Console.WriteLine($"{DateTime.Now.TimeOfDay:hh\\:mm\\:ss} | Playing status set | {activity}: {statusText}");
            }
        }

        public static JObject GetConfig()
        {
            // Get the config file.
            using StreamReader configJson = new StreamReader(Directory.GetCurrentDirectory() + @"/Config.json");
            return (JObject)JsonConvert.DeserializeObject(configJson.ReadToEnd());
        }

        public static string GetAvatarUrl(SocketUser user, ushort size = 1024)
        {
            // Get user avatar and resize it. If the user has no avatar, get the default Discord avatar.
            return user.GetAvatarUrl(size: size) ?? user.GetDefaultAvatarUrl();
        }
    }
}
