using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class CreateUser : MonoBehaviour
{
    public Button StartButton;
    // Start is called before the first frame update
    public TextFieldScript textFieldScript;
    public string filePath;
    void Start()
    {
        Button strtbtn = StartButton.GetComponent<Button>();
        strtbtn.onClick.AddListener(TaskOnClick);
        filePath = Application.persistentDataPath + "/inventory/Inventory.txt";

        if (!Directory.Exists(Path.GetDirectoryName(filePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }
    }
    public void TaskOnClick()
    {
        DateTime now = DateTime.Now;
        string defaultDate = now.ToString("yyyy/mm/dd");
        // //CreateDB();
        // AddUser(textFieldScript.CopyText(), defaultDate, "Please Change it.");
        FileStream f = new FileStream(filePath, FileMode.OpenOrCreate);
        StreamWriter s = new StreamWriter(f);
        s.WriteLine(textFieldScript.CopyText());
        s.WriteLine(defaultDate);
        s.WriteLine("Please Change it.");
        s.WriteLine("0");
        s.WriteLine("G1");
        s.Close();
        f.Close();
        SceneManager.LoadScene("Categories");
    }

    void Update()
    {

    }
}
