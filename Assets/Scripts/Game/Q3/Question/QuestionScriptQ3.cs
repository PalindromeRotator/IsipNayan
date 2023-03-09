using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestionScriptQ3 : MonoBehaviour
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
            choice1 = "A. 2%",
            choice2 = "B. 20%",
            choice3 = "C. 2.2%",
            choice4 = "D. 0.2%",
            rightAnswer = "B. 20%",
            explanation = "1+8+1+5+0 = 30, 30 is divisible by 3, therefore, 18,150 is divisible by 3",
        },
        new AnswerObject {
            qnumber = "2",
            choice1 = "A. 30%",
            choice2 = "B. 3%",
            choice3 = "C. 0.3%",
            choice4 = "D. 300%",
            rightAnswer = "B. 3%",
            explanation = "71 is a prime number. The number 71 is divisible only by 1 and the number itself.For a number to be classified as prime number, it should have exactly two factors. Since 71 has exactly two factors, i.e. 1 and 71, it is a prime number.",
        },
        new AnswerObject {
            qnumber = "3",
            choice1 = "A. 20%",
            choice2 = "B. 25%",
            choice3 = "C. 30%",
            choice4 = "D. 40%",
            rightAnswer = "B. 25%",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "4",
            choice1 = "A. 17.67%",
            choice2 = "B. 18.67%",
            choice3 = "C. 16%",
            choice4 = "D. 15.67%",
            rightAnswer = "C. 16%",
            explanation = "The factors of number 84 are 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42 and 84. Therefore, 4 is a factor of 84",
        },
        new AnswerObject {
            qnumber = "5",
            choice1 = "A. True",
            choice2 = "B. False",
            choice3 = "C. Maybe",
            choice4 = "D. No answer",
            rightAnswer = "B. False",
            explanation = "A natural number is divisible by 8 if the last three digits are zeros or the number formed by the last three-digit is divisible by 8.Calculation: ⇒ 88 is the product of 8 and 11.",
        },
        new AnswerObject {
            qnumber = "6",
            choice1 = "A. Heptagon",
            choice2 = "B. Hexagon",
            choice3 = "C. Nonagon",
            choice4 = "D. Octagon",
            rightAnswer = "D. Octagon",
            explanation = "By using a PEMDAS rule: 100 – (14 + 37) ÷ 3 + 14 × 2  Parenthesis First 100 – 51 ÷ 3 + 14 × 2  Division since it comes first in the equations 100 – 17 + 14 × 2  Multiplication 100 – 17 + 28  Subtraction since it comes first in the equations 83 + 28  Addition = 111  Correct Answer",
        },
        new AnswerObject {
            qnumber = "7",
            choice1 = "A. Center",
            choice2 = "B. Chord",
            choice3 = "C. Diameter",
            choice4 = "D. Radius",
            rightAnswer = "A. Center",
            explanation = "(17+15) ÷ (124-116) 32 ÷ 8 = 4",
        },
        new AnswerObject {
            qnumber = "8",
            choice1 = "A. Rectangle",
            choice2 = "B. Triangle",
            choice3 = "C. Square",
            choice4 = "D. Circle",
            rightAnswer = "D. Circle",
            explanation = "Step 1: Arrange the given horizontally. 30,45 60 Step 2: Write the common prime divisor at the left-hand side and the quotients below the number. 15 30 45 60 2 3 4 Step 3: Repeat the process until two numbers have no more common factors. 1 2 3 4 2 3 4 Step 4: Multiply all the numbers in the last row, the numbers are 15 and 1. 15 x 1 = 15 Therefore, the GCF of 30, 45, and 60 is 15.",
        },
        new AnswerObject {
            qnumber = "9",
            choice1 = "A. Sphere",
            choice2 = "B. Cone",
            choice3 = "C. Cube",
            choice4 = "D. Cylinder",
            rightAnswer = "C. Cube",
            explanation = "Factors of 30: (1, 2, 3, 5, 6, 10, 15, 30)Factors of 36: (1, 2, 3, 4, 6, 9, 12, 18, 36) The GCF (30 and 36) is 6 Use the listing Multiples to find LCM Multiples of 30: (30, 60, 90, 120, 150 and 180) Multiples of 36: (36, 72, 108, 144, and 180) The LCM (30 and 36) is 180",
        },
        new AnswerObject {
            qnumber = "10",
            choice1 = "A. Sphere",
            choice2 = "B. Cube",
            choice3 = "B. Rectangle Prism",
            choice4 = "D. Cylinder",
            rightAnswer = "D. Cylinder",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "11",
            choice1 = "A. Add 2",
            choice2 = "B. Subtract 2",
            choice3 = "C. Multiply 2",
            choice4 = "D. Divide 2",
            rightAnswer = "A. Add 2",
            explanation = "A proper fraction is a fraction that has no whole number part and its numerator is smaller than its denominator. Since 33 is the numerator and 35 is the denominator. Therefore, the given is a Proper Fraction.",
        },
        new AnswerObject {
            qnumber = "12",
            choice1 = "A. 3",
            choice2 = "B. 15",
            choice3 = "C. 5",
            choice4 = "D. 9",
            rightAnswer = "B. 15",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "13",
            choice1 = "A. 7:00 PM",
            choice2 = "B. 6:00 PM",
            choice3 = "C. 5:00 PM",
            choice4 = "D. 4:00 PM",
            rightAnswer = "D. 4:00 PM",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "14",
            choice1 = "A. 2 + r",
            choice2 = "B. r/2",
            choice3 = "C. 2r",
            choice4 = "D. 2/r",
            rightAnswer = "C. 2r",
            explanation = "",
        },

        new AnswerObject {
            qnumber = "15",
            choice1 = "A. 4:15 PM",
            choice2 = "B. 4:25 PM",
            choice3 = "C. 4:35 PM",
            choice4 = "D. 4:45 PM",
            rightAnswer = "C. 4:35 PM",
        },
        new AnswerObject {
            qnumber = "16",
            choice1 = "A. 22 cm",
            choice2 = "B. 88 cm",
            choice3 = "C. 44 cm",
            choice4 = "D. 11 cm",
            rightAnswer = "D. 11 cm",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "17",
            choice1 = "A. 6.28 inches",
            choice2 = "B. 62.8 inches",
            choice3 = "C. 68.2 inches",
            choice4 = "D. 628 inches",
            rightAnswer = "A. 6.28 inches",
            explanation = "B. Proportion",
        },
        new AnswerObject {
            qnumber = "18",
            choice1 = "A. Circle",
            choice2 = "B. Chord",
            choice3 = "C. Centeral Angle",
            choice4 = "D. Center",
            rightAnswer = "C. Central Angle",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "19",
            choice1 = "A. 84.9056 cm^2",
            choice2 = "B. 86.9056 cm^2",
            choice3 = "C. 88.9056 cm^2",
            choice4 = "D. 89.9056 cm^2",
            rightAnswer = "A. 84.9056 cm^2",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "20",
            choice1 = "A. 2/10",
            choice2 = "B. 2/5",
            choice3 = "C. 4/5",
            choice4 = "D. 4/10",
            rightAnswer = "A 2/10",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "21",
            choice1 = "A. 27",
            choice2 = "B. 18",
            choice3 = "C. 17",
            choice4 = "D. 34",
            rightAnswer = "C. 17",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "22",
            choice1 = "A. Hexagon",
            choice2 = "B. Heptagon",
            choice3 = "C. Octagon",
            choice4 = "D. Pentagon",
            rightAnswer = "B. Heptagon",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "23",
            choice1 = "A. 8",
            choice2 = "B. 6",
            choice3 = "C. 4",
            choice4 = "D. 2",
            rightAnswer = "C. 4",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "24",
            choice1 = "A. Radius",
            choice2 = "B. Diameter",
            choice3 = "C. Chord",
            choice4 = "D. Circumference",
            rightAnswer = "B. Diameter",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "25",
            choice1 = "A. Minus 6",
            choice2 = "B. Add 5",
            choice3 = "C. Minus 4",
            choice4 = "D. Add 4",
            rightAnswer = "D. Add 4",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "26",
            choice1 = "A. 0.78",
            choice2 = "B. 7.80",
            choice3 = "C. 78.0",
            choice4 = "D. 78.00",
            rightAnswer = "A. 0.78",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "27",
            choice1 = "A. 6.789%",
            choice2 = "B. 6789%",
            choice3 = "C. 67.89%",
            choice4 = "D. 678.9%",
            rightAnswer = "C. 67.89%",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "28",
            choice1 = "A. 25%",
            choice2 = "B. 50%",
            choice3 = "C. 75%",
            choice4 = "D. 20%",
            rightAnswer = "B. 50%",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "29",
            choice1 = "A. Circle",
            choice2 = "B. Triangle",
            choice3 = "C. Square",
            choice4 = "D. Polygon",
            rightAnswer = "A. Circle",
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
        "20 is what percent of 100?",
        "Express 0.03 in percent form.",
        "In a subdivision, the price of lots per square meter increased from Php 3,200 To Php 4,000. What is the percent of increase?",
        "Old value: 300; New value: 250. What is the percentage of decrease?",
        "A heptagon has 6 sides.",
        "What is a polygon with eight vertices?",
        "The middle point of the circle is ____?",
        "It is a set of all points in a plane with same distance from the center to a certain point.",
        "It is a solid figure with 6 equal square faces.",
        "A solid figure with two circular bases and a curved surface.",
        "37, 39, 41, 43, 45. What number and operation will be used?",
        "What is the value of m in the expression: 2m + 6 = 3m - 9?",
        "What time is it in Turkey if it is 9:00 pm in the Philippines?",
        "In terms of radius, a diameter is equals to _____?",
        "What is 16:35 when converted to 12hrs in time?",
        "A circle has diameter 22 cm. What is the radius?",
        "A cylindrical can have a diameter of 2 inches, what will be the circumference of the can?",
        "It is an angle formed by two radii.",
        "The diameter of circle is 10.4 centimeters. What is the area?",
        "20% is equivalent to what fraction?",
        "What is 50% of 34?",
        "A polygon with seven sides is a _____?",
        "If the radius of a circle is 2, what is the diameter?",
        "It is the longest segment between two points of a circle.",
        "What is the rule of the sequence: 3,7,11, and 15?",
        "What is the decimal form of 78%?",
        "What is the percent form of 0.6789?",
        "What is the percent form of 1/2?",
        "It is a plane figure but it is not considered as polygon.",
        "A pentagon has 5 angles.",
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
                SceneManager.LoadScene("3_q1");
                break;
            case "2":
                SceneManager.LoadScene("3_q2");
                break;
            case "3":
                SceneManager.LoadScene("3_q3");
                break;
            case "4":
                SceneManager.LoadScene("3_q4");
                break;
            case "5":
                SceneManager.LoadScene("3_q5");
                break;
            case "6":
                SceneManager.LoadScene("3_q6");
                break;
            case "7":
                SceneManager.LoadScene("3_q7");
                break;
            case "8":
                SceneManager.LoadScene("3_q8");
                break;
            case "9":
                SceneManager.LoadScene("3_q9");
                break;
            case "10":
                SceneManager.LoadScene("3_q10");
                break;
            case "11":
                SceneManager.LoadScene("3_q11");
                break;
            case "12":
                SceneManager.LoadScene("3_q12");
                break;
            case "13":
                SceneManager.LoadScene("3_q13");
                break;
            case "14":
                SceneManager.LoadScene("3_q14");
                break;
            case "15":
                SceneManager.LoadScene("3_q15");
                break;
            case "16":
                SceneManager.LoadScene("3_q16");
                break;
            case "17":
                SceneManager.LoadScene("3_q17");
                break;
            case "18":
                SceneManager.LoadScene("3_q18");
                break;
            case "19":
                SceneManager.LoadScene("3_q19");
                break;
            case "20":
                SceneManager.LoadScene("3_q20");
                break;
            case "21":
                SceneManager.LoadScene("3_q21");
                break;
            case "22":
                SceneManager.LoadScene("3_q22");
                break;
            case "23":
                SceneManager.LoadScene("3_q23");
                break;
            case "24":
                SceneManager.LoadScene("3_q24");
                break;
            case "25":
                SceneManager.LoadScene("3_q25");
                break;
            case "26":
                SceneManager.LoadScene("3_q26");
                break;
            case "27":
                SceneManager.LoadScene("3_q27");
                break;
            case "28":
                SceneManager.LoadScene("3_q28");
                break;
            case "29":
                SceneManager.LoadScene("3_q29");
                break;
            case "30":
                SceneManager.LoadScene("3_q30");
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
                SceneManager.LoadScene("3_q1");
                break;
            case "2":
                SceneManager.LoadScene("3_q2");
                break;
            case "3":
                SceneManager.LoadScene("3_q3");
                break;
            case "4":
                SceneManager.LoadScene("3_q4");
                break;
            case "5":
                SceneManager.LoadScene("3_q5");
                break;
            case "6":
                SceneManager.LoadScene("3_q6");
                break;
            case "7":
                SceneManager.LoadScene("3_q7");
                break;
            case "8":
                SceneManager.LoadScene("3_q8");
                break;
            case "9":
                SceneManager.LoadScene("3_q9");
                break;
            case "10":
                SceneManager.LoadScene("3_q10");
                break;
            case "11":
                SceneManager.LoadScene("3_q11");
                break;
            case "12":
                SceneManager.LoadScene("3_q12");
                break;
            case "13":
                SceneManager.LoadScene("3_q13");
                break;
            case "14":
                SceneManager.LoadScene("3_q14");
                break;
            case "15":
                SceneManager.LoadScene("3_q15");
                break;
            case "16":
                SceneManager.LoadScene("3_q16");
                break;
            case "17":
                SceneManager.LoadScene("3_q17");
                break;
            case "18":
                SceneManager.LoadScene("3_q18");
                break;
            case "19":
                SceneManager.LoadScene("3_q19");
                break;
            case "20":
                SceneManager.LoadScene("3_q20");
                break;
            case "21":
                SceneManager.LoadScene("3_q21");
                break;
            case "22":
                SceneManager.LoadScene("3_q22");
                break;
            case "23":
                SceneManager.LoadScene("3_q23");
                break;
            case "24":
                SceneManager.LoadScene("3_q24");
                break;
            case "25":
                SceneManager.LoadScene("3_q25");
                break;
            case "26":
                SceneManager.LoadScene("3_q26");
                break;
            case "27":
                SceneManager.LoadScene("3_q27");
                break;
            case "28":
                SceneManager.LoadScene("3_q28");
                break;
            case "29":
                SceneManager.LoadScene("3_q29");
                break;
            case "30":
                SceneManager.LoadScene("3_q30");
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
