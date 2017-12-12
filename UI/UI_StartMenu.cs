using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StartMenu : BaseUI
{
    private Button Btn_StartGame;
    private Button Btn_LoadGame;
    private Button Btn_Achievement;

    /// <summary>
    /// Install UI_StartMenu Function
    /// </summary>
    public override void Install_UI()
    {
        Btn_StartGame = transform.Find("Btn_Panel/Btn_StartGame").GetComponent<Button>();
        Btn_LoadGame = transform.Find("Btn_Panel/Btn_LoadGame").GetComponent<Button>();
        Btn_Achievement = transform.Find("Btn_Panel/Btn_Achievement").GetComponent<Button>();
        //Add Button EventListener
        Btn_StartGame.onClick.AddListener(OnClickStartGame);
        Btn_LoadGame.onClick.AddListener(OnClickLoadGame);
        Btn_Achievement.onClick.AddListener(OnClickAchievement);
    }
    public override void Uninstall_UI()
    {

    }

    /// <summary>
    /// OnClickStartGame
    /// </summary>
    private void OnClickStartGame()
    {
        UIManager.Instance.Get_UI<UI_ChooseRole>();
        UIManager.Instance.Throw_UI<UI_StartMenu>();
    }
    /// <summary>
    /// OnClickAchievement
    /// </summary>
    private void OnClickAchievement()
    {
        Debug.Log("Achievement");
        throw new NotImplementedException();
    }
    /// <summary>
    /// OnClickLoadGame
    /// </summary>
    private void OnClickLoadGame()
    {
        throw new NotImplementedException();
    }
    

   
}
