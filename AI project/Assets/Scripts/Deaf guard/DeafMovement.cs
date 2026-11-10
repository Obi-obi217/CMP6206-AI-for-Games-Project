using UnityEngine;

public class DeafMovement : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public float rotationLimit = 60f;

    private float startRotation;
    private float scanTime;
    private bool isRotating = true;

    void Start()
    {
        startRotation = transform.eulerAngles.y;
        scanTime = rotationLimit;
    }

    void Update()
    {
        if (isRotating)
        {
            scanTime += Time.deltaTime * rotationSpeed;

            float rotation = Mathf.PingPong(scanTime, rotationLimit * 2)
                             - rotationLimit;

            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                startRotation + rotation,
                transform.eulerAngles.z
            );
        }
        //Debug.Log(isRotating);
    }

    public void StartRotation()
    {
        isRotating = true;
    }

    public void StopRotation()
    {
        isRotating = false;
    }
}

 