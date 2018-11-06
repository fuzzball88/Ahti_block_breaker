using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        brick.breackableCount = 0;
        SceneManager.LoadScene(name);
    }
    
    public void QuitRequest()
    {
        Debug.Log("Level Quit request");
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        brick.breackableCount = 0;
        Application.LoadLevel(Application.loadedLevel+1);
    }

    public void BrickDestroyed()
    {
        if (brick.breackableCount<=0)
        {
            LoadNextLevel();
        }
    }


}
