using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    [Tooltip("Velocidad de la bala")]
    public float bulletSpeed;

    [Tooltip("Referencia al enemigo que voy a matar")]
    public GameObject enemy;

    void Update() {
        // Comprueba si el enemigo existe o ya ha sido destruido
        if (enemy != null) {
            // Movimiento de la bala en el eje Y según la velocidad especificada
            transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, bulletSpeed);
        } else {
            // Enemigo destruido, por tanto se destruye la bala también
            Destroy(gameObject);
        }
    }
}
