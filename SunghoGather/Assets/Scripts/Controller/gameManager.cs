using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Text PlayerNameTxt;
    string pname = null;

	// Start is called before the first frame update
	void Start()
    {
        pname = PlayerPrefs.GetString("CurrentName");
        PlayerNameTxt.text = pname;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
