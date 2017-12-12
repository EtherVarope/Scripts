using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    Canvas canvas;
    BaseUI basePanel;
    Transform targetTransform;
    Dictionary<Type, BaseUI> panelDic;
   

    public static UIManager Instance
    {
        get;
        set;
    }
    public UIManager()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        panelDic = new Dictionary<Type, BaseUI>();
    }


   /// <summary>
   /// 生成UI并装入字典
   /// </summary>
   /// <typeparam name="T"></typeparam>
   /// <returns></returns>
    public BaseUI Get_UI<T>() where T : BaseUI
    {
         if (panelDic.TryGetValue(typeof(T), out basePanel))
        {
            Debug.LogWarning(string.Format("{0}is loaded", typeof(T).Name));
            return basePanel;
        }
        else
        {
            Debug.Log(panelDic.TryGetValue(typeof(T), out basePanel));
            UnityEngine.Object obj = Resources.Load(string.Format("UI/Prefabs/{0}", typeof(T).Name));
            GameObject panelObject = GameObject.Instantiate(obj, canvas.transform) as GameObject;
            panelObject.name = typeof(T).Name;
            basePanel = panelObject.GetComponent<T>();
            panelDic.Add(typeof(T), basePanel);
            basePanel.Install_UI();
            Debug.Log(panelDic.TryGetValue(typeof(T), out basePanel));
        }
        return basePanel;
    }


 
    //销毁UI
    public void Throw_UI<T>() where T:BaseUI
    {
        BaseUI basePanel;
        if (panelDic.TryGetValue(typeof(T), out basePanel))
        {
            basePanel.Uninstall_UI();
            panelDic.Remove(typeof(T));

            GameObject.Destroy(basePanel.gameObject);
        }
        else
        {
            Debug.LogWarning(string.Format("{0}is not loaded,Destroy failed", typeof(T).Name));
         }

    }
   


    /// <summary>
    /// 激活UI
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public void ActiveUI<T>() where T : BaseUI
    {
        BaseUI basePanel;
        if (panelDic.TryGetValue(typeof(T), out basePanel))
        {
            basePanel.gameObject.SetActive(true);
        }
        else
         {
            Debug.LogWarning(string.Format("{0}無法被激活，可能它並沒有被裝入panelDic？", typeof(T).Name));
        }
    }
    /// <summary>
    /// 隐藏UI
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public void DeactiveUI<T>() where T : BaseUI
    {
        BaseUI basePanel;
        if (panelDic.TryGetValue(typeof(T), out basePanel))
        {
            basePanel.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning(string.Format("{0}無法被隱藏，可能它並沒有被裝入panelDic？", typeof(T).Name));
        }

    }

    //////////////////////////////////////////////////////////////////////////
    //============附加功能==============//
    //////////////////////////////////////////////////////////////////////////
    public bool is_UIExist<T>()where T:BaseUI
    {
        if (panelDic.TryGetValue(typeof(T), out basePanel))
        {
            Debug.LogWarning(string.Format("{0}is Exist", typeof(T).Name));
            return true;
        }
        else
            return false;
    }

}
