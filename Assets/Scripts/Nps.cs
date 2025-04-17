using UnityEngine;

public class Nps : Character
{
    [SerializeField] public DieEffect DieffectPrefab;

    [SerializeField] private DetectionZone _detectionZone;

    public int CurrentPatrolIndex;
    public Transform[] PatrolPoints;

    private PatrolRouteFinder _routeFinder;

    private IBehaviour _defenceBehaviour;
    private IBehaviour _reactionBehaviorType;
    private IBehaviour _currentBehaviour;

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

        if (_detectionZone == null || _detectionZone.IsAggro == false)
        {
            if (_defenceBehaviour != null)
                SwitchBehaviour(_defenceBehaviour);
        }
        else
        {
            if (_detectionZone.Target != null && _reactionBehaviorType != null)
                SwitchBehaviour(_reactionBehaviorType);
        }
    }

    private void FixYPosition()
    {
        Vector3 position = transform.position;
        position.y = 0;
        transform.position = position;
    }
    
    private void SwitchBehaviour(IBehaviour behaviour)
    {
        if (behaviour == null) 
            return;
        
        _currentBehaviour.Exit();
        _currentBehaviour = behaviour;
        _currentBehaviour.Enter();
    }

    public void InitializeSetBehaviors(IdleBehaviorType defenceBehaviour , ReactionBehaviorType reactionBehavior)
    {
        _defenceBehaviour = BehaviorCase.Create(defenceBehaviour, this);
        _reactionBehaviorType = ReactionBehaviorCase.Create(reactionBehavior, this, _detectionZone);
        _currentBehaviour = _defenceBehaviour;
        _currentBehaviour.Enter();
    }
}