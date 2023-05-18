using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public AIPath aIPath;

    Vector3 direction;

    void Start()
    {

    }

    void Update()
    {
        faceVelocity();
    }

    void faceVelocity()
    {
        direction = aIPath.desiredVelocity;

        /*transform.up = direction;*/
    }

}
