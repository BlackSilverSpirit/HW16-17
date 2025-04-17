using UnityEngine;

public class ChaseBehaviour : IBehaviour
{
    private Nps _nps;
    private DetectionZone _detectionZone;
    
    public ChaseBehaviour(Nps nps, DetectionZone detectionZone)
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
        Vector3 direction = (_detectionZone.Target.position - _nps.transform.position).normalized;
        _nps.Movement(direction);
    }

    public void Exit()
    {
        
    }
}

