using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionEat : MonoBehaviour
{

    [SerializeField] private Stomach stomach;

    [SerializeField] private AudioSource eatSound;

    public void Eat(GameObject food)
    {
        eatSound.Play();
        stomach.AddFood(food.GetComponent<FoodProperties>());


        Destroy(food);
    }

}
