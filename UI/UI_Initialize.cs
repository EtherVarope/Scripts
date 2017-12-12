using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Initialize : MonoBehaviour
{
    public static UI_Initialize Instance;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        //Initalize_UI
        UIManager.Instance = new UIManager();
        UIManager.Instance.Get_UI<UI_StartMenu>();

    }

}
