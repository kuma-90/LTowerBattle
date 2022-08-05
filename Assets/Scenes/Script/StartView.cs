using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class StartView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnClickChangeSceneGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
