using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{

    public void StartGame()
    {
        Object.FindFirstObjectByType<NewBehaviourScript>().bricksleft();

        SceneManager.LoadScene("Global");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is quitting");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
   
    public void Retry()
    {
      
        Object.FindFirstObjectByType<NewBehaviourScript>().Newgame();
       int random = Random.Range(1, 3);
        SceneManager.LoadScene("Level" + random.ToString());


    }

}
