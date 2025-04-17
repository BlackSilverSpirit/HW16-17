using UnityEngine;
public class RandomWalkBehaviour : IBehaviour

{
    private Vector3 _randomDirection;
    private float _nextDirectionChangeTime;
    private readonly Transform _source;
    private Nps _nps;

    public RandomWalkBehaviour(Nps nps)
    {
        _nps = nps;
    }

    public void Enter()
    {
        Update();
    }

    public void Update()
    {
        if (Time.time >= _nextDirectionChangeTime)
        {
            _randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
        
            _nextDirectionChangeTime = Time.time + 1f;  
        }
        
        _nps.Movement(_randomDirection);
    }

    public void Exit()
    {

    }
}


