using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionDialogue : MonoBehaviour
{
    public TextAsset theText;
    public TextAsset acceptText;
    public TextAsset denyText;
    public TextAsset politeText;
    public TextAsset meanText;
    public TextAsset postAcceptText;
    public TextAsset questComplete;


    public GameObject interactKey;

    public int startLine;
    public int endLine;

    public MissionManager theTextBox;

    public bool requireButtonPress;
    private bool waitForPress;

    public bool destroyWhenActivated;
    public MissionManager missionManager;

    public bool choiceMade;
    public bool secondChoiceMade;
    public bool acceptedQuest;

    public GameObject questDone;

    public bool startBattle;

    public ActivateText activateText;
    
    private void Start()
    {
        theTextBox = FindObjectOfType<MissionManager>();
        interactKey.SetActive(false);
        choiceMade = false;
        secondChoiceMade = false;
        startBattle = false;
        questDone.SetActive(false);
        
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

                if (acceptedQuest && !activateText.questAdvanced)
                {
                    theTextBox.ReloadScript(postAcceptText);
                    theTextBox.currentLine = startLine;
                    endLine = 1;
                    theTextBox.endAtLine = endLine;
                    theTextBox.EnableTextBox();
                }
                
                else if (acceptedQuest && activateText.questAdvanced)
                {
                    theTextBox.ReloadScript(questComplete);
                    theTextBox.currentLine = startLine;
                    endLine = 3;
                    theTextBox.endAtLine = endLine;
                    theTextBox.EnableTextBox();
                    questDone.SetActive(true);
                }

                else
                {
                    choiceMade = false;
                    secondChoiceMade = false;
                    theTextBox.ReloadScript(theText);
                    theTextBox.currentLine = startLine;
                    endLine = 4;
                    theTextBox.endAtLine = endLine;
                    theTextBox.EnableTextBox();
                }
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
    
    
    public void QuestAccepted()
    {
        choiceMade = true;
        secondChoiceMade = true;
        currencyContainer.flower++;
        currencyContainer.fertiliser++;
        acceptedQuest = true;
        missionManager.firstChoice.SetActive(false);

        theTextBox.ReloadScript(acceptText);
        theTextBox.currentLine = startLine;
        endLine = 0;
        theTextBox.endAtLine = endLine;
        theTextBox.EnableTextBox();
    }

    public void QuestDenied()
    {
        choiceMade = true;
        missionManager.firstChoice.SetActive(false);
        
        theTextBox.ReloadScript(denyText);
        theTextBox.currentLine = startLine;
        endLine = 0;
        theTextBox.endAtLine = endLine;
        theTextBox.EnableTextBox();
    }

    public void KindRejection()
    {
        secondChoiceMade = true;
        missionManager.secondChoice.SetActive(false);
        
        theTextBox.ReloadScript(politeText);
        theTextBox.currentLine = startLine;
        endLine = 0;
        theTextBox.endAtLine = endLine;
        theTextBox.EnableTextBox();
    }

    public void MeanRejection()
    {
        secondChoiceMade = true;
        startBattle = true;
        missionManager.secondChoice.SetActive(false);
        
        theTextBox.ReloadScript(meanText);
        theTextBox.currentLine = startLine;
        endLine = 0;
        theTextBox.endAtLine = endLine;
        theTextBox.EnableTextBox(); 
    }
    
}
