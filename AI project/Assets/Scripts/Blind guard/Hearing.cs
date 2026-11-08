using UnityEngine;

public class Hearing : MonoBehaviour
{
    public float hearingRange = 10f;

    public Vector3 lastHeardPosition;
    public bool heardSound = false;

    public void HearSound(Vector3 soundPosition)
    {
        float distance = Vector3.Distance(transform.position, soundPosition);

        if (distance <= hearingRange)
        {
            lastHeardPosition = soundPosition;
            heardSound = true;
        }
    }
}