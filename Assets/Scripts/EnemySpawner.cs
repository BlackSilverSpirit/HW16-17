using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private Color _gizmoColor = Color.red;

    public IdleBehaviorType IdleBehaviorType;
    public ReactionBehaviorType ReactionBehaviorType;
    public Enemy EnemyPrefab;

    private Transform[] _patrolPoints;

    void Start()
    {
        Enemy newEnemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);

        newEnemy = newEnemy.GetComponent<Enemy>();

        newEnemy.InitializeSetBehaviors(IdleBehaviorType, ReactionBehaviorType);

        if (IdleBehaviorType == IdleBehaviorType.Patrol)
        {
            newEnemy.PatrolPoints = _patrolPoints;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmoColor;
        Gizmos.DrawSphere(transform.position, 0.3f);
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}
