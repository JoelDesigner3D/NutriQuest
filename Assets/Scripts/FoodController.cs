using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class FoodController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private int speed;


    // Update is called once per frame
    void Update()
    {
        // Food rotation
        transform.Rotate(direction * speed * Time.deltaTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked : " + gameObject.name);

    }

    private void DisplayCartouche()
    {

    }


}
