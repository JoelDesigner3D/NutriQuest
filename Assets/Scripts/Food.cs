using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private string foodName;
    [SerializeField] private string fr;
    [SerializeField] private float calories;
    [SerializeField] private float lipids;
    [SerializeField] private float proteins;
    [SerializeField] private float carbohydrates;
    [SerializeField] private float weight;
    [SerializeField] private int nutriScore;

    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        go = this.gameObject;
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
    public int NutriScore
    {
        get { return nutriScore; }
        set { nutriScore = value; }
    }

}
