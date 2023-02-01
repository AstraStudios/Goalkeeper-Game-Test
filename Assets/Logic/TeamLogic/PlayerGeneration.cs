using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerGeneration : MonoBehaviour
{
    [SerializeField] string[] possibleCountries = { "Switzerland", "USA", "Austria", "France", "Mexico", "Canada", "England", "Germany", "Netherlands", "Belgium", "Sweden", "Denmark", "Spain", "Portugal", "Italy" };
    [SerializeField] string[] possibleNames = { "Gunnar", "Covington", "David", "Kane", "Butler", "Gutizzer", "Loften", "Taylor", "Schlesinger", "Herring", "McMarion", "Geller", "Wynter", "Setna", "Barth", "Miller", "Travillion", "Gray", "Pryor", "Birdsong", "Sund", "McDonald", "Diggs", "Johnson", "Kuhl", "Abrams", "Schafer", "Harding", "Miceli", "Garcia", "Garza", "Jimeniz", "Najera", "Gomez", "Bowley", "Remington", "Boxer", "Lemini", "Granata", "Stokes", "Mueller", "Ning", "Omaledi", "Alexander", "Aubame", "Brendan", "Scott", "Laurie", "Richard", "Aspinwall", "Lloris", "Tim", "Marco", "Ben", "Meen", "Mein", "Peqn", "Brnyo", "Benktov", "Lamoya", "Jenkins", "Binqo", "Mounte", "Lankin", "Iona", "Booka", "Quinten", "Wiona", "Equiza", "Pie", "Kuna", "Jin", "Mines", "Whenat", "Bmodo", "Slimo", "Ionap", "Timon", "Beno"};
    [SerializeField] string[] positions = { "GK", "RB", "CB", "LB", "CM", "LW", "ST", "RW" };

    [SerializeField] TMP_Text playerPositionText;
    [SerializeField] TMP_Text playerOverallText; // Save for the overall script
    [SerializeField] TMP_Text playerNameText;
    [SerializeField] TMP_Text playerCountryText;
    [SerializeField] TMP_Text playerWorthText; // Depends on overall

    int randCountry;
    int randNames;
    int randPos;

    // Start is called before the first frame update
    void Start()
    {
        randCountry = Random.Range(0, 15);
        randNames = Random.Range(0, 79);
        randPos = Random.Range(0, 8);
        playerCountryText.text = possibleCountries[randCountry];
        playerNameText.text = possibleNames[randNames];
        playerPositionText.text = positions[randPos];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
