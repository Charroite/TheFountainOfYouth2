using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HoverUI : MonoBehaviour
{
    public string MyString;
    public Text myText;
    public float fadeTime;
    private bool displayInfo;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Text").GetComponent<Text>();
        myText.color = Color.white;
        displayInfo = true;

    }

    // Update is called once per frame
    void Update()
    {
        myText.text = MyString;
        if (Input.GetKeyDown(KeyCode.E))
        {
            displayInfo = false;
            myText.color = Color.clear;
        }
       
       
       // FadeText();
    }

  private void OnMouseOver()
 {
     displayInfo = true;
 }



    //private void OnMouseExit()
    //{
    //    displayInfo = false;
    // }


    void FadeText() {
        if (displayInfo)
        {
            myText.text = MyString;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else {
            
     
        }
    }
}
