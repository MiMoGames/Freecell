using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gamePlay() {
        SceneManager.LoadScene("FreeCell Scene");
    }

    public void PanelOneSetting()
    {
        Panel1.SetActive(true);
    }
    public void PanelTwoGoal()
    {
        Panel2.SetActive(true);
    }
    public void PanelThreeDeal()
    {
        Panel3.SetActive(true);
    }
}//class
