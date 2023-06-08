using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionEat : MonoBehaviour
{

    [SerializeField] private Stomach stomach;

    public void Eat(GameObject food)
    {
        stomach.AddFood(food.GetComponent<FoodProperties>());

        //Delete food
        Destroy(food);
    }

}
