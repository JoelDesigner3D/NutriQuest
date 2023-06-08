using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodProperties : MonoBehaviour
{

    [SerializeField] DataManager dataManager;
    //private FoodProperties foodProperties;
    private FoodData foodData;

    [SerializeField] private string foodName;
    [SerializeField] private string fr;
    [SerializeField] private float calories;
    [SerializeField] private float lipids;
    [SerializeField] private float proteins;
    [SerializeField] private float carbohydrates;
    [SerializeField] private float weight;
    [SerializeField] private int nutriscore;


    // Start is called before the first frame update
    void Start()
    {
        fillProperties();
    }

    public void fillProperties()
    {
        string name = this.gameObject.name.ToLower();
        foodData = dataManager.GetFoodDataByName(name);

        //foodProperties = this.gameObject.GetComponent<FoodProperties>();

        this.Name = foodData.name;
        this.Calories = foodData.calories;
        this.Fr = foodData.fr;
        this.Lipids = foodData.lipids;
        this.Proteins = foodData.proteins;
        this.Carbohydrates = foodData.carbohydrates;
        this.Nutriscore = foodData.nutriscore;
        this.Weight = foodData.weight;

    }

    public string Name
    {
        get { return foodName; }
        set { foodName = value; }
    }

    public string Fr
    {
        get { return fr; }
        set { fr = value; }
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

    public float Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    // [A,B,C,D,E] = [2, 1, 0, -1, -2]
    public int Nutriscore
    {
        get { return nutriscore; }
        set { nutriscore = value; }
    }

}
