using System;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Experimental.PostProcessing;

namespace UnityEditor.Experimental.PostProcessing
{
    public class BaseEditor<T> : Editor
        where T : MonoBehaviour
    {
        protected T m_Target
        {
            get { return (T)target; }
        }

        protected SerializedProperty FindProperty<TValue>(Expression<Func<T, TValue>> expr)
        {
            return serializedObject.FindProperty(RuntimeUtilities.GetFieldPath(expr));
        }
    }
}