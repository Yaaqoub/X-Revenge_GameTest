using UnityEngine;
using System.Collections;
using System;
public class MySQLCon : MonoBehaviour 
{
    public PlayerHealth playerHealth;
    /*public string name;
    public int kills;
    public string time_round;*/
    public string addScoreURL = "http://localhost:81/projet/Connexion/addscore_Unity.php";

    string heur_debutt;
    string heur_finn;
    /*void Start()
    {
        if (playerHealth.currentHealth <= 0)
        {WWW.EscapeURL(name)
            StartCoroutine(PostScores(PlayerName.playerNamelvl, ScoreManager.kills, Timer.timeFin));
        }
    }*/

    void Awake()
    {
        heur_debutt = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
    }
    IEnumerator handleEnterScore(string name, string heur_debut, string heur_fin)
    {
        string register_url = addScoreURL + "?name=" + WWW.EscapeURL(name) + "&heur_debut=" + heur_debut + "&heur_fin=" + heur_fin;
        WWW entereddata = new WWW(register_url);
        yield return entereddata;
        if (entereddata.error != null)
        {
            Debug.Log("There was an error : " + entereddata.error);
        }
    }
    void Update()
    {
        
        if (playerHealth.currentHealth <= 0)
        {
            heur_finn = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P is pressed " + PlayerName.playerNamelvl);
            StartCoroutine(handleEnterScore(PlayerName.playerNamelvl, heur_debutt, heur_finn));
        }
    }
}
