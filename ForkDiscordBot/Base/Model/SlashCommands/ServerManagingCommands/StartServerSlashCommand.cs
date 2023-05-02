﻿using Discord;
using Discord.WebSocket;
using ForkDiscordBot.Base.Logic;

namespace ForkDiscordBot.Base.Model.SlashCommands.ServerManagingCommands;

public class StartServerSlashCommand : GuildSlashCommand
{
    public StartServerSlashCommand(SlashCommandLogic logic, SocketGuild guild) : base(logic, guild)
    {
    }

    public override string Name => "start";
    public override string Description => "Starts the Minecraft Server with the given name";

    public override List<SlashCommandOptionBuilder> Parameters => BuildParameters();

    public override Task Execute(SocketSlashCommand command)
    {
        throw new NotImplementedException();
    }

    private List<SlashCommandOptionBuilder> BuildParameters()
    {
        var result = new List<SlashCommandOptionBuilder>();
        result.Add(new SlashCommandOptionBuilder()
            .WithName("name")
            .WithDescription("Name of the server")
            .WithType(ApplicationCommandOptionType.String)
            .WithRequired(true));
        // TODO CKE add choices for this guild
        return result;
    }
}