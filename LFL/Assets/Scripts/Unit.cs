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

        Debug.Log(" unitName = " + unitName);
        Debug.Log(" health = " + health);
        Debug.Log(" attackPoint = " + attackPoint);
        Debug.Log(" speed = " + speed);
        Debug.Log(" defencePoint = " + defencePoint);
    }
}
