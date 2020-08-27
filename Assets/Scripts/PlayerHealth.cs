using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    public int startingHealth = 100;
    public int currentHealth = 100;
    public HealthBar healthBar;
    public GameOverMenu gameOverMenu;


    void Start()
    {
        currentHealth = startingHealth;
       healthBar.SetMaxHealth(startingHealth);
        healthBar.SetHealth(currentHealth);

    }

    public void TakeDamage(int damaged)
    {
        currentHealth = currentHealth - damaged;
        healthBar.SetHealth(currentHealth);


    }

    public void Dead()
    {
        gameOverMenu.GameOver();
    }


}