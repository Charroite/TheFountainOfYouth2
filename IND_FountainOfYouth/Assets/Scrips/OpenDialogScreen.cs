using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDialogScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject DialogUi;
    private bool visible;
    
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && visible == true) {
            DialogUi.gameObject.SetActive(true);
            Debug.Log("test");
        }
        if (Input.GetKeyDown(KeyCode.E) && visible == false) {
            DialogUi.gameObject.SetActive(false);
            Debug.Log("False");
        }

   
            
    }

    private void OnMouseOver()
    {
        visible = true;
    }



    private void OnMouseExit()
    {
        visible = false;
    }

}

