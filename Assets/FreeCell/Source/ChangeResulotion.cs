using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeResulotion : MonoBehaviour
{
    public Text okok;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnRectTransformDimensionsChange() {
        Debug.Log("ashjasbjsda");
        okok.text = "sadhbasd";
;    }
}//
