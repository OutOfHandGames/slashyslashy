using UnityEngine;
using System.Collections;

public class BasicCheckPoint : MonoBehaviour {
    public BasicCheckPoint nextCheckPoint;
    Transform player;
    CheckPointManager checkPointManager;
    Vector3 resetPosition;
    
    void Start()
    {
        checkPointManager = transform.parent.GetComponent<CheckPointManager>();
        player = checkPointManager.playerTransform;
        resetPosition = transform.position;
    }

    public void completeCheckPoint()
    {
        checkPointManager.setCurrentCheckPoint(nextCheckPoint);
    } 

    public void resetPlayerPosition()
    {
        player.position = resetPosition;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Player")
        {
            //print(collider.name);
            resetPlayerPosition();
        }
    }
}
