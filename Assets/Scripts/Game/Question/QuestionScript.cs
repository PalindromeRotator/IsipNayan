using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class AnswerObject
{
    public string qnumber { get; set; }
    public string choice1 { get; set; }
    public string choice2 { get; set; }
    public string choice3 { get; set; }
    public string choice4 { get; set; }
    public string rightAnswer { get; set; }
    public string explanation { get; set; }
}

public static class Parameters
{
    public static AnswerObject questionDetails { get; set; }
    public static string answer { get; set; }
}
public class QuestionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text question_text;
    public TMP_Text choice1;
    public TMP_Text choice2;
    public TMP_Text choice3;
    public TMP_Text choice4;
    public Button choice1Btn;
    public Button choice2Btn;
    public Button choice3Btn;
    public Button choice4Btn;

    public Slider slider;

    public float timeLeft = 40f;

    AnswerObject[] answer = new AnswerObject[]{
        new AnswerObject {
            qnumber = "1",
            choice1 = "A. Divisible by 4",
            choice2 = "B. Divisible by 7",
            choice3 = "C. Divisible by 3",
            choice4 = "D. Divisible by 2",
            rightAnswer = "C. Divisible by 3",
            explanation = "1+8+1+5+0 = 30, 30 is divisible by 3, therefore, 18,150 is divisible by 3",
        },
        new AnswerObject {
            qnumber = "2",
            choice1 = "A. True",
            choice2 = "B. False",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "A. True",
            explanation = "71 is a prime number. The number 71 is divisible only by 1 and the number itself.For a number to be classified as prime number, it should have exactly two factors. Since 71 has exactly two factors, i.e. 1 and 71, it is a prime number.",
        },
        new AnswerObject {
            qnumber = "3",
            choice1 = "A. 88",
            choice2 = "B. 69",
            choice3 = "C. 45",
            choice4 = "D. 90",
            rightAnswer = "A. 88",
            explanation = "A natural number is divisible by 8 if the last three digits are zeros or the number formed by the last three-digit is divisible by 8.Calculation: ⇒ 88 is the product of 8 and 11.",
        },
        new AnswerObject {
            qnumber = "4",
            choice1 = "A. 6",
            choice2 = "B. 77",
            choice3 = "C. 84",
            choice4 = "D. 94",
            rightAnswer = "C. 84",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "5",
            choice1 = "A. 100",
            choice2 = "B. 115",
            choice3 = "C. 111",
            choice4 = "D. 90",
            rightAnswer = "C. 111",
            explanation = "The factors of number 84 are 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42 and 84. Therefore, 4 is a factor of 84",
        },
        new AnswerObject {
            qnumber = "6",
            choice1 = "A. 2",
            choice2 = "B. 4",
            choice3 = "C. 0",
            choice4 = "D. 6",
            rightAnswer = "B. 4",
            explanation = "By using a PEMDAS rule: 100 – (14 + 37) ÷ 3 + 14 × 2  Parenthesis First 100 – 51 ÷ 3 + 14 × 2  Division since it comes first in the equations 100 – 17 + 14 × 2  Multiplication 100 – 17 + 28  Subtraction since it comes first in the equations 83 + 28  Addition = 111  Correct Answer",
        },
        new AnswerObject {
            qnumber = "7",
            choice1 = "A. 15",
            choice2 = "B. 7",
            choice3 = "C. 10",
            choice4 = "D. 12",
            rightAnswer = "A. 15",
            explanation = "(17+15) ÷ (124-116) 32 ÷ 8 = 4",
        },
        new AnswerObject {
            qnumber = "8",
            choice1 = "A. GCF: 6 ; LCM:180",
            choice2 = "B. GCF: 3 ; LCM:170",
            choice3 = "C. GCF: 6 ; LCM:170",
            choice4 = "D. GCF: 3 ; LCM:180",
            rightAnswer = "A. GCF: 6 ; LCM:180",
            explanation = "Step 1: Arrange the given horizontally. 30,45 60 Step 2: Write the common prime divisor at the left-hand side and the quotients below the number. 15 30 45 60 2 3 4 Step 3: Repeat the process until two numbers have no more common factors. 1 2 3 4 2 3 4 Step 4: Multiply all the numbers in the last row, the numbers are 15 and 1. 15 x 1 = 15 Therefore, the GCF of 30, 45, and 60 is 15.",
        },
        new AnswerObject {
            qnumber = "9",
            choice1 = "A. Improper fraction",
            choice2 = "B. Fraction",
            choice3 = "C. Proper fraction",
            choice4 = "D. None of the above",
            rightAnswer = "C. Proper fraction",
            explanation = "Factors of 30: (1, 2, 3, 5, 6, 10, 15, 30)Factors of 36: (1, 2, 3, 4, 6, 9, 12, 18, 36) The GCF (30 and 36) is 6 Use the listing Multiples to find LCM Multiples of 30: (30, 60, 90, 120, 150 and 180) Multiples of 36: (36, 72, 108, 144, and 180) The LCM (30 and 36) is 180",
        },
        new AnswerObject {
            qnumber = "10",
            choice1 = "A. 6/8",
            choice2 = "B. 3/9",
            choice3 = "C. 6",
            choice4 = "D. 7/9",
            rightAnswer = "D. 7/9",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "11",
            choice1 = "A. 3 and 4/13",
            choice2 = "B. 4 and 8/13",
            choice3 = "C. 2 and 3/13",
            choice4 = "D. 6/13",
            rightAnswer = "B. 4 and 8/13",
            explanation = "A proper fraction is a fraction that has no whole number part and its numerator is smaller than its denominator. Since 33 is the numerator and 35 is the denominator. Therefore, the given is a Proper Fraction.",
        },
        new AnswerObject {
            qnumber = "12",
            choice1 = "A. 3/4",
            choice2 = "B. 3 and 5/4",
            choice3 = "C. 4 and 4/5",
            choice4 = "D. 5 and 3/4",
            rightAnswer = "D. 5 and 3/4",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "13",
            choice1 = "A. False",
            choice2 = "B. True",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "A. False",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "14",
            choice1 = "A. False",
            choice2 = "B. True",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "B. True",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "15",
            choice1 = "A. 8",
            choice2 = "B. 4",
            choice3 = "C. 0",
            choice4 = "D. None of the above",
            rightAnswer = "A. 8",
        },
        new AnswerObject {
            qnumber = "16",
            choice1 = "A. False",
            choice2 = "B. True",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "B. True",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "17",
            choice1 = "A. 22/36",
            choice2 = "B. 20/36",
            choice3 = "C. 15/36",
            choice4 = "D. 25/36",
            rightAnswer = "D. 25/36",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "18",
            choice1 = "A. 55 pieces",
            choice2 = "B. 50 pieces",
            choice3 = "C. 53 pieces",
            choice4 = "D. 56 pieces",
            rightAnswer = "D. 56 pieces",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "19",
            choice1 = "A. 5,022",
            choice2 = "B. 997",
            choice3 = "C. 1,456",
            choice4 = "D. 883",
            rightAnswer = "C. 1,456",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "20",
            choice1 = "A. 94",
            choice2 = "B. 88",
            choice3 = "C. 86",
            choice4 = "D. 84",
            rightAnswer = "D. 84",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "21",
            choice1 = "A. 1,2,3,6",
            choice2 = "B. 2,3,4",
            choice3 = "C. 1,6",
            choice4 = "D. 4,6,8",
            rightAnswer = "A. 1,2,3,6",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "22",
            choice1 = "A. 1",
            choice2 = "B. 1/6",
            choice3 = "C. 7/6",
            choice4 = "D. 6",
            rightAnswer = "B. 1/6",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "23",
            choice1 = "A. 5/5",
            choice2 = "B. 1",
            choice3 = "C. 6/6",
            choice4 = "D. 6/5",
            rightAnswer = "D. 6/5",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "24",
            choice1 = "A. 6",
            choice2 = "B. 3",
            choice3 = "C. 8",
            choice4 = "D. 4",
            rightAnswer = "A. 6",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "25",
            choice1 = "A. 5/4",
            choice2 = "B. 1/8",
            choice3 = "C. 1/4",
            choice4 = "D. 5/8",
            rightAnswer = "C. 1/4",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "26",
            choice1 = "A. True",
            choice2 = "B. False",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "A. True",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "27",
            choice1 = "A. 156",
            choice2 = "B. 245",
            choice3 = "C. 367",
            choice4 = "D. 4.4",
            rightAnswer = "A. 156",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "28",
            choice1 = "A. Yes",
            choice2 = "B. No",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "B. No",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "29",
            choice1 = "A. True",
            choice2 = "B. False",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "A. True",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "30",
            choice1 = "A. True",
            choice2 = "B. False",
            choice3 = "C. Maybe",
            choice4 = "D. None of the above",
            rightAnswer = "A. True",
            explanation = "",
        },
    };
    string[] questions = new string[] {
        "The digit 87, 150 is divisible by which of the following number?",
        "Is 71 a PRIME number and not COMPOSITE?",
        "Which of the following numbers are divisible by 8?",
        "4 is a factor of what number?",
        "What is the value of the expression 100 – (14 + 37) ÷ 3 + 14 x 2?",
        "What is the answer if the sum of 17 and 15 is divided by the difference between 124 and 116?",
        "What is the greatest common factor (GCF) of 30, 45, and 60?",
        "Find the GCF and LCM of 30 and 36.",
        "Identify the given fraction if it is a proper or improper fraction with the given value of 33/35.",
        "What is 2 and 4/9 subtracted to 1 and 4/6?",
        "Find the value of N in the equation 6/13 x 10 = N.",
        "What is 1 and 2/4 multiplied by 3 and 5/6?",
        "The reciprocal of 5 is 5/1.",
        "Is 200 x 1/200 = 1?",
        "What is the reciprocal of 1/8?",
        "The reciprocal of 7/11 is 11/7.",
        "Find the average of 2/3, 5/6 and 7/12.",
        "If each of 7 cakes is cut into eight, how many pieces will there be?",
        "What number is divisible by 4?",
        "8 x (9 + 2) - 4",
        "Find the common factors of 18 and 24.",
        "What is 1 x 1/6?",
        "What is the reciprocal of 5/6?",
        "What is 2 ÷ 1/3?",
        "What is 3/4 - 2/4?",
        "4,203 is divisible by 9.",
        "Which of the following numbers are divisible by 3?",
        "Is 8,602 divisible by 3?",
        "372 is divisible by 4.",
        "A number is divisible by 12 if it is divisible by both 3 and 4.",
    };
    void Start()
    {
        int randomIndex = UnityEngine.Random.Range(0, 29);
        initiateQuestionAndANswer(randomIndex);
        StartCoroutine(Countdown(randomIndex, answer));
        onClickButtons(choice1Btn, choice1.text, randomIndex, answer);
        onClickButtons(choice2Btn, choice2.text, randomIndex, answer);
        onClickButtons(choice3Btn, choice3.text, randomIndex, answer);
        onClickButtons(choice4Btn, choice4.text, randomIndex, answer);
    }
    public void onClickButtons(Button button, string textValue, int randomIndex, AnswerObject[] answer)
    {
        button.onClick.AddListener(() => clickAnswer(textValue, randomIndex, answer));
    }
    public void initiateQuestionAndANswer(int randomIndex)
    {

        question_text.text = questions[randomIndex];
        choice1.text = answer[randomIndex].choice1;
        choice2.text = answer[randomIndex].choice2;
        choice3.text = answer[randomIndex].choice3;
        choice4.text = answer[randomIndex].choice4;
    }
    IEnumerator Countdown(int randomIndex, AnswerObject[] answer)
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1f);
            timeLeft -= 1f;
            UpdateTimerText();

        }

        Parameters.questionDetails = answer[randomIndex];
        Parameters.answer = " ";
        switch (answer[randomIndex].qnumber)
        {
            case "1":
                SceneManager.LoadScene("q1");
                break;
            case "2":
                SceneManager.LoadScene("q2");
                break;
            case "3":
                SceneManager.LoadScene("q3");
                break;
            case "4":
                SceneManager.LoadScene("q4");
                break;
            case "5":
                SceneManager.LoadScene("q5");
                break;
            case "6":
                SceneManager.LoadScene("q6");
                break;
            case "7":
                SceneManager.LoadScene("q7");
                break;
            case "8":
                SceneManager.LoadScene("q8");
                break;
            case "9":
                SceneManager.LoadScene("q9");
                break;
            case "10":
                SceneManager.LoadScene("q10");
                break;
            case "11":
                SceneManager.LoadScene("q11");
                break;
            case "12":
                SceneManager.LoadScene("q12");
                break;
            case "13":
                SceneManager.LoadScene("q13");
                break;
            case "14":
                SceneManager.LoadScene("q14");
                break;
            case "15":
                SceneManager.LoadScene("q15");
                break;
            case "16":
                SceneManager.LoadScene("q16");
                break;
            case "17":
                SceneManager.LoadScene("q17");
                break;
            case "18":
                SceneManager.LoadScene("q18");
                break;
            case "19":
                SceneManager.LoadScene("q19");
                break;
            case "20":
                SceneManager.LoadScene("q20");
                break;
            case "21":
                SceneManager.LoadScene("q21");
                break;
            case "22":
                SceneManager.LoadScene("q22");
                break;
            case "23":
                SceneManager.LoadScene("q23");
                break;
            case "24":
                SceneManager.LoadScene("q24");
                break;
            case "25":
                SceneManager.LoadScene("q25");
                break;
            case "26":
                SceneManager.LoadScene("q26");
                break;
            case "27":
                SceneManager.LoadScene("q27");
                break;
            case "28":
                SceneManager.LoadScene("q28");
                break;
            case "29":
                SceneManager.LoadScene("q29");
                break;
            case "30":
                SceneManager.LoadScene("q30");
                break;
            default:
                break;
        }

    }
    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 40f);
        int seconds = Mathf.FloorToInt(timeLeft % 40f);
        Debug.Log(seconds);
        slider.value = seconds;
    }
    void clickAnswer(string textValue, int randomIndex, AnswerObject[] answer)
    {
        Parameters.questionDetails = answer[randomIndex];
        Parameters.answer = textValue;
        switch (answer[randomIndex].qnumber)
        {
            case "1":
                SceneManager.LoadScene("q1");
                break;
            case "2":
                SceneManager.LoadScene("q2");
                break;
            case "3":
                SceneManager.LoadScene("q3");
                break;
            case "4":
                SceneManager.LoadScene("q4");
                break;
            case "5":
                SceneManager.LoadScene("q5");
                break;
            case "6":
                SceneManager.LoadScene("q6");
                break;
            case "7":
                SceneManager.LoadScene("q7");
                break;
            case "8":
                SceneManager.LoadScene("q8");
                break;
            case "9":
                SceneManager.LoadScene("q9");
                break;
            case "10":
                SceneManager.LoadScene("q10");
                break;
            case "11":
                SceneManager.LoadScene("q11");
                break;
            case "12":
                SceneManager.LoadScene("q12");
                break;
            case "13":
                SceneManager.LoadScene("q13");
                break;
            case "14":
                SceneManager.LoadScene("q14");
                break;
            case "15":
                SceneManager.LoadScene("q15");
                break;
            case "16":
                SceneManager.LoadScene("q16");
                break;
            case "17":
                SceneManager.LoadScene("q17");
                break;
            case "18":
                SceneManager.LoadScene("q18");
                break;
            case "19":
                SceneManager.LoadScene("q19");
                break;
            case "20":
                SceneManager.LoadScene("q20");
                break;
            case "21":
                SceneManager.LoadScene("q21");
                break;
            case "22":
                SceneManager.LoadScene("q22");
                break;
            case "23":
                SceneManager.LoadScene("q23");
                break;
            case "24":
                SceneManager.LoadScene("q24");
                break;
            case "25":
                SceneManager.LoadScene("q25");
                break;
            case "26":
                SceneManager.LoadScene("q26");
                break;
            case "27":
                SceneManager.LoadScene("q27");
                break;
            case "28":
                SceneManager.LoadScene("q28");
                break;
            case "29":
                SceneManager.LoadScene("q29");
                break;
            case "30":
                SceneManager.LoadScene("q30");
                break;
            default:
                break;
        }
    }
    public void getTextQuestion()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}
