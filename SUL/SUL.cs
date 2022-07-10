using System.ComponentModel;
using System.Xml.Linq;
using System.Linq;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using UnityEditor;

//SUL - A library to make development for 3D games easier or faster
namespace Sul{

    [CreateAssetMenu(fileName = "New Object", menuName = "SUL/Scriptable Entity")]
    public class SE : ScriptableObject{
        new public string name = "New Object";
        public Sprite icon = null;

        [Header("Parameters")]
        private Dictionary<dicAttribute, object> classes = new Dictionary<dicAttribute, object>();

        void OnValidate(){
            #if UNITY_EDITOR
                foreach(var thisClass in classes){
                    //Find the name of a class through attribute
                    
                }
            #endif
        }
    }

    public class Math{

    }

    [dic("STPlayer")]
    public sealed class STPlayer : MonoBehaviour{
        #region  Singleton
        private static readonly STPlayer instance = new STPlayer();

        static STPlayer()
        {
        }

        private STPlayer()
        {
        }

        public static STPlayer Instance{
            get{
                return instance;
            }
        }
        #endregion


    }

    public class SAI{

    }

    public class SDebug{
        
    }

    public static class SOperations{
        public static bool any(bool[] item){
            //Check every value in array
            //if a value is true in the array list it will return true and if not return false
            foreach(bool i in item){
                if(i == true){
                    return true;
                }
            }

            return false;
        }

        public static bool all(bool[] item){
            //Check for value in array
            //if all value are true it will return true and if one is false or all are false returns false
            for(int i = 0; i < item.Length;){
                if(item[i] == false){
                    return false;
                }else{
                    i++;
                }
            }

            return true;
        }
    }

    public abstract class SOD : MonoBehaviour{

        //Takes in a Scriptable object as a required parameter
        public SE scriptableEntity;

        void OnValidate(){
            #if UNITY_EDITOR
                //Check for scriptable object
                if(scriptableEntity == null){
                    Debug.LogWarning("Scriptable object not attached to " + this.name);
                }else
                    return;
            #endif
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple = true)] 
    public class dicAttribute : System.Attribute{
        public string objectName;

        public dicAttribute(string name){
            this.objectName = name;
        }
    }
}
