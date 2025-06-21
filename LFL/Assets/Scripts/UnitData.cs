
using UnityEngine;

[CreateAssetMenu(fileName = "Unit Data", menuName = "Scriptable Object/Unit Data", order = int.MaxValue)]
public class UnitData : ScriptableObject
{

    [SerializeField]
    private string unitName;
    
    public string UnitName { get { return unitName; } }

    [SerializeField]
    private float health;

    public float Health { get { return health; } }

    [SerializeField]
    private float attackPoint;

    public float AttackPoint { get { return attackPoint; } }

    [SerializeField]
    private float speed;

    public float Speed { get { return speed; } }

    [SerializeField]
    private float defencePoint;

    public float DefencePoint { get { return defencePoint; } }
}
