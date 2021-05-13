using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    [Tooltip("Referencia al prefab del enemigo")]
    public GameObject enemyPrefab;

    [Tooltip("Frecuencia de generación de enemigos deseada (cada cuántos segundos se genera un enemigo)")]
    public float enemyFrequency;

    // Último momento en que se generó un enemigo
    private float lastEnemyTime;

    private void Start() {
        // Generación de enemigos siguiendo la frecuencia deseada
        //InvokeRepeating("GenerateEnemyWithInvoke", enemyFrequency, enemyFrequency);
    }

    void Update() {
        // Generación de enemigo
        GenerateEnemy();
    }

    private void GenerateEnemy() {
        // Comprueba si ha pasado el tiempo correspondiente desde el último enemigo generado
        if (Time.time - lastEnemyTime >= enemyFrequency) {
            // Se genera un nuevo enemigo en la posición del generador
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            // Registra el momento en que se ha generado
            lastEnemyTime = Time.time;
        }
    }

    private void GenerateEnemyWithInvoke() {
        // Se genera un nuevo enemigo en la posición del generador
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}