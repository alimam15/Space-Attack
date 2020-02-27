using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    // Config Par
    WaveConfig waveConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;
 
    private void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        MoveEnemy();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;

    }

    private void MoveEnemy()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            //Debug.Log("index " + waypointIndex + " and total points" + waypoints.Count);
            var targetPosition = waypoints[waypointIndex].transform.position;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);

            //Debug.Log("Current pos: " + transform.position + " and target pos: " + targetPosition);
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
