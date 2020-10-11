using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    static public int s_brickCount;
    public Text brickCountText;
    public GameObject ball;
    public GameObject replayButton;
    // Start is called before the first frame update
    void Start()
    {
        replayButton.SetActive(!BallControl.isGameCanPlay);
    }

    // Update is called once per frame
    void Update()
    {
        brickCountText.text = "剩餘磚塊: " + s_brickCount.ToString();

        if (!BallControl.isGameCanPlay)
        {
            replayButton.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    ~UIControl()
    {
        s_brickCount = 0;
    }
}
