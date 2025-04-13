using UnityEngine;

public class Die : IReactionBehavior
{
    public Vector3 targetScale = Vector3.one * 2f;
    public Vector3 initialScale;

    public void Execute(Enemy enemy, Transform target)
    {
        enemy.DieffectPrefab.transform.position = enemy.transform.position;
        enemy.DieffectPrefab.OnDieEffect();
        
        GameObject.Destroy(enemy.gameObject, 0.5f);
    }
}
