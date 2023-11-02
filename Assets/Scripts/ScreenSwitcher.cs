using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitcher : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void PlayAgain(){
        Application.LoadLevel(Application.loadedLevel);
    }
    public void OpenURL()
      {
          Application.OpenURL("https://forms.gle/NdrLGQMQrsj1imHu7");
          Debug.Log("is this working?");
      }
}
