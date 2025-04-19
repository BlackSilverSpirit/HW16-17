using UnityEngine;

public static class BehaviorCase
{
    public static IBehaviour Create(IdleBehaviorType type, Nps nps)
    {
        switch (type)
        {
            case IdleBehaviorType.StandStill:
                return new StandartStillBehaviour();
            case IdleBehaviorType.Patrol:
                return new PatrolBehaviour(nps);
            case IdleBehaviorType.RandomWalk:
                return new RandomWalkBehaviour(nps);
            default: return new StandartStillBehaviour();
        }
    }
}