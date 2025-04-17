using UnityEngine;
using UnityEngine.Serialization;

public class NpsSpawner : MonoBehaviour
{
    [SerializeField] private IdleBehaviorType IdleBehaviorType;
    [SerializeField] private ReactionBehaviorType ReactionBehaviorType;

    [SerializeField] private Nps npsPrefab;
    private Transform[] _patrolPoints;
    private Color _gizmoColor = Color.red;

    void Start()
    {
        Nps newNps = Instantiate(npsPrefab, transform.position, Quaternion.identity);
        
        if (IdleBehaviorType == IdleBehaviorType.Patrol)
        {
            newNps.PatrolPoints = _patrolPoints;
        }

        newNps.InitializeSetBehaviors(IdleBehaviorType, ReactionBehaviorType);
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmoColor;
        Gizmos.DrawSphere(transform.position, 0.3f);
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}
