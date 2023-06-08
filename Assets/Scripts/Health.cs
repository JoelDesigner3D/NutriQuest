using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int healthLevel = 0;
    [SerializeField] private float energyLevel = 1;
    [SerializeField] private int lifes = 3;

    public int HealthLevel
    {
        get { return healthLevel; }
        set { healthLevel = value; }
    }

    public float EnergyLevel
    {
        get { return energyLevel; }
        set { energyLevel = value; }
    }

    public int Lifes
    {
        get { return lifes; }
        set { lifes = value; }
    }

}
