using UnityEngine;

public class Enemy : Character
{
    [SerializeField] public DieEffect DieffectPrefab;

    [SerializeField] private DetectionZone _detectionZone;

    public int CurrentPatrolIndex;
    public Transform[] PatrolPoints;

    private PatrolRouteFinder _routeFinder;

    private IIdleBehavior _idleBehaviorType;
    private IReactionBehavior _reactionBehaviorType;

    protected override void Awake()
    {
        base.Awake();
        _routeFinder = GetComponent<PatrolRouteFinder>();
    }

    private void Start()
    {
        PatrolPoints = _routeFinder.PatrolTransforms;
    }

    public void Movement(Vector3 direction)
    {
        base.Move(direction);
    }

    protected override void ProcessMovement()
    {
        FixYPosition();

        if (_detectionZone.IsAggro == false)
            _idleBehaviorType.Execute(this);
        else
            _reactionBehaviorType.Execute(this, _detectionZone.Target);
    }

    private void FixYPosition()
    {
        Vector3 position = transform.position;
        position.y = 0;
        transform.position = position;
    }

    public void InitializeSetBehaviors(IdleBehaviorType idle, ReactionBehaviorType react)
    {
        _idleBehaviorType = IdleBehaviorCase.Create(idle);
        _reactionBehaviorType = ReactionBehaviorCase.Create(react);
    }
}