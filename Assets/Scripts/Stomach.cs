using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomach : MonoBehaviour
{
    [SerializeField] private Health health;

    [SerializeField] private float calories;
    [SerializeField] private float lipids;
    [SerializeField] private float proteins;
    [SerializeField] private float carbohydrates;
    [SerializeField] private float weight;
    [SerializeField] private float quality;


    // créer event sur ajout de nourriture

    public void AddFood(FoodProperties food)
    {
        this.calories += food.Calories;  // multiplier par weight
        this.lipids += food.Lipids;
        this.proteins += food.Proteins;
        this.carbohydrates += food.Carbohydrates;

        digest(food.Nutriscore);
    }

    public void digest(int newScore)
    {
        quality =  quality + newScore;
    }


}
