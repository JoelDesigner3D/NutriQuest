using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] Health health;
    [SerializeField] Stomach stomach;
    [SerializeField] GameManager gameManager;
    [SerializeField] TextMeshProUGUI calories;
    [SerializeField] TextMeshProUGUI proteins;
    [SerializeField] TextMeshProUGUI carbohydrates;
    [SerializeField] TextMeshProUGUI lipids;


    public void OnChangeHealth()
    {
        DisplayInfos();
    }

    private void DisplayInfos() 
    {
        Debug.Log("UIManager > DisplayInfos : OK");

        calories.text = "Calories : " + stomach.Calories;
        proteins.text = "Protéines : " + stomach.Proteins;
        carbohydrates.text = "Glucides : " + stomach.Carbohydrates;
        lipids.text = "Lipides : " + stomach.Lipids;
    }


    public void QuitGame()
    {
        gameManager.Quit();
    }

    
}
