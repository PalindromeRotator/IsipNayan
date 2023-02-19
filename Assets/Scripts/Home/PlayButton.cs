using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Button playButton;
    public string filePath;
    void Start()
    {
        Button playbtn = playButton.GetComponent<Button>();
        playbtn.onClick.AddListener(clickPlay);
        filePath = Application.persistentDataPath + "/inventory/";

        if (!Directory.Exists(Path.GetDirectoryName(filePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }
    }
    void clickPlay()
    {
        try
        {
            if (File.Exists(filePath + "Inventory.txt"))
            {
                SceneManager.LoadScene("Categories");
            }
            else
            {
                FileStream f = new FileStream(filePath + "Inventory.txt", FileMode.OpenOrCreate);
                StreamWriter s = new StreamWriter(f);
                s.Close();
                f.Close();
                SceneManager.LoadScene("EnterUsername");
            }
        }
        catch (System.Exception e)
        {

            throw;
        }


    }
    // Update is called once per frame
    void Update()
    {

    }
}
