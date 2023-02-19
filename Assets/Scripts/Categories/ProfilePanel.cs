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
