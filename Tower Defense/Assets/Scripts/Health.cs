using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth = 0; 
    private int currentHealth;
    private bool isZombieTouching;
    private float touchDuration = 0;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (isZombieTouching)
        {
            touchDuration += Time.deltaTime;

            if (touchDuration >= 3f)
            {
                Die();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            isZombieTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            isZombieTouching = false;
            touchDuration = 0;
        }
    }

    private void Die()
    {
        // Implement tower destruction behavior here, e.g., play a destruction animation, remove tower from the scene, etc.
        Destroy(gameObject);
    }
    
}
