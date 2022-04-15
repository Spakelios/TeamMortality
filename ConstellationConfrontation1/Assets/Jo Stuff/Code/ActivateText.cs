using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateText : MonoBehaviour
{
    public TextAsset theText;

    public GameObject interactKey;

    public int startLine;
    public int endLine;

    public TextboxManager theTextBox;

    public bool requireButtonPress;
    private bool waitForPress;

    public bool destroyWhenActivated;
    

    

    private void Start()
    {
        theTextBox = FindObjectOfType<TextboxManager>();
        interactKey.SetActive(false);



    }

    private void Update()
    {
        if (waitForPress && Input.GetKeyDown(KeyCode.Return))
        {
            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextBox();


            if (destroyWhenActivated)
            {
                Destroy(gameObject);
                
            }

            

        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            interactKey.SetActive(true);
            
            if (Input.GetKey(KeyCode.F))
            {


                if (requireButtonPress)
                {
                    waitForPress = true;
                    return;
                }
                
                theTextBox.ReloadScript(theText);
                theTextBox.currentLine = startLine;
                theTextBox.endAtLine = endLine;
                theTextBox.EnableTextBox();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            waitForPress = false;
            interactKey.SetActive(false);
        }
    }
}
