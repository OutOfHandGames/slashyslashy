using UnityEngine;
using System.Collections;

public class TextSpeech : MonoBehaviour {
    public string text = "Hello";
    public float timeToDisplay = 3;

    float timeRemaining;
    bool isActive;

    void Start()
    {
        timeRemaining = timeToDisplay;
    }

    void Update()
    {
        if (isActive)
        {
            timeRemaining = Mathf.MoveTowards(timeRemaining, 0, Time.deltaTime);
        }

        if (timeRemaining > 0)
        {

        }
    }
}
