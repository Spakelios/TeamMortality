using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextboxManager : MonoBehaviour
{
    public GameObject textBox;
    public TextMeshProUGUI theText;
    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;
    
    public KeyboardPlayerMovement player;

    public bool isActive;
    public bool stopPlayerMovement;
    void Start()
    {
        player = FindObjectOfType<KeyboardPlayerMovement>();
        
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }

        if (isActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }
    }

    private void Update()
    {

        if (!isActive)
        {
            return;
        }
        
        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Space) && currentLine < 4)
        {
            currentLine += 1;
        }

        if (currentLine > endAtLine)
        {
            DisableTextBox();
        }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;

        if (stopPlayerMovement)
        {
            player.canMove = false;
        }
    }

    private void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;

        player.canMove = true;
    }

    public void ReloadScript(TextAsset theText)
    {
        if (theText != null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
        }
    }
}
