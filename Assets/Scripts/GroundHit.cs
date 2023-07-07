using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHit : MonoBehaviour
{
    [SerializeField] FootstepManager footstepManager;

    private enum Surface { grass, water, ground, boat };
    private Surface surface;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       // Debug.Log("Hit test");

        footstepManager.updateGroundType(hit.transform.tag);

    }
}
