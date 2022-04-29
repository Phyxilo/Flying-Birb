using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float initObsSpeed = 1;
    public static float obsSpeed = 1;

    private static float timer = 0;

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        obsSpeed = initObsSpeed + timer/10000;
        transform.position += new Vector3(-Time.fixedDeltaTime * obsSpeed, 0, 0);

    }
}
