using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour {
    public float maxEnergy = 100;
    public float energyGrowthRate = 2;

    float currentEnergy;

    void Start()
    {
        currentEnergy = maxEnergy;
    }

    public float getCurrentEnergy()
    {
        return currentEnergy;
    }

}
