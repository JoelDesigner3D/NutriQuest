using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class FoodController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private int speed;
    [SerializeField] private GameObject foodInfo;
    [SerializeField] private AudioSource clickSound;
    [SerializeField] private float foodInfoHight = 1f;

    private Boolean foodInfoIsVisible = false;


    // Update is called once per frame
    void Update()
    {
        // Food rotation
        transform.Rotate(direction * speed * Time.deltaTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked : " + gameObject.name);

        UpdateInfoPosition();
        DisplayInfo();
    }

    private void UpdateInfoPosition()
    {
        float posX = gameObject.transform.position.x;
        float posY = gameObject.transform.position.y + foodInfoHight;
        float posZ = gameObject.transform.position.z;

        foodInfo.transform.position = new Vector3(posX, posY, posZ);
    }

    private void DisplayInfo()
    {
        clickSound.Play();

        foodInfo.GetComponentInChildren<FoodPanel>().SetName("gloubi");

        if (!foodInfoIsVisible)
        {
            foodInfoIsVisible = true;
        }
        else
        {
            foodInfoIsVisible = false;
        }

        foodInfo.SetActive(foodInfoIsVisible);

    }

    public void HideInfos()
    {
        if (foodInfoIsVisible)
        {
            foodInfoIsVisible = false;
            foodInfo.SetActive(foodInfoIsVisible);
        }
    }
}
