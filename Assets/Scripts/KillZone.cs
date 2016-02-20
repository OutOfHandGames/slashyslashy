﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            SceneManager.LoadScene(LevelManager.currentLevel);
        }
    }
}