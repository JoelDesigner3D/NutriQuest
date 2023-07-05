using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerClick : MonoBehaviour
{
    public void OnLeftClick(InputValue value)
    {
        RaycastHit hit;
        IClickable clickable;

        Vector2 mousePosition = Mouse.current.position.value;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(mousePosition), out hit)
            && hit.collider.TryGetComponent<IClickable>(out clickable))
        {
            clickable.OnClick();
        }
    }
}
