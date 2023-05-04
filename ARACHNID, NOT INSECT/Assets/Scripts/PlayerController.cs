using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ConfigurableJoint cjLegBack_L, cjLegBack_R, cjLegFront_L, cjLegFront_R,
        cjLegMidBack_L, cjLegMidBack_R, cjLegMidFront_L, cjLegMidFront_R,
        cjLegBackTip_L, cjLegBackTip_R, cjLegFrontTip_L, cjLegFrontTip_R,
        cjLegMidBackTip_L, cjLegMidBackTip_R, cjLegMidFrontTip_L, cjLegMidFrontTip_R;

    private void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            SetJointTargetRotation(cjLegFront_R, 330, 0, 0);
            SetJointTargetRotation(cjLegFrontTip_R, 90, 220, 300);
        }
        else
        {
            SetJointTargetRotation(cjLegFront_R, 40, 0, 0);
            SetJointTargetRotation(cjLegFrontTip_R, 300, 0, 0);
        }

        if (Input.GetKey(KeyCode.J))
        {
            SetJointTargetRotation(cjLegMidFront_R, 330, 0, 0);
            SetJointTargetRotation(cjLegMidFrontTip_R, 90, 220, 300);
        }
        else
        {
            SetJointTargetRotation(cjLegMidFront_R, 40, 0, 0);
            SetJointTargetRotation(cjLegMidFrontTip_R, 300, 0, 0);
        }

        if (Input.GetKey(KeyCode.K))
        {
            SetJointTargetRotation(cjLegMidBack_R, -330, 0, 0);
            SetJointTargetRotation(cjLegMidBackTip_R, -90, -220, -300);
        }
        else
        {
            SetJointTargetRotation(cjLegMidBack_R, -40, 0, 0);
            SetJointTargetRotation(cjLegMidBackTip_R, -300, 0, 0);
        }

        if (Input.GetKey(KeyCode.L))
        {
            SetJointTargetRotation(cjLegBack_R, -330, 0, 0);
            SetJointTargetRotation(cjLegBackTip_R, -90, -220, -300);
        }
        else
        {
            SetJointTargetRotation(cjLegBack_R, -40, 0, 0);
            SetJointTargetRotation(cjLegBackTip_R, -300, 0, 0);
        }

        if (Input.GetKey(KeyCode.F))
        {
            SetJointTargetRotation(cjLegFront_L, 330, 0, 0);
            SetJointTargetRotation(cjLegFrontTip_L, 90, 220, 300);
        }
        else
        {
            SetJointTargetRotation(cjLegFront_L, 40, 0, 0);
            SetJointTargetRotation(cjLegFrontTip_L, 300, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            SetJointTargetRotation(cjLegMidFront_L, 330, 0, 0);
            SetJointTargetRotation(cjLegMidFrontTip_L, 90, 220, 300);
        }
        else
        {
            SetJointTargetRotation(cjLegMidFront_L, 40, 0, 0);
            SetJointTargetRotation(cjLegMidFrontTip_L, 300, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            SetJointTargetRotation(cjLegMidBack_L, 330, 0, 0);
            SetJointTargetRotation(cjLegMidBackTip_L, 90, 220, 300);
        }
        else
        {
            SetJointTargetRotation(cjLegMidBack_L, 40, 0, 0);
            SetJointTargetRotation(cjLegMidBackTip_L, 300, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            SetJointTargetRotation(cjLegBack_L, -330, 0, 0);
            SetJointTargetRotation(cjLegBackTip_L, -90, -220, -300);
        }
        else
        {
            SetJointTargetRotation(cjLegBack_L, -40, 0, 0);
            SetJointTargetRotation(cjLegBackTip_L, -300, 0, 0);
        }
    }

    void SetJointTargetRotation(ConfigurableJoint configurableJoint, float xRotation, float yRotation, float zRotation)
    {
        configurableJoint.targetRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
    }
}
