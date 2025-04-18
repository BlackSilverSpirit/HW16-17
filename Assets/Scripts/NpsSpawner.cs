using UnityEngine;

public class NpsSpawner : MonoBehaviour
{
    [SerializeField] private IdleBehaviorType idleBehaviorType;
    [SerializeField] private ReactionBehaviorType reactionBehaviorType;

    [SerializeField] private Nps npsPrefab;

    private Transform[] _patrolPoints;
    private Color _gizmoColor = Color.red;


    private PatrolRouteFinder _routeFinder;

    private void Awake()
    {
        _routeFinder = GetComponent<PatrolRouteFinder>();
        _patrolPoints = _routeFinder.PatrolTransforms;
    }

    void Start()
    {
        Nps newNps = Instantiate(npsPrefab, transform.position, Quaternion.identity);

        if (idleBehaviorType == IdleBehaviorType.Patrol)
        {
            newNps.PatrolPoints = _patrolPoints;
        }

        newNps.InitializeSetBehaviors(idleBehaviorType, reactionBehaviorType);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmoColor;
        Gizmos.DrawSphere(transform.position, 0.3f);
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}