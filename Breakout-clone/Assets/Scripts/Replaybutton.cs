using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replaybutton : MonoBehaviour
{
    public void ReplayButtonClick()
    {
        SceneManager.LoadScene("LevelOne");
    }
}
