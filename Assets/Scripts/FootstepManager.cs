using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepManager : MonoBehaviour
{
    public List<AudioClip> grassSteps = new List<AudioClip>();
    public List<AudioClip> waterSteps = new List<AudioClip>();
    public List<AudioClip> groundSteps = new List<AudioClip>();
    public List<AudioClip> boatSteps = new List<AudioClip>();

    private enum Surface { grass, water, ground, boat };
    private Surface surface;

    private List<AudioClip> currentList;

    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayStep()
    {
        Debug.Log("Steps ok");

        if (currentList == null)
            return;

        AudioClip clip = currentList[Random.Range(0, currentList.Count)];
        source.PlayOneShot(clip);
    }

    private void SelectStepList()
    {
        switch (surface)
        {
            case Surface.grass:
                currentList = grassSteps;
                break;
            case Surface.water:
                currentList = waterSteps;
                break;
            case Surface.boat:
                currentList = boatSteps;
                break;
            case Surface.ground:
                currentList = groundSteps;
                break;
            default:
                currentList = null;
                break;
        }
    }

    public void updateGroundType(string surfaceType)
    {
        if (surfaceType == "Grass")
        {
            surface = Surface.grass;
        }

        if (surfaceType == "Water")
        {
            surface = Surface.water;
        }

        if (surfaceType == "Ground")
        {
            surface = Surface.ground;
        }

        if (surfaceType == "Boat")
        {
            surface = Surface.boat;
        }

        SelectStepList();
    }

}
