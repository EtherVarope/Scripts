using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "CardDeckListDefine", menuName = "ProjectFullMoon/CardDeckListDefine")]
public class CardDeckList_Define : ScriptableObject
{
    [Header("------------玩家可选卡组配置表-------------")]
    public List<CardDeck_Define > cardDeck_Define;

}
