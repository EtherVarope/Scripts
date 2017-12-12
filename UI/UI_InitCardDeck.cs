using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_InitCardDeck : BaseUI
{
    private int cardDeckID;

    private int cardCount;

    private string roleName;

    private string cardDeckName;

    private List<CardDeck_Define> cardDeck;

    private List<Card_Concrete> cardConcrete;

    private Transform CardDefine_Transform;

    private Button Btn_Close;

    GameObject obj;

    GameObject[] gameObjects;

    public override void Install_UI()
    {
        roleName = Player_Manager.roleName;

        foreach (CardDeck_Define cardDeckDefine in Player_Manager.cardDeckDefine)
        {
            if (roleName== cardDeckDefine.roleName)
            {
                cardDeckID = Player_Manager.cardDeckDefine.IndexOf(cardDeckDefine);
            }
        }
        Debug.Log("选择卡组ID:   "+cardDeckID);
     
        cardConcrete = Player_Manager.cardConcreteDefines[0];
        
        Debug.Log("CardDeckName   " + roleName);
        cardCount = cardConcrete.Count;
        gameObjects = new GameObject[cardCount];
        CardDefine_Transform = transform.Find("Scroll View/Viewport/Content");

        Btn_Close = transform.Find("Btn_Close").GetComponent<Button>();
        Btn_Close.onClick.AddListener(OnClickDeactive);


        StartCoroutine(InitCard(roleName));
      }

    public override void Uninstall_UI()
    {
        //throw new NotImplementedException();
    }

    /// <summary>
    /// 为了节省读取时间 这里读取过一次以后关闭界面实际上是隐藏界面
    /// </summary>
    public void OnClickDeactive()
    {
        UIManager.Instance.DeactiveUI<UI_InitCardDeck>();
     }

    private IEnumerator InitCard(string _carddeckname)
    {

        for (int i = 0; i < cardCount; i++)
        {

            obj = Resources.Load<GameObject>("UI/Prefabs/UI_CardDefine");
            gameObjects[i] = Instantiate(obj, CardDefine_Transform);
            gameObjects[i].transform.name = cardConcrete[i].cardName;
             yield return new WaitForSeconds(0.1f);
        }
       
    }

 
}
