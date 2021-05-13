using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {

    private void OnCollisionEnter(Collision collision) {
        // Comprueba si es un enemigo con el que choca
        if (collision.gameObject.CompareTag("Enemy")) {
            // Quita un punto de vida al enemigo
            --collision.gameObject.GetComponent<EnemyHealth>().health;
        }
        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }
}