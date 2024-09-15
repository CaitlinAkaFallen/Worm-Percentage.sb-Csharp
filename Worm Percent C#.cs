using System;

public class CPHInline
{
    public bool Execute()
    {
        // Get arguments from Streamer.Bot
        CPH.TryGetArg("commandId", out Guid commandId);
        CPH.TryGetArg("rawInput", out string rawInput);
        CPH.TryGetArg("user", out string user);

        // Convert commandId to string for comparison
        string commandIdString = commandId.ToString();

        switch (commandIdString)
        {
            case "d9f72c39-9937-49ad-9645-f8fed63f426b": // Random Number Command
                // Generate a random number between 1 and 100
                Random rand = new Random();
                int randomNumber = rand.Next(1, 100);

                // Send a message back with the random number
                CPH.SendMessage($"Hey @{user},How worm are you but you are this much {randomNumber}% of worm you are.");

                break;

            default:
                CPH.SendMessage($"Unknown command: {commandIdString}");
                break;
        }

        return true;
    }
}