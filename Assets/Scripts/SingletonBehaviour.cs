using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SingletonBehaviour<T> : MonoBehaviour where T: MonoBehaviour
{
    public static T inst;

    protected virtual void Awake()
    {
        if(inst != null)
        {
            Destroy(this.gameObject);
        }else
        {
            inst = this as T;
            DontDestroyOnLoad(this);
        }
    }
}
