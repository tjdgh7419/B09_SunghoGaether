using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
	public InputField playerNameInput;
	private string playerName = null;

	// Start is called before the first frame update
	void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		playerName = playerNameInput.GetComponent<InputField>().text;
		PlayerPrefs.SetString("CurrentName", playerName);
	}
}
