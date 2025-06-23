using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public UnitData unitData;

    private string unitName;
    private float health;
    private float attackPoint;
    private float speed;
    private float defencePoint;

    public void Init()
    {
        unitName = unitData.name;
        health = unitData.Health;
        attackPoint = unitData.AttackPoint;
        speed = unitData.Speed;
        defencePoint = unitData.DefencePoint;
    }

    public float GetHealth()
    {
        return health;
    }

    public float GetAttackPoint()
    {
        return attackPoint;
    }

    public float GetDefencePoint()
    {
        return defencePoint;
    } 

    public void SetHealth(float Health)
    {
        health = Health;
    }

}
