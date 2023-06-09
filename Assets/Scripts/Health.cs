using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Health : MonoBehaviour
{
    [SerializeField] private int healthLevel = 0;
    [SerializeField] private float energyLevel = 0;
    [SerializeField] private int lifes = 3;
    [SerializeField] UIManager uiManager;
    [SerializeField] GameObject player;
    [SerializeField] private float moveSpeed = 4;

    public UnityEvent OnChangeHealth;

    public void OnAbsorbedFood(int nutriscore)
    {
        Debug.Log("Health : OnAbsorbedFood > nutriscore :"+ nutriscore + " !");
        ChangePlayerSpeed(nutriscore);
    }

    private void ChangePlayerSpeed(int nutriscore)
    {

        // nutriscore [-2, -1, 0, 1, 2]

        if (nutriscore > 0)
        {
            nutriscore *= 2;
        }

        float speed = moveSpeed + nutriscore;

        OnChangeHealth.Invoke();


        player.GetComponent<ThirdPersonController>().MoveSpeed = speed;

    }

    public int HealthLevel
    {
        get { return healthLevel; }
        set { 
            healthLevel = value;
        }
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
