using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
// public class AnswerObjectQ2
// {
//     public string qnumber { get; set; }
//     public string choice1 { get; set; }
//     public string choice2 { get; set; }
//     public string choice3 { get; set; }
//     public string choice4 { get; set; }
//     public string rightAnswer { get; set; }
//     public string explanation { get; set; }
// }

// public static class ParametersQ2
// {
//     public static AnswerObject questionDetails { get; set; }
//     public static string answer { get; set; }
// }
public class QuestionScriptQ2 : MonoBehaviour
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
            choice1 = "A. ten thousandths",
            choice2 = "B. tenths",
            choice3 = "C. thousands",
            choice4 = "D. million",
            rightAnswer = "B. tenths",
            explanation = "1+8+1+5+0 = 30, 30 is divisible by 3, therefore, 18,150 is divisible by 3",
        },
        new AnswerObject {
            qnumber = "2",
            choice1 = "A. 4.8",
            choice2 = "B. 4.87",
            choice3 = "C. 4.7",
            choice4 = "D. 4.78",
            rightAnswer = "B. 4.87",
            explanation = "71 is a prime number. The number 71 is divisible only by 1 and the number itself.For a number to be classified as prime number, it should have exactly two factors. Since 71 has exactly two factors, i.e. 1 and 71, it is a prime number.",
        },
        new AnswerObject {
            qnumber = "3",
            choice1 = "A. <",
            choice2 = "B. >",
            choice3 = "C. =",
            choice4 = "D. ≠",
            rightAnswer = "A. >",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "4",
            choice1 = "A.  6.351",
            choice2 = "B.  63.21",
            choice3 = "C.  638.1",
            choice4 = "D.  6381.0",
            rightAnswer = "D. 6381.0",
            explanation = "The factors of number 84 are 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42 and 84. Therefore, 4 is a factor of 84",
        },
        new AnswerObject {
            qnumber = "5",
            choice1 = "A.  The amount of money Matthew spend.",
            choice2 = "B.  The amount of money Matthew started with.",
            choice3 = "C.  The amount of money left with Matthew.",
            choice4 = "D.  The amount of money Matthew had after spending.",
            rightAnswer = "B. The amount of money Matthew started with.",
            explanation = "A natural number is divisible by 8 if the last three digits are zeros or the number formed by the last three-digit is divisible by 8.Calculation: ⇒ 88 is the product of 8 and 11.",
        },
        new AnswerObject {
            qnumber = "6",
            choice1 = "A. Addition",
            choice2 = "B. Subtraction",
            choice3 = "C. Addition and subtraction",
            choice4 = "D. Multiplication",
            rightAnswer = "A. Addition",
            explanation = "By using a PEMDAS rule: 100 – (14 + 37) ÷ 3 + 14 × 2  Parenthesis First 100 – 51 ÷ 3 + 14 × 2  Division since it comes first in the equations 100 – 17 + 14 × 2  Multiplication 100 – 17 + 28  Subtraction since it comes first in the equations 83 + 28  Addition = 111  Correct Answer",
        },
        new AnswerObject {
            qnumber = "7",
            choice1 = "A. 14.28",
            choice2 = "B. 14.38",
            choice3 = "C. 15.28",
            choice4 = "D. 15.38",
            rightAnswer = "B.14.28",
            explanation = "(17+15) ÷ (124-116) 32 ÷ 8 = 4",
        },
        new AnswerObject {
            qnumber = "8",
            choice1 = "A. 0.056",
            choice2 = "B. 0.56",
            choice3 = "C. 1.56",
            choice4 = "D. 2.56",
            rightAnswer = "D. 2.56",
            explanation = "Step 1: Arrange the given horizontally. 30,45 60 Step 2: Write the common prime divisor at the left-hand side and the quotients below the number. 15 30 45 60 2 3 4 Step 3: Repeat the process until two numbers have no more common factors. 1 2 3 4 2 3 4 Step 4: Multiply all the numbers in the last row, the numbers are 15 and 1. 15 x 1 = 15 Therefore, the GCF of 30, 45, and 60 is 15.",
        },
        new AnswerObject {
            qnumber = "9",
            choice1 = "A. 50",
            choice2 = "B. 60",
            choice3 = "C. 70",
            choice4 = "D. 80",
            rightAnswer = "D. 80",
            explanation = "Factors of 30: (1, 2, 3, 5, 6, 10, 15, 30)Factors of 36: (1, 2, 3, 4, 6, 9, 12, 18, 36) The GCF (30 and 36) is 6 Use the listing Multiples to find LCM Multiples of 30: (30, 60, 90, 120, 150 and 180) Multiples of 36: (36, 72, 108, 144, and 180) The LCM (30 and 36) is 180",
        },
        new AnswerObject {
            qnumber = "10",
            choice1 = "A. 20",
            choice2 = "B. 21",
            choice3 = "B. 21",
            choice4 = "D. 24",
            rightAnswer = "D. 24",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "11",
            choice1 = "A. 0.08",
            choice2 = "B. 0.8",
            choice3 = "C. 0.18",
            choice4 = "D. 0.018",
            rightAnswer = "B. 0.8",
            explanation = "A proper fraction is a fraction that has no whole number part and its numerator is smaller than its denominator. Since 33 is the numerator and 35 is the denominator. Therefore, the given is a Proper Fraction.",
        },
        new AnswerObject {
            qnumber = "12",
            choice1 = "A. 1.9",
            choice2 = "B. 0.16",
            choice3 = "C. 1.6",
            choice4 = "D. 0.19",
            rightAnswer = "C. 1.6",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "13",
            choice1 = "A. 3/4",
            choice2 = "B. 3 5/4",
            choice3 = "C. 4 5/4",
            choice4 = "D. 5 3/4",
            rightAnswer = "D. 5 3/4",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "14",
            choice1 = "A. 1.9",
            choice2 = "B. 0.16",
            choice3 = "C. 1.6",
            choice4 = "D. 0.19",
            rightAnswer = "C.1.6",
            explanation = "",
        },

        new AnswerObject {
            qnumber = "15",
            choice1 = "A. 1:3",
            choice2 = "B. 2:3",
            choice3 = "C. 3:4",
            choice4 = "D. 4:5",
            rightAnswer = "A. 1:3",
        },
        new AnswerObject {
            qnumber = "16",
            choice1 = "A. 4:5",
            choice2 = "B. 5:6",
            choice3 = "C. 3:4",
            choice4 = "D. 1:2",
            rightAnswer = "C. 3:4",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "17",
            choice1 = "A. Polygon",
            choice2 = "B. Proportion",
            choice3 = "C. Ratio",
            choice4 = "D. Expression.",
            rightAnswer = "D. 25/36",
            explanation = "B. Proportion",
        },
        new AnswerObject {
            qnumber = "18",
            choice1 = "A. 3:5 and 6:10",
            choice2 = "B. 12:15 and 4:5",
            choice3 = "C. 4:18 and 9:6",
            choice4 = "D. 18:20 and 9:10",
            rightAnswer = "C. 4:18 and 9:6",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "19",
            choice1 = "A. 5022",
            choice2 = "B. 997",
            choice3 = "C. 1456",
            choice4 = "D. 883",
            rightAnswer = "C. 1456",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "20",
            choice1 = "A. hundredths ",
            choice2 = "B. tenths",
            choice3 = "C. thousandths",
            choice4 = "D. millions",
            rightAnswer = "A Hundreths",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "21",
            choice1 = "A. 55.369",
            choice2 = "B. 56.369",
            choice3 = "C. 57.369",
            choice4 = "D. 58.369",
            rightAnswer = "A. 55.369",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "22",
            choice1 = "A. 12.75",
            choice2 = "B. 12.55",
            choice3 = "C. 11.85 ",
            choice4 = "D. 11.75",
            rightAnswer = "D. 11.75",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "23",
            choice1 = "A. 8",
            choice2 = "B. 16",
            choice3 = "C. 24",
            choice4 = "D. 32",
            rightAnswer = "C. 24",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "24",
            choice1 = "A. 4.1",
            choice2 = "B. 4.2",
            choice3 = "C. 4.3",
            choice4 = "D. 4.4",
            rightAnswer = "A. 4.1",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "25",
            choice1 = "A. 0.0906",
            choice2 = "B. 0.0916",
            choice3 = "C. 0.0917",
            choice4 = "D. 0.0918",
            rightAnswer = "A. 0.0906",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "26",
            choice1 = "A. Hundredths",
            choice2 = "B. Ones",
            choice3 = "C. Thousandths",
            choice4 = "D. Ten thousandths",
            rightAnswer = "A. True",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "27",
            choice1 = "A. Ones",
            choice2 = "B. Ten thousandths",
            choice3 = "C. Thousandths",
            choice4 = "D. Hundred thousandths",
            rightAnswer = "B. Ten thousandths",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "28",
            choice1 = "A. >",
            choice2 = "B. <",
            choice3 = "C. =",
            choice4 = "D. ≤",
            rightAnswer = "C. =",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "29",
            choice1 = "A. >",
            choice2 = "B. <",
            choice3 = "C. =",
            choice4 = "D. ≤",
            rightAnswer = "B. <",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "30",
            choice1 = "A. 4",
            choice2 = "B. 4.882",
            choice3 = "C. 4.883",
            choice4 = "D. 4.881",
            rightAnswer = "D. 4.881",
            explanation = "",
        },
    };
    string[] questions = new string[] {
        "What is the place value of 4 in 3.465?",
        "What is the value of 7 in 4.876?",
        "Compare the decimal by choosing the right inequality sign. 1.96____ 0.95",
        "Which is the greatest decimal number?",
        "After spending Php 23.25, Matthew still has Php 49.50 left. How much did Matthew",
        "John's father gave him php 235.75 for his birthday. His mother gave him additional php 125.50. What is the operation to be used?",
        "What is  0.34 × 42",
        "0.26 × 6",
        "Estimate the product of 8.05 x 10.20",
        "Estimate the product of 4.25 x 6.30",
        "Divide 12 by 15.",
        "Find the quotient 4.8 ÷ 3",
        "What is 6 battery packs to 5 cell phones",
        "What is. 12 earphones to 6 players",
        "Express the ratios of 22:66 in simplest form",
        "Express the ratios of 4:6 in simplest form",
        "It is a statement that two ratios are equal?",
        "Which of the given ratios are NOT equivalent?",
        "What is the place value of 6 in 3.9645?",
        "Round this numbers to the indicated place value. 812.3845 hundredths ________________",
        "What is 42.05 + 13.319 =",
        "What is 2.35 × 5?",
        "What is 3 x 8 =_____",
        "Find the quotient of 24.6 ÷ 6 =",
        "Find the quotient of 0.5436 ÷ 6 = ",
        "Give the place value of the underlined digit in 43.816",
        "Give the place value of the underlined digit 101.3492?",
        "Compare the given Decimals by writing >,< or =. 8.3_____8.3000",
        "Compare the given Decimals by writing >,< or =.2.699_____2.7",
        "Perform the given operation 3.6 + 1.281",
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
            timeLeft -= 1;
            UpdateTimerText();

        }
        Parameters.questionDetails = answer[randomIndex];
        Parameters.answer = " ";
        switch (answer[randomIndex].qnumber)
        {
            case "1":
                SceneManager.LoadScene("2_q1");
                break;
            case "2":
                SceneManager.LoadScene("2_q2");
                break;
            case "3":
                SceneManager.LoadScene("2_q3");
                break;
            case "4":
                SceneManager.LoadScene("2_q4");
                break;
            case "5":
                SceneManager.LoadScene("2_q5");
                break;
            case "6":
                SceneManager.LoadScene("2_q6");
                break;
            case "7":
                SceneManager.LoadScene("2_q7");
                break;
            case "8":
                SceneManager.LoadScene("2_q8");
                break;
            case "9":
                SceneManager.LoadScene("2_q9");
                break;
            case "10":
                SceneManager.LoadScene("2_q10");
                break;
            case "11":
                SceneManager.LoadScene("2_q11");
                break;
            case "12":
                SceneManager.LoadScene("2_q12");
                break;
            case "13":
                SceneManager.LoadScene("2_q13");
                break;
            case "14":
                SceneManager.LoadScene("2_q14");
                break;
            case "15":
                SceneManager.LoadScene("2_q15");
                break;
            case "16":
                SceneManager.LoadScene("2_q16");
                break;
            case "17":
                SceneManager.LoadScene("2_q17");
                break;
            case "18":
                SceneManager.LoadScene("2_q18");
                break;
            case "19":
                SceneManager.LoadScene("2_q19");
                break;
            case "20":
                SceneManager.LoadScene("2_q20");
                break;
            case "21":
                SceneManager.LoadScene("2_q21");
                break;
            case "22":
                SceneManager.LoadScene("2_q22");
                break;
            case "23":
                SceneManager.LoadScene("2_q23");
                break;
            case "24":
                SceneManager.LoadScene("2_q24");
                break;
            case "25":
                SceneManager.LoadScene("2_q25");
                break;
            case "26":
                SceneManager.LoadScene("2_q26");
                break;
            case "27":
                SceneManager.LoadScene("2_q27");
                break;
            case "28":
                SceneManager.LoadScene("2_q28");
                break;
            case "29":
                SceneManager.LoadScene("2_q29");
                break;
            case "30":
                SceneManager.LoadScene("2_q30");
                break;
            default:
                break;
        }

    }
    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 40f);
        int seconds = Mathf.FloorToInt(timeLeft % 40f);
        slider.value = seconds;
    }
    void clickAnswer(string textValue, int randomIndex, AnswerObject[] answer)
    {
        Parameters.questionDetails = answer[randomIndex];
        Parameters.answer = textValue;
        switch (answer[randomIndex].qnumber)
        {
            case "1":
                SceneManager.LoadScene("2_q1");
                break;
            case "2":
                SceneManager.LoadScene("2_q2");
                break;
            case "3":
                SceneManager.LoadScene("2_q3");
                break;
            case "4":
                SceneManager.LoadScene("2_q4");
                break;
            case "5":
                SceneManager.LoadScene("2_q5");
                break;
            case "6":
                SceneManager.LoadScene("2_q6");
                break;
            case "7":
                SceneManager.LoadScene("2_q7");
                break;
            case "8":
                SceneManager.LoadScene("2_q8");
                break;
            case "9":
                SceneManager.LoadScene("2_q9");
                break;
            case "10":
                SceneManager.LoadScene("2_q10");
                break;
            case "11":
                SceneManager.LoadScene("2_q11");
                break;
            case "12":
                SceneManager.LoadScene("2_q12");
                break;
            case "13":
                SceneManager.LoadScene("2_q13");
                break;
            case "14":
                SceneManager.LoadScene("2_q14");
                break;
            case "15":
                SceneManager.LoadScene("2_q15");
                break;
            case "16":
                SceneManager.LoadScene("2_q16");
                break;
            case "17":
                SceneManager.LoadScene("2_q17");
                break;
            case "18":
                SceneManager.LoadScene("2_q18");
                break;
            case "19":
                SceneManager.LoadScene("2_q19");
                break;
            case "20":
                SceneManager.LoadScene("2_q20");
                break;
            case "21":
                SceneManager.LoadScene("2_q21");
                break;
            case "22":
                SceneManager.LoadScene("2_q22");
                break;
            case "23":
                SceneManager.LoadScene("2_q23");
                break;
            case "24":
                SceneManager.LoadScene("2_q24");
                break;
            case "25":
                SceneManager.LoadScene("2_q25");
                break;
            case "26":
                SceneManager.LoadScene("2_q26");
                break;
            case "27":
                SceneManager.LoadScene("2_q27");
                break;
            case "28":
                SceneManager.LoadScene("2_q28");
                break;
            case "29":
                SceneManager.LoadScene("2_q29");
                break;
            case "30":
                SceneManager.LoadScene("2_q30");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
