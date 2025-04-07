using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;

    private float attackTimer;

    protected Player player;
    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
    }
    protected virtual void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
        {
            attackTimer += Time.deltaTime;
            if (attackTimer > attackSpeed)
            {
                Attack();
                attackTimer = 0;
            }
        }
    }
    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);
        //call animation to attack
        //deal damage
    }
    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }
    public void Die()
    {
        //call death animation
        //destroy the object
    }
}
