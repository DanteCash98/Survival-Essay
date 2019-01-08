using UnityEngine;

public class AttackData
{
    public int attackDamage;
    public Entity attacker;

    public AttackData(Entity attacker, int damage)
    {
        this.attacker = attacker;
        attackDamage = damage;
    }
}