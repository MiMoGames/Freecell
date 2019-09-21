using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEventAnimation : MonoBehaviour
{
    public Animator myAnimation;
    public GameObject UpperButton;
    public GameObject LowerButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPanel()
    {
        myAnimation.SetBool("Hide", false);
        UpperButton.SetActive(false);
        LowerButton.SetActive(true);
        myAnimation.SetBool("Show", true);
    }
    public void HidePanel()
    {
        myAnimation.SetBool("Show", false);
        UpperButton.SetActive(true);
        LowerButton.SetActive(false);
        myAnimation.SetBool("Hide", true);
    }

    public void ShowEventPanel()
    {
        myAnimation.SetBool("Show", false);
    }
    public void HideEventPanel()
    {
        myAnimation.SetBool("Hide", false);
    }



}//class
