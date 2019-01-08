using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public int health;
    public int gold;

    public abstract void UpdateHealth(int amount);

    public abstract void UpdateGold(int amount);

    public abstract void ApplyDamage(AttackData ad);

    public abstract void Die();
}
        