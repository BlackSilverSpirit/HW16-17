public static class ReactionBehaviorCase
{
    public static IReactionBehavior Create(ReactionBehaviorType type)
    {
        switch (type)
        {
            case ReactionBehaviorType.RunAway:
                return new RanAway();
            case ReactionBehaviorType.Chase:
                return new Chase();
            case ReactionBehaviorType.Die:
                return new Die();
            default: return new RanAway();
        }
    }
}
