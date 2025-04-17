using UnityEngine;

public class RanAwayBehaviour : IBehaviour
{
    private Nps _nps;
    private DetectionZone _detectionZone;
    
    public RanAwayBehaviour(Nps nps, DetectionZone detectionZone)
    {
        _nps = nps;
        _detectionZone = detectionZone;
    }
    
    public void Enter()
    {
        Update();
    }

    public void Update()
    {
        var direction = (_nps.transform.position - _detectionZone.Target.position).normalized;
        _nps.Movement(direction);
    }

    public void Exit()
    {
        
    }
}