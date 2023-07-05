using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class FoodController : MonoBehaviour, IClickable
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private int speed;
    [SerializeField] private GameObject foodInfo;
    [SerializeField] private AudioSource clickSound;
    [SerializeField] private float foodInfoHight = 1f;
    [SerializeField] private ParticleSystem eatParticle;

    private Boolean foodInfoIsVisible = false;
    private FoodProperties foodProperties;


    // Update is called once per frame
    void Update()
    {
        // Food rotation
        transform.Rotate(direction * speed * Time.deltaTime);
    }

    public void OnClick()
    {
        Debug.Log("clicked : " + gameObject.name);
        foodProperties = gameObject.GetComponent<FoodProperties>();
        UpdateInfoPosition();
        DisplayInfo(foodProperties);
    }

    /*
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked : " + gameObject.name);

        UpdateInfoPosition();
        DisplayInfo();
    }
    */

    private void UpdateInfoPosition()
    {
        float posX = gameObject.transform.position.x;
        float posY = gameObject.transform.position.y + foodInfoHight;
        float posZ = gameObject.transform.position.z;

        foodInfo.transform.position = new Vector3(posX, posY, posZ);
    }

    private void DisplayInfo(FoodProperties _foodProperties)
    {
        clickSound.Play();

        //foodInfo.GetComponentInChildren<FoodPanel>().SetName("gloubi");
        foodInfo.GetComponentInChildren<FoodPanel>().SetProperties(_foodProperties);

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

    public void ExplodeFood()
    {
        Vector3 positionParticles = gameObject.transform.position;
        eatParticle.transform.position = positionParticles;
        eatParticle.Play();
    }
}
