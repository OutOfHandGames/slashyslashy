using UnityEngine;
using System.Collections;

public class CheckPointManager : MonoBehaviour {
    public BasicCheckPoint currentCheckPoint;
    public Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        while (playerTransform.parent != null)
        {
            playerTransform = playerTransform.parent;
        }
        currentCheckPoint.gameObject.SetActive(true);
    }

    public void setCurrentCheckPoint(BasicCheckPoint checkPoint)
    {
        this.currentCheckPoint.gameObject.SetActive(false);
        checkPoint.gameObject.SetActive(false);
        this.currentCheckPoint = checkPoint;
    }

    public void resetCheckPoint()
    {
        this.currentCheckPoint.resetPlayerPosition();
    }
}
