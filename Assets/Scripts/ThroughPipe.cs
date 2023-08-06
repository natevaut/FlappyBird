using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroughPipe : MonoBehaviour {

    public GameLogic logic;

    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // Bird through pipe!
        logic.addScore();
    }
}
