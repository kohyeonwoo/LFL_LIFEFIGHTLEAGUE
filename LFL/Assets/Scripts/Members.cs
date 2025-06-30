using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Members : Unit
{
    private void Awake()
    {

        Init();
        
        GameMananger.Instance.playerUnit.Add(this);

        GameMananger.Instance.totalPlayerUnitsHealth += this.health;
        GameMananger.Instance.totalPlayerUnitsAttackPoint += this.attackPoint;
        GameMananger.Instance.totalPlayerUnitDefencePoint += this.defencePoint;

        GameMananger.Instance.CurrentPlayerUnitStats();

    }
}
