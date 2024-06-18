using UnityEngine;
using UnityEngine.AI;

public class BotController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private WaypointGraph waypointGraph;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        waypointGraph = FindObjectOfType<WaypointGraph>();
    }

    void Update()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);
        }
    }

    public void MoveToNextWaypoint()
    {
        Transform nextWaypoint = waypointGraph.GetNearestWaypoint(transform.position);
        if (nextWaypoint != null)
        {
            agent.SetDestination(nextWaypoint.position);
        }
    }
}
