﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {

    public GameManager gm;
    public Text timerText;
    public PlayerController player;

    public Slider slider;
    public Image sliderFill;
    void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

	// Update is called once per frame
	void Update () {
        timerText.text = gm.timeLeft.ToString();
        slider.value = (float)gm.timeLeft / gm.timeLimit * 100f;
        if (gm.timeLeft / gm.timeLimit > 0.7f)
        {
            sliderFill.color = Color.green;
        }
        else if (gm.timeLeft / gm.timeLimit <= 0.7f && gm.timeLeft / gm.timeLimit >0.3f)
        {
            sliderFill.color = Color.yellow;
        }
        else
        {
            sliderFill.color = Color.red;
        }
	}



    void CheckPlayer()
    {
        if (!player)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
