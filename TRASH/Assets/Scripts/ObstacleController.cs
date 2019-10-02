using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float yDistance = 10;
    public float minSpread = 5;
    public float maxSpread = 10;

    public Transform playerTransform;
    public Transform obstaclePrefab;
    public Transform GarbagePickupPrefab;

    float ySpread;
    float lastYPos;

    void Start()
    {
        lastYPos = Mathf.NegativeInfinity;
        ySpread = Random.Range(minSpread, maxSpread);
    }

    void Update()
    {
        if (playerTransform.position.y - lastYPos >= ySpread)
        {
            float lanePos = Random.Range(-10, 10);
            lanePos = (lanePos - 1) + 2.86f;
            Instantiate(obstaclePrefab, new Vector3(lanePos, playerTransform.position.y + yDistance, 0), Quaternion.identity);

            float lanePos2 = Random.Range(-10, 10);
            lanePos2 = (lanePos2 - 1) + 2.86f;
            Instantiate(GarbagePickupPrefab, new Vector3(lanePos2, playerTransform.position.y + yDistance, 0), Quaternion.identity);

            lastYPos = playerTransform.position.y;
            ySpread = Random.Range(minSpread, maxSpread);
        }
    }
}
