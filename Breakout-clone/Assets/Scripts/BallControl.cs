using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public float speed;
    public Rigidbody2D ballRig;
    private Vector2 dir;
    private Vector2 realSpeed;
    public int score;
    static public bool isGameCanPlay;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        ballRig = GetComponent<Rigidbody2D>();
        ballRig.velocity = new Vector2(speed, speed); // 設定初速
        isGameCanPlay = true;
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString(); // 計算分數
        ballRig.velocity = new Vector2(resetSpeedX(), resetSpeedY()); // 調整速度
        //realSpeed = ballRig.velocity; Debug.Log(realSpeed); // 監控速度

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 1) Time.timeScale = 0;
            else Time.timeScale = 1;
        }
    }
    //float hitfactor(Vector2 ballPos, Vector2 playerPos, float PlayerWidth)
    //{
    //    return (ballPos.x - playerPos.x) / PlayerWidth;
    //}
    void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.CompareTag("Player"))
        //{
        //    float newX = hitfactor(transform.position, col.transform.position, col.collider.bounds.size.x);
        //    dir = new Vector2(newX, 1).normalized;
        //    ballRig.velocity = dir * speed;
        //}
        if (col.gameObject.CompareTag("IsGameOver")) // 是否撞到底部
        {
            isGameCanPlay = false;
            this.gameObject.SetActive(isGameCanPlay); 
        }
       
    }

    float resetSpeedX() //鎖定速度
    {
        float currentSpeedX = ballRig.velocity.x;
        if (currentSpeedX < 0)
        {
            return -speed; 
        }
        else
        {
            return speed;
        }
    }

    float resetSpeedY()
    {
        float currentSpeedY = ballRig.velocity.y;
        if (currentSpeedY < 0)
        {
            return -speed;
        }
        else
        {
            return speed;
        }
    }
}
