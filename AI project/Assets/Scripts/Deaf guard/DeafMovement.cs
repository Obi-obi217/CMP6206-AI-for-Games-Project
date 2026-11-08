using UnityEngine;

public class DeafMovement : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public float rotationLimit = 60f;

    private float startRotation;

    void Start()
    {
        startRotation = transform.eulerAngles.y;
    }

    void Update()
    {
        float rotation = Mathf.Sin(Time.time * rotationSpeed * 0.01f) * rotationLimit;

        transform.eulerAngles = new Vector3(
            transform.eulerAngles.x,
            startRotation + rotation,
            transform.eulerAngles.z
        );
    }

    public void StartRotation()
    {
        rotationSpeed = 30f;
    }

    public void StopRotation()
    {
        rotationSpeed = 0f;
    }
}

 