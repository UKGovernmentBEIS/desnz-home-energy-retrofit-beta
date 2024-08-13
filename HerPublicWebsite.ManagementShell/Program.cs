﻿using HerPublicWebsite.Data;
using Microsoft.EntityFrameworkCore;

namespace HerPublicWebsite.ManagementShell;

public static class Program
{
    public static void Main(string[] args)
    {
        var outputProvider = new OutputProvider();
        var contextOptions = new DbContextOptionsBuilder<HerDbContext>()
            .UseNpgsql(
                Environment.GetEnvironmentVariable("ConnectionStrings__PostgreSQLConnection") ??
                @"UserId=postgres;Password=postgres;Server=localhost;Port=5432;Database=herdev;Integrated Security=true;Include Error Detail=true;Pooling=true")
            .Options;
        using var context = new HerDbContext(contextOptions);
        var databaseOperation = new DatabaseOperation(context, outputProvider);
        var fakeReferralGenerator = new FakeReferralGenerator();
        var commandHandler = new CommandHandler(databaseOperation, fakeReferralGenerator, outputProvider);

        Subcommand command;
        string[] subcommandArgs;

        try
        {
            command = Enum.Parse<Subcommand>(args[0], true);
            subcommandArgs = args.Skip(1).ToArray();
        }
        catch (Exception)
        {
            var allSubcommands = string.Join(", ", Enum.GetValues<Subcommand>());
            outputProvider.Output(
                $"Please specify a valid subcommand - available options are: {allSubcommands}");
            return;
        }

        switch (command)
        {
            case Subcommand.GenerateReferrals:
                commandHandler.GenerateReferrals(subcommandArgs);
                return;
            default:
                outputProvider.Output("Invalid terminal command entered. Please refer to the documentation");
                return;
        }
    }

    private enum Subcommand
    {
        GenerateReferrals
    }
}