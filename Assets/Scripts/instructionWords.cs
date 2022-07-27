using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class instructionWords : MonoBehaviour
{
    public TMP_Text output;
    ArrayList sentences = new ArrayList();

    public GameObject floor;

    public GameObject bounce;

    public GameObject canvas;

    public GameObject panel;

    int i = 0;

    void Start()
    {

        string sentenceZero = "Reach the end without running into obstacles!";
        string sentenceOne = "If the dark blue obstacles are on the floor, you can jump over them!";
        string sentenceTwo = "The light blue obstacles are taller, so don't try jumping these!";
        string sentenceThree = "The white surface is safe, stick to it as much as possible!";
        string sentenceFour = "The green surface is bouncy, jump on it to gain some extra height!";
        string sentenceFive = "Move the cube side to side with A and D or the LEFT and RIGHT arrow keys";
        string sentenceSix = "Jump with W or the UP arrow key";
        string sentenceSeven = "Beat all 5 levels to win. Good luck!";

        sentences.Add(sentenceZero);
        sentences.Add(sentenceOne);
        sentences.Add(sentenceTwo);
        sentences.Add(sentenceThree);
        sentences.Add(sentenceFour);
        sentences.Add(sentenceFive);
        sentences.Add(sentenceSix);
        sentences.Add(sentenceSeven);
                
    }


    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
        }

        if (i > sentences.Count-1)
        {
            SceneManager.LoadScene("Intro");
        }

        else
        {
            output.text = sentences[i].ToString();
            if (output.text == sentences[3].ToString())
            {
                floor.SetActive(true);
                bounce.SetActive(true);
                canvas.GetComponent<Animator>().enabled = true;
            }

            if (output.text == sentences[5].ToString())
            {
                panel.GetComponent<Animator>().enabled = true;
            }
        }
        
        

        
    }


    
}
