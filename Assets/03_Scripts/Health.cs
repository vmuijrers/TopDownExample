using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0) { return; }
        health -= damage;
        if(health <= 0)
        {
            Death();
        }
    }

    public void GainHealth(int amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, maxHealth);
    }

    private void Death()
    {
        Debug.Log("Death");
        Destroy(gameObject);
    }

}
