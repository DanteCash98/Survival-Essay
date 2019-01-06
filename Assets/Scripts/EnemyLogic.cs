using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public float health = 20f;
    public int goldWorth = 4;
    
    protected void ApplyDamage(float damage)
    {
        health -= damage;

        if (health <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        EntitySpawner.DestroyEntity(gameObject);
        PlayerEconomy.UpdateGold(goldWorth);
    }
}
