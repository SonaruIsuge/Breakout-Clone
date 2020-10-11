using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour
{
    BallControl B_ball = new BallControl();
    public GameObject ball;
    void Start()
    {
        UIControl.s_brickCount++;
        B_ball = ball.GetComponent<BallControl>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        B_ball.score += 10;
        UIControl.s_brickCount--;
        Destroy(gameObject);
    }
}
