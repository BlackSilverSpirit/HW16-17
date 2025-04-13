using UnityEngine;

public interface IMovement
{
    void Move(Transform transform, Vector3 direction, float speed);
}
