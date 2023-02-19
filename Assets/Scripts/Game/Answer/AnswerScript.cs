using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AnswerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button NextButton;
    void Start()
    {
        // if (Parameters.questionDetails.rightAnswer == Parameters.answer)
        // {

        // }
        NextButton.onClick.AddListener(ButtonNext);
    }

    void ButtonNext()
    {
        if (Parameters.questionDetails.rightAnswer == Parameters.answer)
        {
            ScoreObject.score += 1;
        }
        ScoreObject.counter++;
        if (ScoreObject.counter < 10)
            SceneManager.LoadScene("QuestionTab");
        else
            SceneManager.LoadScene("ScoreTab");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
