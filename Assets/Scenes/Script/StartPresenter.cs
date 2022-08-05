using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPresenter : MonoBehaviour
{

    [SerializeField] private StartModel _model;
    [SerializeField] private StartView _view;
    // Start is called before the first frame update
    void Start()
    {
        _model.LoadMainScene.AddListener(() => _view.LoadMain());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
