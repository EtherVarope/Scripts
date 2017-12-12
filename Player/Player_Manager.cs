using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[DisallowMultipleComponent]
public class Player_Manager : MonoBehaviour {

    [SerializeField]
    public static int roleCount;

    public static int roleID;

    public static string roleName;//玩家使用角色名

    public static RoleList_Define roleListDefine;//玩家可用角色配置表

    public static List<Role_Define> roleDefeine;//角色配置

    public static CardDeckList_Define cardDeckListDefine;//玩家可用卡组配置表

    public static List<CardDeck_Define> cardDeckDefine;//卡组配置

    public static List<Card_Concrete> []cardConcreteDefines;//卡组
        
    public static Player_Manager Instance;
  
    void Awake()
    {
        Instance = this;

        roleListDefine = ScriptableObject.CreateInstance<RoleList_Define>();

        cardDeckListDefine = ScriptableObject.CreateInstance<CardDeckList_Define>();
        
        DontDestroyOnLoad(this.gameObject);
    
    }

    void Start()
    {
        roleListDefine = Resources.Load<RoleList_Define>("Game/PlayerRoleDefine/PlayerRoleListDefine");
        cardDeckListDefine = Resources.Load<CardDeckList_Define>("Game/CardDeckDefine/CardDeckListDefine");
        

        roleDefeine = roleListDefine.role_Define;
        cardDeckDefine = cardDeckListDefine.cardDeck_Define;
   
        roleCount = roleDefeine.Count;
        roleID = 0;
        cardConcreteDefines = new List<Card_Concrete>[roleCount];

        //Get 角色信息 + Get 卡组信息 +Get 卡牌信息
        //Find--->concrete_Card From--->cardDeckDefine;
        //All card information below here
        for (int i=0;i<roleCount;i++)
        {
            cardConcreteDefines[i] = cardDeckDefine[i].concrete_Card;
        }
          
    }
}
