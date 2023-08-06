using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{

    public float moveSpeed = 10;
    public float deadZone = -40;

    private float curMoveSpeed = 10;

    void Start()
    {
        curMoveSpeed = moveSpeed;
    }

    void Update()
    {
        curMoveSpeed = moveSpeed + GameLogic.userScore / 2.0f;

        transform.position += Vector3.left * curMoveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
