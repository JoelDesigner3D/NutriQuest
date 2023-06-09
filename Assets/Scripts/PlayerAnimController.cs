using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimController : MonoBehaviour
{

    [SerializeField] private Animator playerAnimator;
    [SerializeField] private StarterAssetsInputs starterAssetsInputs;

    private void Update()
    {
        float moveX = Mathf.Abs(starterAssetsInputs.move.x);
        float moveY = Mathf.Abs(starterAssetsInputs.move.y);

        // TODO : Ajouter le moveSpeed pour moduler la vitesse de l'anim

        if (moveX > 0 || moveY > 0)
        {
            Walk(1);
        }
        else
        {
            Walk(0);
        }

        if (starterAssetsInputs.jump == true)
        {
            Jump(true);
        }
        else
        {
            Jump(false);
        }

        if (starterAssetsInputs.sprint == true)
        {
            Run(true);
        }
        else
        {
            Run(false);
        }

    }

    public void OnMove(InputValue value)
    {
        //layerAnimator.SetFloat("Speed", 1);
        Debug.Log("PlayerAnimController > OnMove : "+ value);
    }

    public void Walk(float speed)
    {
        playerAnimator.SetFloat("Speed", speed);
    }

    public void Run(bool value)
    {
        playerAnimator.SetBool("isRunning", value);
    }

    public void Jump(bool value)
    {
        //playerAnimator.SetTrigger("Jump");
        playerAnimator.SetBool("isJumping", value);
    }
}
