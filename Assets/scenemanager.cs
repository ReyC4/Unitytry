using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenemanager : MonoBehaviour
{
    public string sceneName;

    public void ChangeScenenow() {
        SceneManager.LoadScene(sceneName);
    }
}
