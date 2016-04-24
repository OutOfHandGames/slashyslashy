using UnityEngine;
using System.Collections;

public class BasicCheckPoint : MonoBehaviour {
    public BasicCheckPoint nextCheckPoint;
    Transform player;
    CheckPointManager checkPointManager;
    Vector3 resetPosition;
    
    void Awake()
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
}
