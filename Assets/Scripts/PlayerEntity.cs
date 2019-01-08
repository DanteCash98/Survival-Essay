using UnityEngine;
using UnityEngine.UI;

public class PlayerEntity : Entity
{
    public Text healthText;
    public Text goldText;
    [HideInInspector]
    public Entity attacker;
    
    public override void UpdateHealth(int amount)
    {
        health += amount;
        TextUpdater.UpdateText(amount, healthText);
    }

    public override void UpdateGold(int amount)
    {
        gold += amount;
        TextUpdater.UpdateText(amount, goldText);
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
        
    }
}