using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_TextDetection : MonoBehaviour
{
    //public Scr_WordBank wordBank = null;
    public Text displayText = null;

    private string actualText = string.Empty;
    public string currentWord = string.Empty;

    public Scr_Player_EffectGiver player;

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentWord();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    private void SetCurrentWord()
    {
        //currentWord = wordBank.GetWord();
        SetRemainingWord(currentWord);

    }

    private void SetRemainingWord(string newString)
    {
        actualText = newString;
        displayText.text = actualText;

    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keyPressed = Input.inputString;

            if (keyPressed.Length == 1)
            {
                EnterLetter(keyPressed);
            }

        }

    }

    private void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            RemoveLetter();
               
            if (IsWordComplete()) //Une fois le mot complété
            {
                SetCurrentWord();
                player.Effect(currentWord);
            }
        }
        else 
        {
            SetCurrentWord();
        }
    }

    private bool IsCorrectLetter(string letter) 
    {
        return actualText.IndexOf(letter) == 0; 
    }

    private void RemoveLetter() //On enlève la première lettre du mot affiché
    {
        string newString = actualText.Remove(0, 1);
        SetRemainingWord(newString);      
    }

    private bool IsWordComplete()
    {
        return actualText.Length == 0;
    }






}
