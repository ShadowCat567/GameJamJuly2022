using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndConState3 : EndConvoBaseState
{
    public override void EnterState(EndConvoManager ecm)
    {
        ecm.endConvo3.SetActive(true);
        ecm.endTxt3.text = "Are you ok? Did the Weevils hurt you? \n   [SPACE]";
    }

    public override void UpdateState(EndConvoManager ecm)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ecm.soundSource.Play();
            ecm.ChangeState(ecm.endState4);
        }
    }

    public override void ExitState(EndConvoManager ecm)
    {
        ecm.endConvo3.SetActive(false);
    }
}
