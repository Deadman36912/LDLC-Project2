using ECM.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDLCCharacterController : BaseCharacterController
{


    protected override void Animate()
    {
        // If there is no animator, return

        if (animator == null)
            return;

        // Compute move vector in local space

        var move = transform.InverseTransformDirection(moveDirection);

        // Update the animator parameters

        var forwardAmount = move.z;

        animator.SetFloat("Forward", forwardAmount);

        if (!movement.isGrounded)
            animator.SetFloat("Jump", 3f);
        else
            animator.SetFloat("Jump", 0f);
    }

}
