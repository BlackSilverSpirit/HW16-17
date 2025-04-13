using UnityEngine;

public interface IReactionBehavior
{
    void Execute(Enemy enemy, Transform target);
}
