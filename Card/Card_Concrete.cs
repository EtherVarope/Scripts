using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "CardDefine", menuName = "ProjectFullMoon/CardDefine")]
public class Card_Concrete :Card
{
    //卡牌

    public int cardID;

    public string cardName;

    public FrameType cardFrame;

    public int cardLevel;
 
    public int cardCostGold;

    public Card_Type cardType;

    public List<Card_Function> cardFunction;

        
}
