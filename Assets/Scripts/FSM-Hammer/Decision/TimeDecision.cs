using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Hammer/Decison/Time")]
public class TimeDecision : FSM.Decision
{
    public override bool Decide(Controller controller)
    {
        bool h = controller.GetCurrentTime();

        return h;
    }
}
