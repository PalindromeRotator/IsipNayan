using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ChangeAvatarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button G1Btn;
    public Button G2Btn;
    public Button G3Btn;
    public Button G4Btn;
    public Button G1Avatar;
    public Button G2Avatar;
    public Button G3Avatar;
    public Button G4Avatar;
    public Button profileButton;
    public string filePath;
    void Start()
    {
        G1Btn.onClick.AddListener(G1);
        G2Btn.onClick.AddListener(G2);
        G3Btn.onClick.AddListener(G3);
        G4Btn.onClick.AddListener(G4);
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
                for (int i = 1; i <= 5; i++)
                {
                    line = reader.ReadLine();
                    if (i == 5 && line != null)
                    {
                        if (line == "G1")
                        {
                            G1Avatar.gameObject.SetActive(true);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(false);
                        }
                        if (line == "G2")
                        {
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(true);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(false);
                        }
                        if (line == "G3")
                        {
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(true);
                            G4Avatar.gameObject.SetActive(false);
                        }
                        if (line == "G4")
                        {
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(true);
                        }
                    }
                }
            }
        }

    }

    public void G1()
    {
        string newAvatar = "G1";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        G1Avatar.gameObject.SetActive(true);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(false);
    }
    public void G2()
    {
        string newAvatar = "G2";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(true);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(false);
    }
    public void G3()
    {
        string newAvatar = "G3";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(true);
        G4Avatar.gameObject.SetActive(false);

    }
    public void G4()
    {
        string newAvatar = "G4";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(true);

    }
    public void B1()
    {
        // Load the new sprite from the Resources folder

    }
    public void B2()
    {
        // Load the new sprite from the Resources folder

    }
    public void B3()
    {
        // Load the new sprite from the Resources folder

    }
    public void B4()
    {
        // Load the new sprite from the Resources folder

    }
    // Update is called once per frame
    void Update()
    {

    }
}
