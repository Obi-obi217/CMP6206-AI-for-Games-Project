using UnityEngine;

public class Sight : MonoBehaviour
{
    public Transform player;
    public float viewDistance = 10f;
    public float viewAngle = 90f;

    public bool CanSeePlayer()
    {
        Vector3 direction = player.position - transform.position;

        if (direction.magnitude > viewDistance)
            return false;

        if (Vector3.Angle(transform.forward, direction) > viewAngle / 2)
            return false;

        if (Physics.Raycast(transform.position, direction, out RaycastHit hit, viewDistance))
        {
            if (hit.transform == player)
                return true;
        }

        return false;
    }
}