﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>().DisablePlayer();
            DeathCount.deathCount--;
            Debug.Log("Player");
            //SceneManager.LoadScene(LevelManager.currentLevel);
        }
        else if (col.tag == "Obstacle")
        {
            col.GetComponent<Destroyable>().StartDestroy();
        }
        else if (col.tag == "Enemy")
        {
            col.gameObject.SendMessage("DestroySelf");
        }
    }
}
