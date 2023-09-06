using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TurnMainScene : MonoBehaviour
{
	public void MainStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
