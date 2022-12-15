using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public int nextScene;
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextScene);
    }
}
