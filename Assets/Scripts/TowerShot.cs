using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShot : MonoBehaviour {
    [Tooltip("Referencia al prefab de la bala")]
    public GameObject bulletPrefab;

    [Tooltip("Referencia al enemigo que voy a disparar")]
    public GameObject enemy;

    [Tooltip("Altura a la que se debe instanciar la bala")]
    public float height;

    [Tooltip("Frecuencia de disparo deseada (cada cuántos segundos se realiza un disparo)")]
    public float shootFrequency;

    // Último momento en que se realizó un disparo
    private float lastShotTime;

    private void Update() {
        // Intento de disparo
        Shoot();
    }

    private void Shoot() {
        // Comprueba si existe un enemigo en el rango de ataque de la torre
        if (enemy != null) {
            // Comprueba si ha pasado el tiempo correspondiente desde el último disparo
            if (Time.time - lastShotTime >= shootFrequency) {
                // Realiza el disparo instanciando la bala
                // (La variable bala es de tipo GameObject y privada = private GameObject bala)
                GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, height, 0), Quaternion.identity);
                // Asigna a la bala instanciada el enemigo al que tiene que dirigirse
                bala.GetComponent<BulletMovement>().enemy = enemy;
                // Registra el momento en que se ha disparado
                lastShotTime = Time.time;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        // Comprueba si es un enemigo el que ha entrado en el trigger
        if (other.CompareTag("Enemy")) {
            // Asigna como objetivo el enemigo que acaba de entrar en el trigger
            enemy = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other) {
        // El enemigo deja de ser el objetivo de la torre
        enemy = null;
    }
}