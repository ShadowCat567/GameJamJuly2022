using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStartState : CombatBaseState
{
    public override void EnterState(GameObject enemy, Player player, CombatManager cm)
    {
        cm.startingTurn.SetActive(true);
    }

    public override void UpdateState(GameObject enemy, Player player, CombatManager cm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cm.ChangeState(cm.playerAttack);
        }
    }

    public override void ExitState(GameObject enemy, Player player, CombatManager cm)
    {
        cm.startingTurn.SetActive(false);
    }
}
