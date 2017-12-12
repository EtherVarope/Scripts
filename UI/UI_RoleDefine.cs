using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_RoleDefine : MonoBehaviour {

    private Button Btn_ShowDeck;
    private string role_Name;

    // Use this for initialization
    void Start ()
    {
        
        Btn_ShowDeck = transform.Find("Role_Icon").GetComponent<Button>();
        Btn_ShowDeck.onClick.AddListener(OnClickShowCardDeck);
	}

    public void OnClickShowCardDeck()
    {
        role_Name = transform.name;
        Player_Manager.roleName = role_Name;
             
        if (UIManager.Instance.is_UIExist<UI_InitCardDeck>())
        {
            UIManager.Instance.Throw_UI<UI_InitCardDeck>();
            UIManager.Instance.Get_UI<UI_InitCardDeck>();
        }
        else
        {
            UIManager.Instance.Get_UI<UI_InitCardDeck>();
        }

    }

}
