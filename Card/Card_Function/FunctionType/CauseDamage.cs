using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "CauseDamageDefine", menuName = "ProjectFullMoon/FunctionTypeDefine/CauseDamageDefine")]
public class CauseDamage : Card_Function
{
    public TargetType targetType;
    public DamageType damageType;
    public int damageValue;
    public override void Excute()
    {
         throw new NotImplementedException();
    }
}
