using System;
using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    private float _aggroRange = 5f;
    private bool _isAggro;
    private SphereCollider _detectionCollider;

    private Transform _target;
    public Transform Target => _target;

    public bool IsAggro => _isAggro;

    private void Awake()
    {
        _detectionCollider = gameObject.AddComponent<SphereCollider>();
        _detectionCollider.radius = _aggroRange;
        _detectionCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Hero>() != null)
        {
            _isAggro = true;

            _target = other.transform;

            Debug.Log("Цель обнаружена!, начинаю преследование");            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform == _target)
        {
            _isAggro = false;

            _target = null;

            Debug.Log("Цель потеряна!");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _aggroRange);
    }
}

