using UnityEngine;

public class Patrol : IIdleBehavior
{
    public void Execute(Enemy enemy)
    {
        if (enemy.PatrolPoints.Length == 0) return;

        Vector3 direction = (enemy.PatrolPoints[enemy.CurrentPatrolIndex].position - enemy.transform.position).normalized;
        enemy.Movement(direction);

        if (Vector3.Distance(enemy.transform.position, enemy.PatrolPoints[enemy.CurrentPatrolIndex].position) < 0.5f)
        {
            enemy.CurrentPatrolIndex = (enemy.CurrentPatrolIndex + 1) % enemy.PatrolPoints.Length;
        }
    }
}




