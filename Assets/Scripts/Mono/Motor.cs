using UnityEngine;
using UnityEngine.AI;

public class Motor : MonoBehaviour
{
    NavMeshAgent agent;
    NavMeshObstacle obs;

    void Awake () {
        agent = GetComponent<NavMeshAgent> ();
        obs = GetComponent<NavMeshObstacle> ();
        //agent.updateRotation = false;
    }

    void Update () {
        //Rotate ();
    }

    void LateUpdate () {
        ResetAgentListener ();
    }

    public void MoveToTarget (Vector3 target) {
        obs.enabled = false;
        agent.enabled = true;        
        agent.SetDestination (target);
    }

    void Rotate () {
        if (!agent.enabled)
            return;
        Vector3 direction = (agent.destination - transform.position).normalized;
        Quaternion rotation = Quaternion.LookRotation (direction);
        transform.rotation = Quaternion.Slerp (transform.rotation , rotation , Time.deltaTime * 10f);
    }

    void ResetAgentListener () {
        if (HasDestination ())
            return;
        agent.enabled = false;
        obs.enabled = true;
    }

    public bool HasDestination () {
        if (!agent.enabled)
            return false;
        if (agent.destination != null && agent.destination != transform.position)
            return true;
        return false;
    }

    public Vector3 EchoDestination () {
        return agent.destination;
    }
}
