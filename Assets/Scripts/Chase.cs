using UnityEngine;

public class Chase : IReactionBehavior
{
    public void Execute(Enemy enemy, Transform target)
    {
        Vector3 direction = (target.position - enemy.transform.position).normalized;
        enemy.Movement(direction);
    }
}

