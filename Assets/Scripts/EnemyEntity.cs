using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class EnemyEntity : Entity
{
    public float health = 20f;
    public int goldWorth = 4;
    
    private Entity attacker;
    
    public override void UpdateHealth(int amount)
    {
        health += amount;
    }

    public override void UpdateGold(int amount)
    {
        gold += amount;
    }
    
    public override void ApplyDamage(AttackData ad)
    {
        health -= ad.attackDamage;
        attacker = ad.attacker;
        
        if (health <= 0f)
        {
            Die();
        }
    }

    public override void Die()
    {
        EntitySpawner.DestroyEntity(gameObject);
        attacker.UpdateGold(goldWorth);
    }
}
