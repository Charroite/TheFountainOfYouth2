using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField]
    private int sceneNumber;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
