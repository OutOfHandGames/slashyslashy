using UnityEngine;
using System.Collections;

public class AIStateMachine : MonoBehaviour {
    enum States { Idle, Charge };
    public string[] validStates;
    public bool isActive;


    void createValidStates()
    {

    }

    void Update()
    {
        if (!isActive)
        {
            return;
        }
    }

}
