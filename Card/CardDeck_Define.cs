using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "CardDeckDefine", menuName = "ProjectFullMoon/CardDeckDefine")]
public class CardDeck_Define :Card
{
    public string card_DeckName;
    public string roleName;
    public List<Card_Concrete > concrete_Card;
}
