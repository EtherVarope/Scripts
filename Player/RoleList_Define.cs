/********************************************************************
	创建时间:	2017/12/11;11:12:2017   11:36
	文件路径: 	F:\Unity3D Project5.6\FullMoon\Assets\Scripts\Player\RoleList_Define.cs
	文件名:	RoleList_Define
	文件类型t:	cs
	文件作者:		MyPassion
//-------------------------------------------------------------------------------/
	主题:	玩家可选职业配置表
	功能:       
*********************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "PlayerRoleListDefine", menuName = "ProjectFullMoon/PlayerRoleListDefine")]
public class RoleList_Define:Role
{
    [Header("------------玩家可选职业配置表-------------")]
    public List<Role_Define> role_Define;

}
