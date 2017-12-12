using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "HealingPotionDefine", menuName = "ProjectFullMoon/FunctionTypeDefine/HealingPotionDefine")]

public class HealingPotion : Card_Function
{
    [Header("----------------治疗药水-------------------"),SerializeField]
    public int cureValue;
    public override void Excute()
    {
        throw new NotImplementedException();
    }
}

	
