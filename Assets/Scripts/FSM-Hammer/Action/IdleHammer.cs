using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;


[CreateAssetMenu(menuName = "FSM/Hammer/Actions/Idle")]
public class IdleHammer : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("idle", true);
        controller.SetAnimation("smash", false);
    }
}
