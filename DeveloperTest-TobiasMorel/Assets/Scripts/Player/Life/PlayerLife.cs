using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int maxHealth = 3; // Salud m�xima del jugador
    public int currentHealth; // Salud actual del jugador

    private void Start()
    {
        // Al iniciar, establecer la salud actual como la salud m�xima
        currentHealth = maxHealth;
    }

    // M�todo para recibir da�o
    public void TakeDamage(int damageAmount)
    {
        // Restar el da�o recibido a la salud actual
        currentHealth -= damageAmount;

        // Verificar si la salud actual es menor o igual a 0
        if (currentHealth <= 0)
        {
            // Si la salud es igual o menor a 0, el jugador ha muerto
            Die();
        }
    }

    // M�todo para manejar la muerte del jugador
    private void Die()
    {
        Debug.Log("�El jugador ha muerto!");
    }
}