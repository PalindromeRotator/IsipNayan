using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ProfilePanel : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField nickname;
    public TMP_InputField birthdate;
    public TMP_InputField bio;
    public Button UpdateButton;
    public Button cancelButton;
    private string originalNickname;
    private string originalBirthdate;
    private string originalBio;
    public string filePath;

    public Button G1AvatarSmall;
    public Button G2AvatarSmall;
    public Button G3AvatarSmall;
    public Button G4AvatarSmall;
    public Button B1AvatarSmall;
    public Button B2AvatarSmall;
    public Button B3AvatarSmall;
    public Button B4AvatarSmall;

    public Button G1Profile;
    public Button G2Profile;
    public Button G3Profile;
    public Button G4Profile;
    public Button B1Profile;
    public Button B2Profile;
    public Button B3Profile;
    public Button B4Profile;

    void Start()
    {
        Button updatebtn = UpdateButton.GetComponent<Button>();
        updatebtn.onClick.AddListener(UpdateProfile);
        Button cancelbtn = cancelButton.GetComponent<Button>();
        cancelbtn.onClick.AddListener(CancelButton);
        filePath = Application.persistentDataPath + "/inventory/Inventory.txt";

        if (!Directory.Exists(Path.GetDirectoryName(filePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }
        DisplayUsers();
        DisplayUsers2();
    }

    public void DisplayUsers2()
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
                        if (line == "G2")
                        {

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
                        if (line == "G3")
                        {

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
                        if (line == "G4")
                        {
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
                        if (line == "B1")
                        {

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
                        if (line == "B2")
                        {

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
                        if (line == "B3")
                        {

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
                        if (line == "B4")
                        {

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
                    }
                }
            }
        }

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
                    line = reader.ReadLine(); // Read and store line 3
                    if (i == 1 && line != null)
                    {
                        nickname.text = line;
                        originalNickname = line;// Do something with the line
                    }
                    if (i == 2 && line != null)
                    {
                        birthdate.text = line;
                        originalBirthdate = line;
                    }
                    if (i == 3 && line != null)
                    {
                        bio.text = line;
                        originalBio = line;
                    }
                }
            }
        }

    }

    void UpdateProfile()
    {
        int lineNumber = 3; // The line number to update
        string newNickname = nickname.text;
        string newBirthdate = birthdate.text;
        string newBio = bio.text;
        string[] lines = File.ReadAllLines(filePath); // Read all lines into memory
        if (lineNumber > 0 && lineNumber <= lines.Length) // Check if the line number is valid
        {

            lines[0] = newNickname;
            lines[1] = newBirthdate;
            lines[2] = newBio;
            originalNickname = nickname.text;
            originalBirthdate = birthdate.text;
            originalBio = bio.text;
            File.WriteAllLines(filePath, lines);
            // Write the modified content back to the file
        }
    }

    void CancelButton()
    {
        nickname.text = originalNickname;
        birthdate.text = originalBirthdate;
        bio.text = originalBio;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
