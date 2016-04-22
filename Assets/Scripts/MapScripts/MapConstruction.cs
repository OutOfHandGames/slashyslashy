using UnityEngine;
using System.Collections;

public class MapConstruction : MonoBehaviour {
    public MapTile[] tiles = new MapTile[10];


    void Start()
    {
        createMap(GameObject.FindGameObjectWithTag("Player").transform);
    }

    void createMap(Transform player)
    {
        Vector3 previousPosition = player.transform.position + new Vector3(-5, -.5f, 0);
        foreach (MapTile t in tiles)
        {
            GameObject obj = (GameObject)Instantiate(t.gameObject, previousPosition - t.startPoint.transform.localPosition, new Quaternion());
            
            previousPosition = obj.GetComponent<MapTile>().endPoint.position;
        }
    }

}
