using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class IntEvent : UnityEvent<int> { }

public class Stomach : MonoBehaviour
{

    [SerializeField] private float calories;
    [SerializeField] private float lipids;
    [SerializeField] private float proteins;
    [SerializeField] private float carbohydrates;
    [SerializeField] private int qualityIndex;

    public IntEvent OnAbsorbedFood;

    public void AddFood(FoodProperties food)
    {
        float weight = food.Weight / 100;

        this.calories += food.Calories * weight;
        this.lipids += food.Lipids * weight;
        this.proteins += food.Proteins * weight;
        this.carbohydrates += food.Carbohydrates * weight;

        Debug.Log("Stomach : AddFood > calories :" + this.calories + " lipids :" + this.lipids) ;

        digest(food);
    }

    public void digest(FoodProperties food)
    {
        // Super algorythme de calcul de la mort à partir des macro-nutriments et micro-nutriments.
        this.QualityIndex += food.Nutriscore;

        // Digestion is complete
        OnAbsorbedFood.Invoke(food.Nutriscore);
    }


    public float Calories
    {
        get { return calories; }
        set { calories = value; }
    }

    public float Lipids
    {
        get { return lipids; }
        set { lipids = value; }
    }

    public float Proteins
    {
        get { return proteins; }
        set { proteins = value; }
    }

    public float Carbohydrates
    {
        get { return carbohydrates; }
        set { carbohydrates = value; }
    }

    public int QualityIndex
    {
        get { return qualityIndex; }
        set { qualityIndex = value; }
    }


}
