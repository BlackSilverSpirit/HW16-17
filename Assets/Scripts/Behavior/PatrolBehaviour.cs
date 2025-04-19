using UnityEngine;
using System.Collections.Generic;

public class PatrolBehaviour : IBehaviour
{
    private readonly Nps _nps;

    public PatrolBehaviour(Nps nps)
    {
        _nps = nps;
    }

    public void Enter()
    {
        if (_nps.PatrolPoints.Length == 0)
        {
            Debug.Log("No Patrol Points");
            return;
        }

        Update();
    }

    public void Update()
    {
        var direction = (_nps.PatrolPoints[_nps.CurrentPatrolIndex].position - _nps.transform.position).normalized;
        _nps.Movement(direction);

        if (Vector3.Distance(_nps.transform.position, _nps.PatrolPoints[_nps.CurrentPatrolIndex].position) < 0.5f)
        {
            _nps.CurrentPatrolIndex = (_nps.CurrentPatrolIndex + 1) % _nps.PatrolPoints.Length;
        }
    }

    public void Exit()
    {
    }
}