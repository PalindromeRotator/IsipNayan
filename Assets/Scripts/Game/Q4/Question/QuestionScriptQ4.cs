using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestionScriptQ4 : MonoBehaviour
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
            choice1 = "A. 708.86 cm^2",
            choice2 = "B. 706.50 cm^2",
            choice3 = "C. 706.68 cm^2",
            choice4 = "D. 708.55 cm^2",
            rightAnswer = "B. 706.50 cm^2",
            explanation = "1+8+1+5+0 = 30, 30 is divisible by 3, therefore, 18,150 is divisible by 3",
        },
        new AnswerObject {
            qnumber = "2",
            choice1 = "A. 7,084.655 cm^2",
            choice2 = "B. 7,088.28 cm^2",
            choice3 = "C. 7,082.88 cm^2",
            choice4 = "D. 7,084.625 cm^2",
            rightAnswer = "D. 7,084.625 cm^2",
            explanation = "71 is a prime number. The number 71 is divisible only by 1 and the number itself.For a number to be classified as prime number, it should have exactly two factors. Since 71 has exactly two factors, i.e. 1 and 71, it is a prime number.",
        },
        new AnswerObject {
            qnumber = "3",
            choice1 = "A. 4000",
            choice2 = "B. 400",
            choice3 = "C. 40",
            choice4 = "D. 0.4",
            rightAnswer = "B. 400",
            explanation = "The factors of number 84 are 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42 and 84. Therefore, 4 is a factor of 84",
        },
         new AnswerObject {
            qnumber = "4",
            choice1 = "A. Gallium",
            choice2 = "B. Bromine",
            choice3 = "C. Mercury",
            choice4 = "D. Water",
            rightAnswer = "C. Mercury",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "5",
            choice1 = "A. Weighing scale",
            choice2 = "B. Pulse oximeter",
            choice3 = "C. Sphygmomanometer",
            choice4 = "D. Thermometer",
            rightAnswer = "D. Thermometer",
            explanation = "A natural number is divisible by 8 if the last three digits are zeros or the number formed by the last three-digit is divisible by 8.Calculation: ⇒ 88 is the product of 8 and 11.",
        },
        new AnswerObject {
            qnumber = "6",
            choice1 = "A. 0.015386 m^2",
            choice2 = "B. 0.015934 m^2",
            choice3 = "C. 0.015349 m^2",
            choice4 = "D. 0.015943 m^2",
            rightAnswer = "A. 0.0156386 m^2",
            explanation = "By using a PEMDAS rule: 100 – (14 + 37) ÷ 3 + 14 × 2  Parenthesis First 100 – 51 ÷ 3 + 14 × 2  Division since it comes first in the equations 100 – 17 + 14 × 2  Multiplication 100 – 17 + 28  Subtraction since it comes first in the equations 83 + 28  Addition = 111  Correct Answer",
        },
        new AnswerObject {
            qnumber = "7",
            choice1 = "A. 25 L",
            choice2 = "B. 0.025 L",
            choice3 = "C. 0.25 L",
            choice4 = "D. 2.5 L",
            rightAnswer = "C. 0.25 L",
            explanation = "(17+15) ÷ (124-116) 32 ÷ 8 = 4",
        },
        new AnswerObject {
            qnumber = "8",
            choice1 = "A. 11 520 cm^3",
            choice2 = "B. 11 320 cm^3",
            choice3 = "C. 11 220 cm^3",
            choice4 = "D. 11 120 cm^3",
            rightAnswer = "A. 11 520 cm^3",
            explanation = "Step 1: Arrange the given horizontally. 30,45 60 Step 2: Write the common prime divisor at the left-hand side and the quotients below the number. 15 30 45 60 2 3 4 Step 3: Repeat the process until two numbers have no more common factors. 1 2 3 4 2 3 4 Step 4: Multiply all the numbers in the last row, the numbers are 15 and 1. 15 x 1 = 15 Therefore, the GCF of 30, 45, and 60 is 15.",
        },
        new AnswerObject {
            qnumber = "9",
            choice1 = "A. 1200 cm^3",
            choice2 = "B. 1400 cm^3",
            choice3 = "C. 1800 cm^3",
            choice4 = "D. 2100 cm^3",
            rightAnswer = "A. 1200 cm^3",
            explanation = "Factors of 30: (1, 2, 3, 5, 6, 10, 15, 30)Factors of 36: (1, 2, 3, 4, 6, 9, 12, 18, 36) The GCF (30 and 36) is 6 Use the listing Multiples to find LCM Multiples of 30: (30, 60, 90, 120, 150 and 180) Multiples of 36: (36, 72, 108, 144, and 180) The LCM (30 and 36) is 180",
        },
        new AnswerObject {
            qnumber = "10",
            choice1 = "A. 6804 dam^3",
            choice2 = "B. 6048 dam^3",
            choice3 = "B. 6048 dam^3",
            choice4 = "D. 6408 dam^3",
            rightAnswer = "B. 6048 dam^3",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "11",
            choice1 = "A. 900 cm^3",
            choice2 = "B. 960 cm^3",
            choice3 = "C. 690 ^3",
            choice4 = "D. 906 cm^3",
            rightAnswer = "B. 960 cm^3",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "12",
            choice1 = "A. 3225 dm^3",
            choice2 = "B. 322.5 cm^3",
            choice3 = "C. 32.35 cm^3",
            choice4 = "D. 32.25 dm^3",
            rightAnswer = "D. 32.25 dm^3",
            explanation = "A proper fraction is a fraction that has no whole number part and its numerator is smaller than its denominator. Since 33 is the numerator and 35 is the denominator. Therefore, the given is a Proper Fraction.",
        },
        new AnswerObject {
            qnumber = "13",
            choice1 = "A. 8 cm",
            choice2 = "B. 20 cm",
            choice3 = "C. 40 cm",
            choice4 = "D. 2 cm",
            rightAnswer = "D. 2 cm",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "14",
            choice1 = "A. Fahrenheit",
            choice2 = "B. Kelvin",
            choice3 = "C. None",
            choice4 = "D. Celsius",
            rightAnswer = "D. Celsius",
            explanation = "",
        },

        new AnswerObject {
            qnumber = "15",
            choice1 = "A. Picto",
            choice2 = "B. Pie`",
            choice3 = "C. Bar",
            choice4 = "D. Line",
            rightAnswer = "D. Line",
        },
        new AnswerObject {
            qnumber = "16",
            choice1 = "A. Double",
            choice2 = "B. None of the above",
            choice3 = "C. Single",
            choice4 = "D. A and C",
            rightAnswer = "A. Double",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "17",
            choice1 = "A. Label the x-axis",
            choice2 = "B. Label the y-axis",
            choice3 = "C. Connect the points",
            choice4 = "D. Plot the points",
            rightAnswer = "A. Label the x-axis.",
            explanation = "B. Proportion",
        },
        new AnswerObject {
            qnumber = "18",
            choice1 = "A. Drawing inferences",
            choice2 = "B. Assumptions",
            choice3 = "C. Deductions",
            choice4 = "D. Judgements",
            rightAnswer = "A. Drawing inferences",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "19",
            choice1 = "A. Solve",
            choice2 = "B. Check",
            choice3 = "C. Evaluate",
            choice4 = "D. Understand",
            rightAnswer = "C. Evaluate",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "20",
            choice1 = "A. Experimental",
            choice2 = "B. Word",
            choice3 = "C. Non-Routiune",
            choice4 = "D. Routine",
            rightAnswer = "C. Non-Routine",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "21",
            choice1 = "A. 7/12",
            choice2 = "B. 5/12",
            choice3 = "C. 5/7",
            choice4 = "D. 7/5",
            rightAnswer = "B. 5/12",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "22",
            choice1 = "A. Incidental",
            choice2 = "B. Experimental",
            choice3 = "C. Axiomatic",
            choice4 = "D. Theoretical",
            rightAnswer = "B. Experimental",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "23",
            choice1 = "A. 1/3",
            choice2 = "B. 27/60",
            choice3 = "C. 9/20",
            choice4 = "D. 2/20",
            rightAnswer = "C. 9/20",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "24",
            choice1 = "A. 1/4",
            choice2 = "B. 1/5",
            choice3 = "C. 1/3",
            choice4 = "D. 1/2",
            rightAnswer = "B. 1/5",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "25",
            choice1 = "A. 8/21",
            choice2 = "B. 10/21",
            choice3 = "C. 11/21",
            choice4 = "D. 13/21",
            rightAnswer = "B. 10/21",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "26",
            choice1 = "A. 2,000",
            choice2 = "B. 200",
            choice3 = "C. 20,000",
            choice4 = "D. 20",
            rightAnswer = "A. 2,000",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "27",
            choice1 = "A. 40",
            choice2 = "B. 400",
            choice3 = "C. 4000",
            choice4 = "D. 5000",
            rightAnswer = "C. 4000",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "28",
            choice1 = "A. 72 cu cm",
            choice2 = "B. 48 cu cm",
            choice3 = "C. 36 cu cm",
            choice4 = "D. 28 cu cm",
            rightAnswer = "A. 72 cu cm",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "29",
            choice1 = "A. 172.5 cu cm",
            choice2 = "B. 127.5 cu cm",
            choice3 = "C. 117.5 cu cm",
            choice4 = "D. 107.5 cu cm",
            rightAnswer = "B. 127.5 cu cm",
            explanation = "",
        },
        new AnswerObject {
            qnumber = "30",
            choice1 = "A. 30 cu cm",
            choice2 = "B. 300 cu cm",
            choice3 = "C. 3000 cu cm",
            choice4 = "D. 30000 cu cm",
            rightAnswer = "C. 3000 cu cm",
            explanation = "",
        },
    };
    string[] questions = new string[] {
        "Find the area covered by the base of an electric fan if its circular base has a radius of 15cm.",
        "A round table has a 95-centimeter diameter. If it is to be covered by a glass top, what should be the area of the glass top?",
        "4L is equal to how many cL?",
        "It is a liquid that rises and falls when there is a change in temperature.",
        "A device that measures body temperature.",
        "Using π = 3.14, calculate the area if the given diameter 0.14 m.",
        "How much is 250ml in liters?",
        "Solve for the volume of a shoebox whose length, width, and height is 36 cm, 20 cm, and 16 cm respectively.",
        "If a printer cartridge has a 15cm length, 8cm width, and 10cm height, what is the volume?",
        "What is 24 dam × 18 dam × 14 dam?",
        "A rectangular block of wood is 16 cm long, 12 cm wide, and 5 cm thick. What is the volume?",
        "Beth's sewing box is 3dm long, 2.5dm wide and 4.3dm high. What is the volume?",
        "A gadget has a volume of 80 cm³. Its length and width is 4cm and 10cm respectively. What is the height?",
        "What unit of temperature is commonly used in the Philippines?",
        "A graph that utilizes lines to connect individual data points displaying values over a specified interval.",
        "A line graph that displays the comparison of two data.",
        "The second step in creating a line graph is ____.",
        "These are evidence-based guesses by observing facts then conclusion.",
        "The following are the steps in solving routine and non-routine problems using data presented in a line graph except: ",
        "A problem that can be solved in several ways and has several solutions.",
        "In selecting a letter from the word 'EXPERIMENTAL', what is the probability of choosing a vowel?",
        "The probability that is found from the outcomes of multiple repeated experiments.",
        "A coin is tossed 60 times. Heads appeared 27 times. What is the experimental probability of getting heads?",
        "What is the probability of choosing U from set of 5 cards lettered A, E, I, O, U?",
        "What is the possibility of getting an odd number on a roulette having numbers 0 to 20?",
        "What is the product of 2 x 1000?",
        "What is the product of 4 x 1000?",
        "Find the volume of the Match box ( Length - 6cm, Width - 2cm, Height - 6cm )",
        "Find the volume of Chocolate drink ( Length - 5cm, Width - 3cm, Height - 8.5cm )",
        "Find the volume of Cereal box ( Length - 15cm, Height - 8cm, Width - 25cm )",
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
                SceneManager.LoadScene("4_q1");
                break;
            case "2":
                SceneManager.LoadScene("4_q2");
                break;
            case "3":
                SceneManager.LoadScene("4_q3");
                break;
            case "4":
                SceneManager.LoadScene("4_q4");
                break;
            case "5":
                SceneManager.LoadScene("4_q5");
                break;
            case "6":
                SceneManager.LoadScene("4_q6");
                break;
            case "7":
                SceneManager.LoadScene("4_q7");
                break;
            case "8":
                SceneManager.LoadScene("4_q8");
                break;
            case "9":
                SceneManager.LoadScene("4_q9");
                break;
            case "10":
                SceneManager.LoadScene("4_q10");
                break;
            case "11":
                SceneManager.LoadScene("4_q11");
                break;
            case "12":
                SceneManager.LoadScene("4_q12");
                break;
            case "13":
                SceneManager.LoadScene("4_q13");
                break;
            case "14":
                SceneManager.LoadScene("4_q14");
                break;
            case "15":
                SceneManager.LoadScene("4_q15");
                break;
            case "16":
                SceneManager.LoadScene("4_q16");
                break;
            case "17":
                SceneManager.LoadScene("4_q17");
                break;
            case "18":
                SceneManager.LoadScene("4_q18");
                break;
            case "19":
                SceneManager.LoadScene("4_q19");
                break;
            case "20":
                SceneManager.LoadScene("4_q20");
                break;
            case "21":
                SceneManager.LoadScene("4_q21");
                break;
            case "22":
                SceneManager.LoadScene("4_q22");
                break;
            case "23":
                SceneManager.LoadScene("4_q23");
                break;
            case "24":
                SceneManager.LoadScene("4_q24");
                break;
            case "25":
                SceneManager.LoadScene("4_q25");
                break;
            case "26":
                SceneManager.LoadScene("4_q26");
                break;
            case "27":
                SceneManager.LoadScene("4_q27");
                break;
            case "28":
                SceneManager.LoadScene("4_q28");
                break;
            case "29":
                SceneManager.LoadScene("4_q29");
                break;
            case "30":
                SceneManager.LoadScene("4_q30");
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
                SceneManager.LoadScene("4_q1");
                break;
            case "2":
                SceneManager.LoadScene("4_q2");
                break;
            case "3":
                SceneManager.LoadScene("4_q3");
                break;
            case "4":
                SceneManager.LoadScene("4_q4");
                break;
            case "5":
                SceneManager.LoadScene("4_q5");
                break;
            case "6":
                SceneManager.LoadScene("4_q6");
                break;
            case "7":
                SceneManager.LoadScene("4_q7");
                break;
            case "8":
                SceneManager.LoadScene("4_q8");
                break;
            case "9":
                SceneManager.LoadScene("4_q9");
                break;
            case "10":
                SceneManager.LoadScene("4_q10");
                break;
            case "11":
                SceneManager.LoadScene("4_q11");
                break;
            case "12":
                SceneManager.LoadScene("4_q12");
                break;
            case "13":
                SceneManager.LoadScene("4_q13");
                break;
            case "14":
                SceneManager.LoadScene("4_q14");
                break;
            case "15":
                SceneManager.LoadScene("4_q15");
                break;
            case "16":
                SceneManager.LoadScene("4_q16");
                break;
            case "17":
                SceneManager.LoadScene("4_q17");
                break;
            case "18":
                SceneManager.LoadScene("4_q18");
                break;
            case "19":
                SceneManager.LoadScene("4_q19");
                break;
            case "20":
                SceneManager.LoadScene("4_q20");
                break;
            case "21":
                SceneManager.LoadScene("4_q21");
                break;
            case "22":
                SceneManager.LoadScene("4_q22");
                break;
            case "23":
                SceneManager.LoadScene("4_q23");
                break;
            case "24":
                SceneManager.LoadScene("4_q24");
                break;
            case "25":
                SceneManager.LoadScene("4_q25");
                break;
            case "26":
                SceneManager.LoadScene("4_q26");
                break;
            case "27":
                SceneManager.LoadScene("4_q27");
                break;
            case "28":
                SceneManager.LoadScene("4_q28");
                break;
            case "29":
                SceneManager.LoadScene("4_q29");
                break;
            case "30":
                SceneManager.LoadScene("4_q30");
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
