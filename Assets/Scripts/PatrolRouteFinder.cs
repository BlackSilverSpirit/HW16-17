using System.Linq;
using UnityEngine;

public class PatrolRouteFinder : MonoBehaviour
{
    [SerializeField] private PatrolPoint[] _patrolPoints;

    public Transform[] PatrolTransforms { get; private set; }

    private void Awake()
    {
        _patrolPoints = FindObjectsOfType<PatrolPoint>();

        _patrolPoints = _patrolPoints.OrderBy(point => point.gameObject.name).ToArray();

        PatrolTransforms = new Transform[_patrolPoints.Length];
        for (int i = 0; i < _patrolPoints.Length; i++)
        {
            PatrolTransforms[i] = _patrolPoints[i].transform;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (_patrolPoints == null || _patrolPoints.Length < 2) return;

        Gizmos.color = Color.green;
        for (int i = 0; i < _patrolPoints.Length - 1; i++)
        {
            Gizmos.DrawLine(_patrolPoints[i].transform.position,
                          _patrolPoints[i + 1].transform.position);
        }
    }
}
