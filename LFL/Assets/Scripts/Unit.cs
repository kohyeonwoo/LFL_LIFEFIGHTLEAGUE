using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType {None, MeatShield, GlassCannon }

public class Unit : MonoBehaviour
{
    //public UnitData unitData;

    public UnitType unitTypes;

    public string unitName;
    public float health;
    public float attackPoint;
    public float speed;
    public float defencePoint;

    public void Init()
    {

        int typeRand = Random.Range(0, 2);

        if(typeRand == 0)
        {
            unitTypes = UnitType.MeatShield;
        }

        if(typeRand == 1)
        {
            unitTypes = UnitType.GlassCannon;
        }

        if(unitTypes == UnitType.MeatShield)
        {
            health = Random.Range(1, 6);
            attackPoint = Random.Range(1, 4);
            speed = Random.Range(1, 3);
            defencePoint = Random.Range(1, 9);
        }

        if(unitTypes == UnitType.GlassCannon)
        {
            health = Random.Range(1, 5);
            attackPoint = Random.Range(1, 9);
            speed = Random.Range(1, 5);
            defencePoint = Random.Range(1, 3);
        }

    }

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
