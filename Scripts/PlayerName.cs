using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour 
{
    public static string playerNamelvl;
    public InputField playerName;
    public InputField playerpass;
    public Button startGame;
    public Button connection;
    ///
    public static string user = "", name = "";
    private string password = "", rePass = "", message = " ";

    private bool register = false;

    bool buttonClicked = false;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        startGame.enabled = false;
        
    }

    void Update()
    {
        playerNamelvl = playerName.text;
        //Debug.Log(playerPass.text);

        /*if(playerpass.isFocused && Input.GetKey(KeyCode.Return))
        {
            Debug.Log("enter is pressed");
            WWWForm form = new WWWForm();
            form.AddField("user", playerName.text);
            form.AddField("password", playerpass.text);
            WWW w = new WWW("http://localhost:81/XRevenge/login.php", form);
            StartCoroutine(login(w));
        }*/
    }
    public void MeClick()
    {
        buttonClicked = true;
    }
    private void OnGUI()
    {
        if (message != "")
            GUILayout.Box(message);
           

        if (register)
        {
           /* GUILayout.Label("Username");
            user = GUILayout.TextField(user);
            GUILayout.Label("Name");
            name = GUILayout.TextField(name);
            GUILayout.Label("password");
            password = GUILayout.PasswordField(password, "*"[0]);
            GUILayout.Label("Re-password");
            rePass = GUILayout.PasswordField(rePass, "*"[0]);

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Back"))
                register = false;

            if (GUILayout.Button("Register"))
            {
                message = "";

                if (user == "" || name == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    if (password == rePass)
                    {
                        WWWForm form = new WWWForm();
                        form.AddField("user", user);
                        form.AddField("name", name);
                        form.AddField("password", password);
                        WWW w = new WWW("http://f6-preview.awardspace.com/unitytutorial.com/register.php", form);
                        StartCoroutine(registerFunc(w));
                    }
                    else
                        message += "Your Password does not match \n";
                }
            }

            GUILayout.EndHorizontal();*/
        }
        else
        {
            //GUILayout.Label("User:");
            user = playerName.text; //GUILayout.TextField(user);
            //GUILayout.Label("Password:");
            password = playerpass.text;//GUILayout.PasswordField(password, "*"[0]);

            //GUILayout.BeginHorizontal();

            if (buttonClicked == true/*GUILayout.Button("Login")*/)
            {
                message = "";

                if (user == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    WWWForm form = new WWWForm();
                    form.AddField("user", user);
                    form.AddField("password", password);
                    WWW w = new WWW("http://localhost:81/projet/Connexion/login_Unity.php", form);
                    StartCoroutine(login(w));
                }
            }

            /*if (GUILayout.Button("Register"))
                register = true;*/
    
            //GUILayout.EndHorizontal();
        }
    }

    IEnumerator login(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            if (w.text == "login-SUCCESS")
            {
                print("WOOOOOOOOOOOOOOO!");
                Debug.Log("khdammmmmmmm");
                startGame.enabled = true;
            }
            else
            {
                message += w.text;
            }
                
        }
        else
        {
            message += "ERROR: " + w.error + "\n";
            
        }
        buttonClicked = false;

    }

    IEnumerator registerFunc(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            message += w.text;
        }
        else
        {
            message += "ERROR: " + w.error + "\n";
        }
    }
}
