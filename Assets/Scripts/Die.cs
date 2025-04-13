using UnityEngine;

public class Die : IReactionBehavior
{
    public void Execute(Enemy enemy, Transform target)
    {
        enemy.DieffectPrefab.transform.position = enemy.transform.position;
        enemy.DieffectPrefab.OnDieEffect();
        
        Object.Destroy(enemy.gameObject, 0.5f);
    }
}
