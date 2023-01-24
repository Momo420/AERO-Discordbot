using System;
using Discord;
using Discord.Commands;
using System.Threading.Tasks;


namespace Discord_AERO_bot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        static Random rnd = new Random();
        
        [Command("noice?")]
        public async Task h1()
        {
            await Context.Channel.SendMessageAsync("Noice");
        }

        [Command("name")]
        public async Task h2(IGuildUser user)
        {
            await Context.Channel.SendMessageAsync(user.ToString());
        }
        [Command("help")]
        public async Task h3()
        {
            await Context.Channel.SendMessageAsync("This bot is just for fun.");
            await Context.Channel.SendMessageAsync("Commands:");
            await Context.Channel.SendMessageAsync(";;test => bot writes 'Noice'");
            await Context.Channel.SendMessageAsync($";;name => bot writes his name (name #0000)");
        }
        [Command("trink")]
        public async Task h4()
        {
            await Context.Channel.SendMessageAsync($"Trink {rnd.Next(1, 6)} mal");
        }
    }
}
