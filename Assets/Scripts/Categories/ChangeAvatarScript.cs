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
    public Button B1Btn;
    public Button B2Btn;
    public Button B3Btn;
    public Button B4Btn;
    public Button G1Avatar;
    public Button G2Avatar;
    public Button G3Avatar;
    public Button G4Avatar;
    public Button B1Avatar;
    public Button B2Avatar;
    public Button B3Avatar;
    public Button B4Avatar;

    public Button G1AvatarSmall;
    public Button G2AvatarSmall;
    public Button G3AvatarSmall;
    public Button G4AvatarSmall;
    public Button B1AvatarSmall;
    public Button B2AvatarSmall;
    public Button B3AvatarSmall;
    public Button B4AvatarSmall;
    public Button profileButton;

    public Button G1Profile;
    public Button G2Profile;
    public Button G3Profile;
    public Button G4Profile;
    public Button B1Profile;
    public Button B2Profile;
    public Button B3Profile;
    public Button B4Profile;
    public string filePath;
    void Start()
    {
        G1Btn.onClick.AddListener(G1);
        G2Btn.onClick.AddListener(G2);
        G3Btn.onClick.AddListener(G3);
        G4Btn.onClick.AddListener(G4);
        B1Btn.onClick.AddListener(B1);
        B2Btn.onClick.AddListener(B2);
        B3Btn.onClick.AddListener(B3);
        B4Btn.onClick.AddListener(B4);
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
                            B1Avatar.gameObject.SetActive(false);
                            B2Avatar.gameObject.SetActive(false);
                            B3Avatar.gameObject.SetActive(false);
                            B4Avatar.gameObject.SetActive(false);


                        }
                        if (line == "G2")
                        {
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(true);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(false);
                            B1Avatar.gameObject.SetActive(false);
                            B2Avatar.gameObject.SetActive(false);
                            B3Avatar.gameObject.SetActive(false);
                            B4Avatar.gameObject.SetActive(false);


                        }
                        if (line == "G3")
                        {
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(true);
                            G4Avatar.gameObject.SetActive(false);
                            B1Avatar.gameObject.SetActive(false);
                            B2Avatar.gameObject.SetActive(false);
                            B3Avatar.gameObject.SetActive(false);
                            B4Avatar.gameObject.SetActive(false);

                        }
                        if (line == "G4")
                        {
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(true);
                            B1Avatar.gameObject.SetActive(false);
                            B2Avatar.gameObject.SetActive(false);
                            B3Avatar.gameObject.SetActive(false);
                            B4Avatar.gameObject.SetActive(false);


                        }
                        if (line == "B1")
                        {
                            B1Avatar.gameObject.SetActive(true);
                            B2Avatar.gameObject.SetActive(false);
                            B3Avatar.gameObject.SetActive(false);
                            B4Avatar.gameObject.SetActive(false);
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(false);


                        }
                        if (line == "B2")
                        {
                            B1Avatar.gameObject.SetActive(false);
                            B2Avatar.gameObject.SetActive(true);
                            B3Avatar.gameObject.SetActive(false);
                            B4Avatar.gameObject.SetActive(false);
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(false);

                            G1AvatarSmall.gameObject.SetActive(false);
                            G2AvatarSmall.gameObject.SetActive(false);
                            G3AvatarSmall.gameObject.SetActive(false);
                            G4AvatarSmall.gameObject.SetActive(false);
                            B1AvatarSmall.gameObject.SetActive(false);
                            B2AvatarSmall.gameObject.SetActive(true);
                            B3AvatarSmall.gameObject.SetActive(false);
                            B4AvatarSmall.gameObject.SetActive(false);
                        }
                        if (line == "B3")
                        {
                            B1Avatar.gameObject.SetActive(false);
                            B2Avatar.gameObject.SetActive(false);
                            B3Avatar.gameObject.SetActive(true);
                            B4Avatar.gameObject.SetActive(false);
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(false);

                            G1AvatarSmall.gameObject.SetActive(false);
                            G2AvatarSmall.gameObject.SetActive(false);
                            G3AvatarSmall.gameObject.SetActive(false);
                            G4AvatarSmall.gameObject.SetActive(false);
                            B1AvatarSmall.gameObject.SetActive(false);
                            B2AvatarSmall.gameObject.SetActive(false);
                            B3AvatarSmall.gameObject.SetActive(true);
                            B4AvatarSmall.gameObject.SetActive(false);
                        }
                        if (line == "B4")
                        {
                            B1Avatar.gameObject.SetActive(false);
                            B2Avatar.gameObject.SetActive(false);
                            B3Avatar.gameObject.SetActive(false);
                            B4Avatar.gameObject.SetActive(true);
                            G1Avatar.gameObject.SetActive(false);
                            G2Avatar.gameObject.SetActive(false);
                            G3Avatar.gameObject.SetActive(false);
                            G4Avatar.gameObject.SetActive(false);

                            G1AvatarSmall.gameObject.SetActive(false);
                            G2AvatarSmall.gameObject.SetActive(false);
                            G3AvatarSmall.gameObject.SetActive(false);
                            G4AvatarSmall.gameObject.SetActive(false);
                            B1AvatarSmall.gameObject.SetActive(false);
                            B2AvatarSmall.gameObject.SetActive(false);
                            B3AvatarSmall.gameObject.SetActive(false);
                            B4AvatarSmall.gameObject.SetActive(true);
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
        B1Avatar.gameObject.SetActive(false);
        B2Avatar.gameObject.SetActive(false);
        B3Avatar.gameObject.SetActive(false);
        B4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(true);
        G2AvatarSmall.gameObject.SetActive(false);
        G3AvatarSmall.gameObject.SetActive(false);
        G4AvatarSmall.gameObject.SetActive(false);
        B1AvatarSmall.gameObject.SetActive(false);
        B2AvatarSmall.gameObject.SetActive(false);
        B3AvatarSmall.gameObject.SetActive(false);
        B4AvatarSmall.gameObject.SetActive(false);

        G1Profile.gameObject.SetActive(true);
        G2Profile.gameObject.SetActive(false);
        G3Profile.gameObject.SetActive(false);
        G4Profile.gameObject.SetActive(false);
        B1Profile.gameObject.SetActive(false);
        B2Profile.gameObject.SetActive(false);
        B3Profile.gameObject.SetActive(false);
        B4Profile.gameObject.SetActive(false);
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
        B1Avatar.gameObject.SetActive(false);
        B2Avatar.gameObject.SetActive(false);
        B3Avatar.gameObject.SetActive(false);
        B4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(false);
        G2AvatarSmall.gameObject.SetActive(true);
        G3AvatarSmall.gameObject.SetActive(false);
        G4AvatarSmall.gameObject.SetActive(false);
        B1AvatarSmall.gameObject.SetActive(false);
        B2AvatarSmall.gameObject.SetActive(false);
        B3AvatarSmall.gameObject.SetActive(false);
        B4AvatarSmall.gameObject.SetActive(false);

        G1Profile.gameObject.SetActive(false);
        G2Profile.gameObject.SetActive(true);
        G3Profile.gameObject.SetActive(false);
        G4Profile.gameObject.SetActive(false);
        B1Profile.gameObject.SetActive(false);
        B2Profile.gameObject.SetActive(false);
        B3Profile.gameObject.SetActive(false);
        B4Profile.gameObject.SetActive(false);
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
        B1Avatar.gameObject.SetActive(false);
        B2Avatar.gameObject.SetActive(false);
        B3Avatar.gameObject.SetActive(false);
        B4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(false);
        G2AvatarSmall.gameObject.SetActive(false);
        G3AvatarSmall.gameObject.SetActive(true);
        G4AvatarSmall.gameObject.SetActive(false);
        B1AvatarSmall.gameObject.SetActive(false);
        B2AvatarSmall.gameObject.SetActive(false);
        B3AvatarSmall.gameObject.SetActive(false);
        B4AvatarSmall.gameObject.SetActive(false);

        G1Profile.gameObject.SetActive(false);
        G2Profile.gameObject.SetActive(false);
        G3Profile.gameObject.SetActive(true);
        G4Profile.gameObject.SetActive(false);
        B1Profile.gameObject.SetActive(false);
        B2Profile.gameObject.SetActive(false);
        B3Profile.gameObject.SetActive(false);
        B4Profile.gameObject.SetActive(false);

    }
    public void G4()
    {
        Debug.Log("Hello");
        string newAvatar = "G4";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(true);
        B1Avatar.gameObject.SetActive(false);
        B2Avatar.gameObject.SetActive(false);
        B3Avatar.gameObject.SetActive(false);
        B4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(false);
        G2AvatarSmall.gameObject.SetActive(false);
        G3AvatarSmall.gameObject.SetActive(false);
        G4AvatarSmall.gameObject.SetActive(true);
        B1AvatarSmall.gameObject.SetActive(false);
        B2AvatarSmall.gameObject.SetActive(false);
        B3AvatarSmall.gameObject.SetActive(false);
        B4AvatarSmall.gameObject.SetActive(false);

        G1Profile.gameObject.SetActive(false);
        G2Profile.gameObject.SetActive(false);
        G3Profile.gameObject.SetActive(false);
        G4Profile.gameObject.SetActive(true);
        B1Profile.gameObject.SetActive(false);
        B2Profile.gameObject.SetActive(false);
        B3Profile.gameObject.SetActive(false);
        B4Profile.gameObject.SetActive(false);
    }
    public void B1()
    {
        string newAvatar = "B1";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        B1Avatar.gameObject.SetActive(true);
        B2Avatar.gameObject.SetActive(false);
        B3Avatar.gameObject.SetActive(false);
        B4Avatar.gameObject.SetActive(false);
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(false);
        G2AvatarSmall.gameObject.SetActive(false);
        G3AvatarSmall.gameObject.SetActive(false);
        G4AvatarSmall.gameObject.SetActive(false);
        B1AvatarSmall.gameObject.SetActive(true);
        B2AvatarSmall.gameObject.SetActive(false);
        B3AvatarSmall.gameObject.SetActive(false);
        B4AvatarSmall.gameObject.SetActive(false);

        G1Profile.gameObject.SetActive(false);
        G2Profile.gameObject.SetActive(false);
        G3Profile.gameObject.SetActive(false);
        G4Profile.gameObject.SetActive(false);
        B1Profile.gameObject.SetActive(true);
        B2Profile.gameObject.SetActive(false);
        B3Profile.gameObject.SetActive(false);
        B4Profile.gameObject.SetActive(false);

    }
    public void B2()
    {
        string newAvatar = "B2";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        B1Avatar.gameObject.SetActive(false);
        B2Avatar.gameObject.SetActive(true);
        B3Avatar.gameObject.SetActive(false);
        B4Avatar.gameObject.SetActive(false);
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(false);
        G2AvatarSmall.gameObject.SetActive(false);
        G3AvatarSmall.gameObject.SetActive(false);
        G4AvatarSmall.gameObject.SetActive(false);
        B1AvatarSmall.gameObject.SetActive(false);
        B2AvatarSmall.gameObject.SetActive(true);
        B3AvatarSmall.gameObject.SetActive(false);
        B4AvatarSmall.gameObject.SetActive(false);

        G1Profile.gameObject.SetActive(false);
        G2Profile.gameObject.SetActive(false);
        G3Profile.gameObject.SetActive(false);
        G4Profile.gameObject.SetActive(false);
        B1Profile.gameObject.SetActive(false);
        B2Profile.gameObject.SetActive(true);
        B3Profile.gameObject.SetActive(false);
        B4Profile.gameObject.SetActive(false);

    }
    public void B3()
    {
        string newAvatar = "B3";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        B1Avatar.gameObject.SetActive(false);
        B2Avatar.gameObject.SetActive(false);
        B3Avatar.gameObject.SetActive(true);
        B4Avatar.gameObject.SetActive(false);
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(false);
        G2AvatarSmall.gameObject.SetActive(false);
        G3AvatarSmall.gameObject.SetActive(false);
        G4AvatarSmall.gameObject.SetActive(false);
        B1AvatarSmall.gameObject.SetActive(false);
        B2AvatarSmall.gameObject.SetActive(false);
        B3AvatarSmall.gameObject.SetActive(true);
        B4AvatarSmall.gameObject.SetActive(false);

        G1Profile.gameObject.SetActive(false);
        G2Profile.gameObject.SetActive(false);
        G3Profile.gameObject.SetActive(false);
        G4Profile.gameObject.SetActive(false);
        B1Profile.gameObject.SetActive(false);
        B2Profile.gameObject.SetActive(false);
        B3Profile.gameObject.SetActive(true);
        B4Profile.gameObject.SetActive(false);

    }
    public void B4()
    {
        string newAvatar = "B4";
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        lines[4] = newAvatar; // Update the 4th line (index 3)
        File.WriteAllLines(filePath, lines); // Write the modified content back to the file
        B1Avatar.gameObject.SetActive(false);
        B2Avatar.gameObject.SetActive(false);
        B3Avatar.gameObject.SetActive(false);
        B4Avatar.gameObject.SetActive(true);
        G1Avatar.gameObject.SetActive(false);
        G2Avatar.gameObject.SetActive(false);
        G3Avatar.gameObject.SetActive(false);
        G4Avatar.gameObject.SetActive(false);

        G1AvatarSmall.gameObject.SetActive(false);
        G2AvatarSmall.gameObject.SetActive(false);
        G3AvatarSmall.gameObject.SetActive(false);
        G4AvatarSmall.gameObject.SetActive(false);
        B1AvatarSmall.gameObject.SetActive(false);
        B2AvatarSmall.gameObject.SetActive(false);
        B3AvatarSmall.gameObject.SetActive(false);
        B4AvatarSmall.gameObject.SetActive(true);

        G1Profile.gameObject.SetActive(false);
        G2Profile.gameObject.SetActive(false);
        G3Profile.gameObject.SetActive(false);
        G4Profile.gameObject.SetActive(false);
        B1Profile.gameObject.SetActive(false);
        B2Profile.gameObject.SetActive(false);
        B3Profile.gameObject.SetActive(false);
        B4Profile.gameObject.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
