using UnityEngine;

public class RanAway : IReactionBehavior
{
    public void Execute(Enemy enemy, Transform target)
    {
        Vector3 direction = (enemy.transform.position - target.position).normalized;
        enemy.Movement(direction);
    }  
}