using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvoState3 : StartConvoBaseState
{
    public override void EnterState(StartConvoManager scm)
    {
        scm.startConvo3.SetActive(true);
        scm.startCTxt3.text = "[the Weevil disappears into the grass] \nPress SPACE to continue";
    }

    public override void UpdateState(StartConvoManager scm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scm.ChangeState(scm.startC4);
        }
    }

    public override void ExitState(StartConvoManager scm)
    {
        scm.startConvo3.SetActive(false);
    }
}
