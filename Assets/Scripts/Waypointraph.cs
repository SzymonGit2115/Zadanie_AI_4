using System.Collections.Generic;
using UnityEngine;

public class WaypointGraph : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();

    void Awake()
    {
        foreach (Transform waypoint in transform)
        {
            waypoints.Add(waypoint);
        }
    }

    public Transform GetNearestWaypoint(Vector3 position)
    {
        Transform nearestWaypoint = null;
        float minDistance = Mathf.Infinity;

        foreach (Transform waypoint in waypoints)
        {
            float distance = Vector3.Distance(position, waypoint.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestWaypoint = waypoint;
            }
        }

        return nearestWaypoint;
    }
}
