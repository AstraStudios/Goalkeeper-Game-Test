using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartNewGame : MonoBehaviour
{
    [SerializeField] TMP_InputField managerNameInput;
    [SerializeField] TMP_InputField managerCountryInput;
    [SerializeField] TMP_Text testNameDisplay;
    public string managerName;
    public string managerCountry;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetManagerData();
        testNameDisplay.text = PlayerPrefs.GetString("managerName");
    }

    void GetManagerData()
    {
        managerName = managerNameInput.text;
        managerCountry = managerCountryInput.text;
        //Save it for next session
        PlayerPrefs.SetString("managerName", managerName);
    }
}
