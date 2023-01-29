using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    // once team strength is implemented make that a factor
    // .-> is in the thousands
    string playersLeague;

    float currentTeamMoney;

    // Start is called before the first frame update
    void Start()
    {
        playersLeague = PlayerPrefs.GetString("selectedLeague");
        OrigMoneyCalc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OrigMoneyCalc()
    {
        if (playersLeague == "USNL")
        {
            // Standard money range 4.3 mil to 89 mil
            currentTeamMoney = Random.Range(4.3f, 89.3f);
            PlayerPrefs.SetFloat("CurrentTeamMoney", currentTeamMoney);
        }
        if (playersLeague == "USSL")
        {
            // Standard money range 600k to 5.6 mil
            currentTeamMoney = Random.Range(.6f, 5.6f);
            PlayerPrefs.SetFloat("CurrentTeamMoney", currentTeamMoney);
        }
    }
}
