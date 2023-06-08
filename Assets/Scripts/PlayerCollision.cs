using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    [SerializeField] ActionEat actionEat;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected : " + other);
        if (other.gameObject.tag == "Food")
        {
            actionEat.Eat(other.gameObject);
        }
    }

}
