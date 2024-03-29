using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public AudioClip PlayOnDeath;

    void Start()
    {
        currentHealth = maxHealth;
        
    }
    public void Update()
    {
        if (currentHealth <= 0)
        {
            if (PlayOnDeath != null)
                AudioManager.PlaySound(PlayOnDeath, transform.position);
            Destroy(gameObject);
        }        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
