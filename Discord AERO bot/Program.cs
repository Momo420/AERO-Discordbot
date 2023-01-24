using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Discord_AERO_bot
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;
        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += LogAsync;

            await _client.LoginAsync(TokenType.Bot, Environment.GetEnvironmentVariable("AERO_BOT_TOKEN", EnvironmentVariableTarget.User));
            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
        private static Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());

            return Task.CompletedTask;
        }

    }
}
