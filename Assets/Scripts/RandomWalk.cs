using UnityEngine;
public class RandomWalk : IIdleBehavior

{
    private Vector3 _randomDirection;
    private float _nextDirectionChangeTime;

    public void Execute(Enemy enemy)
    {
        if (Time.time >= _nextDirectionChangeTime)
        {
            _randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;

            _nextDirectionChangeTime = Time.time + 1f;  
        }

        enemy.Movement(_randomDirection);
    }  
}
