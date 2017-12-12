using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_ChooseRole : BaseUI
{
    private Transform RoleDefine_Transform;
    private Button Btn_DecidedRole;
    private Button Btn_BackToTitle;
    GameObject [] gameObjects;
    GameObject obj;
    private RoleList_Define roleList;

    public override void Install_UI()
    {
        RoleDefine_Transform = transform.Find("Scroll View/Viewport/Content");
        Btn_DecidedRole = transform.Find("Btn_DecidedRole").GetComponent<Button>();
        Btn_BackToTitle = transform.Find("Btn_BackToTitle").GetComponent<Button>();
        //Add Btn EventListener
        Btn_DecidedRole.onClick.AddListener(OnClickDecidedRole);
        Btn_BackToTitle.onClick.AddListener(OnClickBackToTitle);
        InstallRoleDefine();
    }

    public override void Uninstall_UI()
    {
        if (UIManager.Instance.is_UIExist<UI_InitCardDeck>())
        {
            UIManager.Instance.Throw_UI<UI_InitCardDeck>();
        }
    }

    private void OnClickDecidedRole()
    {
        UIManager.Instance.Throw_UI<UI_ChooseRole>();
        SceneManager.LoadScene("MainScene");

    }
    private void OnClickBackToTitle()
    {
        UIManager.Instance.Get_UI<UI_StartMenu>();
        UIManager.Instance.Throw_UI<UI_ChooseRole>();
     
    }



    private void InstallRoleDefine()
    {

        roleList = Player_Manager.roleListDefine;
        gameObjects = new GameObject[roleList.role_Define.Count];
         for (int i = 0; i < roleList.role_Define.Count; i++)
        {
            obj = Resources.Load<GameObject>("UI/Prefabs/UI_RoleDefine");
            gameObjects[i] = GameObject.Instantiate(obj, RoleDefine_Transform);
            gameObjects[i].transform.name = roleList.role_Define[i].rolePrefabName;


            Image image_Role = gameObjects[i].transform.Find("Role_Icon").GetComponent<Image>();
            string roleIconPath = roleList.role_Define[i].roleIconName;
            image_Role.sprite = Resources.Load("Atlas/Role/" + roleIconPath, typeof(Sprite)) as Sprite;

            Text role_Name = gameObjects[i].transform.Find("Role_Text/Role_Name").GetComponent<Text>();
            string roleName = roleList.role_Define[i].roleName;

            role_Name.text = roleName;

            Text role_Desc = gameObjects[i].transform.Find("Role_Text/Role_Desc").GetComponent<Text>();
            string roleDesc = roleList.role_Define[i].roleDesc;
            role_Desc.text = roleDesc;


            Text role_Difficult = gameObjects[i].transform.Find("Role_Text/Role_Difficult").GetComponent<Text>();
            int roleDifficult = roleList.role_Define[i].roleDifficult;
            role_Difficult.text = "难度：" + roleDifficult;

        }
       
    }
    

}
