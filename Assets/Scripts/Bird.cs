using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    private Rigidbody2D rigidbody;
    private PlayMakerFSM fsm;

    void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
        fsm = GetComponent<PlayMakerFSM>();
    }

    public void AddForce(Vector2 force) {
        rigidbody.velocity = new Vector2(0, 0); //先将物体的向下速度设置为0;
        rigidbody.AddForce(force);
    }

    public void OnCollisionEnter2D(Collision2D other) { //发送Over事件
        fsm.SendEvent("Over");
    }
}
