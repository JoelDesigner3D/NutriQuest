using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void OnApplicationQuit()
    {
        Debug.Log("Quit application... Good By!");
    }
}
