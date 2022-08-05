using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartModel : MonoBehaviour
{
    public UnityEvent LoadMainScene = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMain", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadMain()
    {
        LoadMainScene.Invoke();
    }
}
