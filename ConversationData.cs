namespace Microsoft.BotBuilderSamples
{
    // Defines a state property used to track conversation data.
    public class ConversationData
    {
        // Track whether we have already asked the user's name
        public bool PromptedUserForName { get; set; } = false;
    }
}