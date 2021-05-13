using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    [Tooltip("Puntos de vida del enemigo")]
    public int health;

    void Update() {
        // Controla que al quedarse sin vidas se destruya el enemigo
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
