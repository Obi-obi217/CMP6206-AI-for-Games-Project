using System.Runtime.CompilerServices;
using UnityEngine;

public class Sight : MonoBehaviour
{
    public Transform player;
    public float viewDistance = 10f;
    public float viewAngle = 90f;

    Vector3 eyes;

    void Start()
    {
        eyes = transform.position + Vector3.up * 1.5f;
    }

    public bool CanSeePlayer()
    {
        Vector3 direction = player.position - eyes;

        if (direction.magnitude > viewDistance)
            return false;

        if (Vector3.Angle(transform.forward, direction) > viewAngle / 2)
            return false;

        if (Physics.Raycast(eyes, direction.normalized, out RaycastHit hit, direction.magnitude))
        {
            if (hit.transform == player)
                return true;
        }

        return false;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        Vector3 left = Quaternion.Euler(0, -viewAngle / 2, 0)
                       * transform.forward;

        Vector3 right = Quaternion.Euler(0, viewAngle / 2, 0)
                        * transform.forward;

        Gizmos.DrawRay(transform.position, left * viewDistance);
        Gizmos.DrawRay(transform.position, right * viewDistance);
    }
}