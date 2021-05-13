using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
    [Tooltip("Referencia al NavMeshAgent del enemigo, usado para la navegación por el mapa")]
    public NavMeshAgent agent;

    [Tooltip("Posición a la que el enemigo debe dirigirse")]
    public Vector3 position;

    void Start() {
        // Establece la posición a la que se debe dirigir el enemigo
        agent.SetDestination(position);
    }
}
