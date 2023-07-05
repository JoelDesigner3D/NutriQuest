using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FoodPanel : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _calories;
    [SerializeField] private TextMeshProUGUI _proteins;
    [SerializeField] private TextMeshProUGUI _carbohidrates;
    [SerializeField] private TextMeshProUGUI _lipids;
    [SerializeField] private TextMeshProUGUI _nutriscore;

    private void Update()
    {

        Quaternion lookRotation = Camera.main.transform.rotation;
        transform.rotation = lookRotation;

    }

    public void SetName(string text)
    {
        _name.text = text;
    }
    public void SetCalories(string text)
    {
        _calories.text = text;
    }
    public void SetProteins(string text)
    {
        _proteins.text = text;
    }
    public void SetLipids(string text)
    {
        _lipids.text = text;
    }
    public void SetCarbohidrates(string text)
    {
        _carbohidrates.text = text;
    }
    public void SetNutriScore(string text)
    {
        _nutriscore.text = text;
    }
    public void SetProperties(FoodProperties _foodProperties)
    {
        this.SetName(_foodProperties.Fr);
        this.SetCalories("Calories : "+_foodProperties.Calories);
        this.SetProteins("Protéines : " + _foodProperties.Proteins);
        this.SetCarbohidrates ("Protides : " + _foodProperties.Carbohydrates);
        this.SetLipids("Lipides : " + _foodProperties.Lipids);
        this.SetNutriScore("NutriScore : " + (_foodProperties.Nutriscore + 2));
    }
}
