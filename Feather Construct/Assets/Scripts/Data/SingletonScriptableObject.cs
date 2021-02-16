using System.Linq;
using UnityEngine;

public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
{

    private static T instance = null;

    public static T Instance => instance ? instance :
        instance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();

}