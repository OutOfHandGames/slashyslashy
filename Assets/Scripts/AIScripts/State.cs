using UnityEngine;
using System.Collections;

public abstract class State {
    public string stateName;
    Transform rootTransform;
    

    public abstract void enterState(Transform rootTransform);

    public abstract void updateState(float deltaTime);

    public abstract void exitState();

}
