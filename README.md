# X-Revenge_GameTest

Video game FPS made with Unity3D, it's our first game with Unity3D so we can learn how to made a game with Unity and how to program it. so we decided to share the code if any one want to improve it or learn from it.
to see the project report [click here](https://drive.google.com/file/d/0B40h0WEut28yOXd4T2x2cml4enc/view), the report is writing in French but if you want any explanation contact me.

## Use the Scripts

Any one can use and edite the scripts in any way he want, there is no conditions you can delete my name or anything you want.

### N.B.
We linked this game with a database, to change the database path
* **MySQLCon.cs**
```
public string addScoreURL = "http://localhost:81/projet/Connexion/addscore_Unity.php";
```
* **PlayerName.cs**
```
WWW w = new WWW("http://localhost:81/projet/Connexion/login_Unity.php", form);
```
But you have to create a database who matches our's,, all is in the script MySQLCon.cs .

## Built With

* [Unity3D](https://store.unity.com/) -  Cross-platform game engine.
* [Visual Studio](https://www.visualstudio.com/vs/) -   Integrated development environment (IDE)

## Authors

* **Yaaqoub Semlali** - [GitHub](https://github.com/Yaaqoub) - [LinkedIn](https://www.linkedin.com/in/semlaliyaaqoub)
* **Yassine Chetouane**
