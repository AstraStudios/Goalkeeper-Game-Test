using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeagueSelection : MonoBehaviour
{
    [SerializeField] public string[] USNL_Teams = { "Austin United", "Olympia Swords SC", "Sacramento Suns FC", "San Diego Waves SC", "Flagstaff Runners SC", "Tulsa Blazers SC", "Helena Mountains", "Las Vegas Gamblers SC", "Colorado Springs Skiers SC", "Santa Fe FC", "Orlando Tigers FC", "Detroit Robbers FC", "Concord Freedom Fighters FC", "Richmond SC", "Knoxville Mountaineers FC", "Buffalo Wanderers SC", "Birmingham Hunters FC", "Harrisburg Builders SC", "New York Blasters FC", "Houston Oilers FC" };
    [SerializeField] public string[] USSL_Teams = { "Madison Rowers", "ST Paul SC", "Las Cruces FC", "Kansas City FC", "Bismark SC", "Annapolis SC", "Miami FC", "Nashville SC", "Baton Rouge FC", "Jackson SC", "Fort Worth FC", "Memphis Bears FC", "Denver SC", "Fort Smith Fighters FC", "Jacksonville Snakes SC", "Mobile SC", "Oklahoma SC", "Green Bay Cheeseheads FC", "Atlanta SC", "Portland SC" };

    int leagueSelectNum;
    int teamSelectNum;
    public string selectedLeague;
    public string selectedTeam;

    // Start is called before the first frame update
    void Start()
    {
        leagueSelectNum = Random.Range(0, 3);
        teamSelectNum = Random.Range(0, 20);
        if (leagueSelectNum == 1)
        {
            selectedLeague = "USNL";
            PlayerPrefs.SetString("selectedLeague", selectedLeague);
        }
        if (leagueSelectNum == 2)
        {
            selectedLeague = "USSL";
            PlayerPrefs.SetString("selectedLeague", selectedLeague);
        }
        PickTeam();
    }

    // Update is called once per frame
    void Update()
    {
        PickTeam();
    }

    void PickTeam()
    {
        if (PlayerPrefs.GetString("selectedLeague") == "USNL")
        {
            selectedTeam = USNL_Teams[teamSelectNum];
            PlayerPrefs.SetString("selectedTeam", selectedTeam);
        }
        if (PlayerPrefs.GetString("selectedLeague") == "USSL")
        {
            selectedTeam = USSL_Teams[teamSelectNum];
            PlayerPrefs.SetString("selectedTeam", selectedTeam);
        }
    }
}
