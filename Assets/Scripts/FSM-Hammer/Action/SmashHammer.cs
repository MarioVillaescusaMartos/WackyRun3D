using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;


[CreateAssetMenu(menuName = "FSM/Hammer/Actions/Smash")]
public class SmashHammer : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("idle", false);
        controller.SetAnimation("smash", true);
    }
}