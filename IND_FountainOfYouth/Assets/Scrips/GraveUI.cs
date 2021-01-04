using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GraveUI : MonoBehaviour
{
    public string MyString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;
    public AudioSource someSound;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("GraveText").GetComponent<Text>();
        myText.color = Color.clear;
        someSound.Stop();

    }

    // Update is called once per frame
    void Update()
    {
    
        FadeText();

        

    }

  private void OnMouseOver()
    {
     displayInfo = true;
    }



   private void OnMouseExit()
    {
       displayInfo = false;
    }


    void FadeText() {
        if (displayInfo)
        {
            myText.text = MyString;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.F) && displayInfo == true)
        {
            if (!someSound.isPlaying)
            {
                someSound.Play();
            }
        }

        if (Input.GetKeyUp(KeyCode.F) && displayInfo == false)
        {
            someSound.Stop();
        }
    }
}
