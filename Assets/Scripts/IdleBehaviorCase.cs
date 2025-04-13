
public static class IdleBehaviorCase
{
    public static IIdleBehavior Create(IdleBehaviorType type)
    {
        switch (type)
        {
            case IdleBehaviorType.StandStill:
                return new StandartStill();
            case IdleBehaviorType.Patrol:
                return new Patrol();
            case IdleBehaviorType.RandomWalk:
                return new RandomWalk();
            default: return new StandartStill();
        }
    }
}
