using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateText : MonoBehaviour
{
    public TextAsset theText;

    public int startLine;
    public int endLine;

    public TextboxManager theTextBox;

    public bool requireButtonPress;
    private bool waitForPress;

    public bool destroyWhenActivated;
    

    

    void Start()
    {
        theTextBox = FindObjectOfType<TextboxManager>();

        
    }

    void Update()
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
        }
    }
}
