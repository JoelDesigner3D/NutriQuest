using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using ColorUtility = UnityEngine.ColorUtility;

public class FoodPanel : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _calories;
    [SerializeField] private TextMeshProUGUI _proteins;
    [SerializeField] private TextMeshProUGUI _carbohidrates;
    [SerializeField] private TextMeshProUGUI _lipids;
    [SerializeField] private TextMeshProUGUI _nutriscore;

    private string[] nutriScoreColors = new string[]{ "#038141", "#85bb2f", "#fecb02", "#ee8100", "#e63e11" };
    private string[] nutriScoreIndices = new string[]{"A", "B", "C", "D", "E"};

    private void Update()
    {

        Quaternion lookRotation = Camera.main.transform.rotation;
        transform.rotation = lookRotation;

    }

    public void SetName(string text)
    {
        _name.text = text;
    }
    public void SetCalories(float value)
    {
        _calories.text = "Calories : " + value;
    }
    public void SetProteins(float value)
    {
        _proteins.text = "Protéines : " + value;
    }
    public void SetLipids(float value)
    {
        _lipids.text = "Lipides : " + value;
    }
    public void SetCarbohidrates(float value)
    {
        _carbohidrates.text = "Protides : " + value;
    }

    // Values [A,B,C,D,E] = [2, 1, 0, -1, -2]
    public void SetNutriScore(int score)
    {
        if (score <-2 || score > 2)
        {
            _nutriscore.text = "NutriScore : ";
            return;
        }

        score += 2;

        Debug.Log(score);

        string htmlColor = nutriScoreColors[4 - score];

        Color rgbColor;
        if (ColorUtility.TryParseHtmlString(htmlColor, out rgbColor))
        {
            Debug.Log("Couleur RVB : " + rgbColor);
            _nutriscore.color = rgbColor;
        }
        else
        {
            Debug.LogError("Erreur de conversion de couleur HTML en RVB");
        }
        
        _nutriscore.text = "NutriScore : " + nutriScoreIndices[4-score];
    }

    public void SetProperties(FoodProperties _foodProperties)
    {
        this.SetName(_foodProperties.Fr);
        this.SetCalories(_foodProperties.Calories);
        this.SetProteins(_foodProperties.Proteins);
        this.SetCarbohidrates (_foodProperties.Carbohydrates);
        this.SetLipids(_foodProperties.Lipids);
        this.SetNutriScore(_foodProperties.Nutriscore);
    }
}
