using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float _baseSpeed = 10;
    protected float _rotationSpeed = 100;

    protected float _deadZone = 0.1f;

    protected IMovement _movement;
    protected IRotation _rotation;

    protected virtual void Awake()
    {
        _movement = new SimpleMovement();
        _rotation = new SimpleRotation();
    }

    protected void Update()
    {
        ProcessMovement();
    }

    protected abstract void ProcessMovement();

    protected virtual void Move(Vector3 direction)
    {
        if (direction.magnitude <= _deadZone)
            return;

        Vector3 normalizedDirection = direction.normalized;

        _movement.Move(transform, normalizedDirection, _baseSpeed);
        _rotation.Rotate(transform, normalizedDirection, _rotationSpeed);
    }

    public void SetMovement(IMovement strategy)
    {
        _movement = strategy;
    }

    public void SetRotation(IRotation strategy)
    {
        _rotation = strategy;
    }
}