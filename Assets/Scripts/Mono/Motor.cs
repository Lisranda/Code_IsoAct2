using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Motor : MonoBehaviour
{
    NavMeshAgent agent;

    void Awake () {
        agent = GetComponent<NavMeshAgent> ();
    }

    void Update () {
        
    }

    public void MoveToTarget (Vector3 target) {
        agent.SetDestination (target);
    }
}
