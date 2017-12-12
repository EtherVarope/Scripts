/********************************************************************
	创建时间:	2017/12/06;6:12:2017   11:51
	文件路径: 	F:\Unity3D Project5.6\FullMoon\Assets\Scripts\Player\Role_DefineInfo.cs
	文件名:	Role_DefineInfo
	文件类型t:	cs
	文件作者:		Author
//-------------------------------------------------------------------------------/
	主题:  玩家职业设定
	功能:  设定玩家职业的基本属性/数据结构
*********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "PlayerRoleDefine", menuName = "ProjectFullMoon/PlayerRoleDefine")]
public class Role_Define : Role
{
   [Header("----------职业名")]
    public string roleName;
    [Header("----------职业预制体名")]
     public string rolePrefabName;
    [Header("----------职业形象名")]
    public string roleIconName;
    [Header("----------职业难度")]
    public int roleDifficult;
    [Header("----------职业描述")]
    public string roleDesc;
    [Header("----------职业初始卡组")]
    private List<CardDeck_Define > roleDeck;


}
