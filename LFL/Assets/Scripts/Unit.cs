using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    //public UnitData unitData;

    public Sprite sprites;
    public string unitName;
    public float health;
    public float attackPoint;
    public float speed;
    public float defencePoint;

    public void Damage(float Damage)
    {
        health -= Damage;
    }

    //public void Init()
    //{
    //    unitName = unitData.name;
    //    health = unitData.Health;
    //    attackPoint = unitData.AttackPoint;
    //    speed = unitData.Speed;
    //    defencePoint = unitData.DefencePoint;
    //}

    //public float GetHealth()
    //{
    //    return health;
    //}

    //public float GetAttackPoint()
    //{
    //    return attackPoint;
    //}

    //public float GetDefencePoint()
    //{
    //    return defencePoint;
    //} 

}
