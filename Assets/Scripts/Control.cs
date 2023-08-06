using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public static bool canMove = true;

    public float jumpPower = 10;
    public Rigidbody2D body;
    private GameLogic logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    void Update()
    {
        if (canMove && Input.GetKeyDown(KeyCode.Space))
            body.velocity = Vector2.up * jumpPower;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        canMove = false;
    }
}
