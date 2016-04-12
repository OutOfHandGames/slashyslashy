using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    public float cameraAcceleration;
    public float xOffset;
    public float yOffset;

    public float minX = -Mathf.Infinity;
    public float maxX = Mathf.Infinity;
    public float minY = -Mathf.Infinity;
    public float maxY = Mathf.Infinity;

    float zPosition;
    Vector3 currentVel;

    void Start()
    {
        if (target == null)
        {
            target = GameObject.FindObjectOfType<PlayerWalkMechanics>().transform;
        }
        //GetComponent<Camera>().transparencySortMode = TransparencySortMode.Orthographic;
        zPosition = transform.position.z;
    }

    void Update()
    {
        updateCameraPosition();
    }

    void updateCameraPosition()
    {
        Vector3 goalPosition = Vector3.forward * zPosition;
        goalPosition += Vector3.up * (target.position.y + yOffset);
        goalPosition += Vector3.right * (target.position.x + xOffset);

        transform.position = Vector3.SmoothDamp(transform.position, goalPosition, ref currentVel, cameraAcceleration * Time.deltaTime);
    }

    public void setTarget(Transform target)
    {
        this.target = target;
    }
}
