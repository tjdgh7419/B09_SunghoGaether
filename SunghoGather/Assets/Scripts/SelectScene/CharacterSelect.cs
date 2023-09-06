using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
   
    public void Player1_NextScene()
    {
        PlayerPrefs.SetString("Player", "1");
		SceneManager.LoadScene("MainScene");
    }

	public void Player2_NextScene()
	{
		PlayerPrefs.SetString("Player", "2");
		SceneManager.LoadScene("MainScene");
	}

}
