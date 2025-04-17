using UnityEngine;

public static class ReactionBehaviorCase
{
    public static IBehaviour Create(ReactionBehaviorType type, Nps nps, DetectionZone detectionZone)
    {
        switch (type)
        {
            case ReactionBehaviorType.RunAway:
                return new RanAwayBehaviour(nps, detectionZone);
            case ReactionBehaviorType.Chase:
                return new ChaseBehaviour(nps, detectionZone);
            case ReactionBehaviorType.Die:
                return new DieBehaviour(nps);
            default: return new RanAwayBehaviour(nps, detectionZone);
        }
    }
}
