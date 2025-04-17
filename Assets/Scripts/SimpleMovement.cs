using UnityEngine;

public class SimpleMovement : IMovement
{
    public void Move(Transform transform, Vector3 direction, float speed)
    {
        transform.Translate(direction * (speed * Time.deltaTime), Space.World);
    }
}
