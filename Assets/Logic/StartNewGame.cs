using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartNewGame : MonoBehaviour
{
    [SerializeField] TMP_InputField managerNameInput;
    [SerializeField] TMP_Text managerNameDisplay;
    public string managerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetManagerData();
        managerNameDisplay.text = "Start " + PlayerPrefs.GetString("managerName") + "'s career";
    }

    void GetManagerData()
    {
        managerName = managerNameInput.text;
        //Save it for next session
        PlayerPrefs.SetString("managerName", managerName);
    }
}
