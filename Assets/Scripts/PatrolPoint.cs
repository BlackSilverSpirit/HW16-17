using UnityEngine;

public class PatrolPoint : MonoBehaviour
{
    private Color _gizmoColor = Color.blue;

    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmoColor;
        Gizmos.DrawSphere(transform.position, 0.3f);
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}