using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    public Button NextButton;
    public string filePath;
    void Start()
    {
        scoreText.text = ScoreObject.score.ToString();
        NextButton.onClick.AddListener(goToQuarter);
        filePath = Application.persistentDataPath + "/inventory/Inventory.txt";

        if (!Directory.Exists(Path.GetDirectoryName(filePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }
    }
    void goToQuarter()
    {
        string newhighscore = ScoreObject.score.ToString();
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        if (lines.Length >= 4) // Check if there are at least 4 lines
        {
            lines[3] = newhighscore; // Update the 4th line (index 3)
            File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        }
        ScoreObject.counter = 0;
        ScoreObject.score = 0;
        SceneManager.LoadScene("GameQuarter");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
