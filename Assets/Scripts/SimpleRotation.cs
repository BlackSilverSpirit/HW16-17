using UnityEngine;

public class SimpleRotation : IRotation
{
    public void Rotate(Transform transform, Vector3 direction, float speed)
    {
        Vector3 xzDirection = new Vector3(direction.x, 0, direction.z);
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        float step = speed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }
}
