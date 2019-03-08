using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Manager : MonoBehaviour {

	bool gameEnd = false;
	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void GameOver()

	{
		if(gameEnd == false) { 
			gameEnd = true;
			Invoke("Restart", restartDelay);  //restartDelay seconds
		}
	}
	void Restart()
	{
		//SceneManager.LoadScene("Level01");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void CompleteLevel()
	{
		//Debug.Log("Level complete!");
		completeLevelUI.SetActive(true);	
	}
}  //01807D
