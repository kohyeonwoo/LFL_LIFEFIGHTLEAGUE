using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType {None, MeatShield, GlassCannon }

public class Unit : MonoBehaviour
{

    public UnitType unitTypes;

    public string unitName;
    public int health;
    public int attackPoint;
    public int speed;
    public int defencePoint;

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

    public void Damage(int Damage)
    {
        health -= Damage;
    }

}
