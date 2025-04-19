using UnityEngine;

public interface IRotation
{
    void Rotate(Transform transform, Vector3 direction, float speed);
}