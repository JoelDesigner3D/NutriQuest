using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using System;

[Serializable]
public struct FoodsData
{
    public List<FoodData> foods;
}

[Serializable]
public struct FoodData
{
    public string name;
    public string fr;
    public float calories;
    public float lipids;
    public float proteins;
    public float carbohydrates;
    public float weight;
    public int nutriscore;
}



public class DataManager : MonoBehaviour
{

    private List<FoodData> foodList;
    private FoodsData foodsData;

    private void Awake()
    {
        Debug.Log("DataManager : Awake");
        loadFoods();
    }

    public void loadFoods()
    {
        Debug.Log("DataManager : loadFoods");
        
        TextAsset jsonFile = Resources.Load<TextAsset>("foods");

        foodsData = JsonUtility.FromJson<FoodsData>(jsonFile.text);
        foodList = foodsData.foods;

        foreach (FoodData food in foodList)
        {
            Debug.Log("Name: " + food.name + ", Calories: " + food.calories);
        }

    }

    public FoodData GetFoodDataByName(string name)
    {
        FoodData foundFood = foodList.Find(food => food.name == name);
        return foundFood;
    }

}
