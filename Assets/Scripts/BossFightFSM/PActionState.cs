using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PActionState : FightBaseState
{
    public override void EnterState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.playerAction.SetActive(true);

        int blockVal = boss.Blocking();

        if(bfm.playerBlocking)
        {
            bfm.playerTxt.text = "You will block the next incoming attack. \nPress SPACE to continue";
        }

        else
        {
            if(blockVal == 0)
            {
                int dmgDealt = player.attackStat + player.GenerateAttackValue();

                if (boss.defenseStat < dmgDealt)
                {
                    boss.TakeDamage(dmgDealt - boss.defenseStat);
                    bfm.playerTxt.text = "You dealt " + dmgDealt + " damage! \nPress SPACE to continue.";
                }

                else
                {
                    bfm.playerTxt.text = "The boss blocked your attack. \nPress SPACE to continue.";
                }
            }

            else
            {
                int dmgDealt = player.attackStat + player.GenerateAttackValue();
                boss.TakeDamage(dmgDealt);
                bfm.playerTxt.text = "You dealt " + dmgDealt + " damage! \nPress SPACE to continue.";
            }
        }
    }

    public override void UpdateState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(boss.curHealth <= 0)
            {
                bfm.ChangeState(bfm.endState);
            }

            else
            {
                bfm.ChangeState(bfm.bossActionState);
            }
        }
    }

    public override void ExitState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.playerAction.SetActive(false);
    }
}