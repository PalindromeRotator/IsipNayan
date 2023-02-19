using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text highScoreText;
    public string filePath;
    void Start()
    {
        filePath = Application.persistentDataPath + "/inventory/Inventory.txt";

        if (!Directory.Exists(Path.GetDirectoryName(filePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }
        DisplayUsers();

    }

    public void DisplayUsers()
    {
        using (var stream = new FileStream(filePath, FileMode.Open))
        {
            using (var reader = new StreamReader(stream))
            {
                string line = null;
                for (int i = 1; i <= 4; i++)
                {
                    line = reader.ReadLine();
                    if (i == 4 && line != null)
                    {
                        highScoreText.text = line;
                    }
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
