using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadMainMenu : MonoBehaviour
{
    // Grab the saved data and load it
    [SerializeField] TMP_Text managerName;
    [SerializeField] TMP_Text leagueName;
    [SerializeField] TMP_Text teamName;
    [SerializeField] TMP_Text moneyAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisplayText();
    }

    void DisplayText()
    {
        leagueName.text = PlayerPrefs.GetString("selectedLeague");
        managerName.text = PlayerPrefs.GetString("managerName");
        teamName.text = PlayerPrefs.GetString("selectedTeam");
        moneyAmount.text = PlayerPrefs.GetFloat("CurrentTeamMoney") + "$";
    }
}
