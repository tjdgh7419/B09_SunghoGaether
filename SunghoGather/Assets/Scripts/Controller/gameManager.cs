using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public Text PlayerNameTxt;
	public Text PlayerNameTxt2;
	string pname = null;
    string charChk = null;

	// Start is called before the first frame update
	void Start()
    {
        pname = PlayerPrefs.GetString("CurrentName");
        charChk = PlayerPrefs.GetString("Player");
	    if(charChk == "1") Player1.SetActive(true);
		if (charChk == "2") Player2.SetActive(true);
		PlayerNameTxt.text = pname;
		PlayerNameTxt2.text = pname;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
