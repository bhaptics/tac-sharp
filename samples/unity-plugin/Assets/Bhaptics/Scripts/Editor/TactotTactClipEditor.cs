﻿using System.Collections;
using System.Collections.Generic;
using Bhaptics.Tact.Unity;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TactotTactClip), true)]
public class TactotTactClipEditor : TactFileClipEditor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        DefaultPropertyUi();
        
        DetailPropertyUi();

        ResetUi();

        GUILayout.Space(20);
        PlayUi();
        
        GUILayout.Space(3);
        SaveAsUi();

        serializedObject.ApplyModifiedProperties();
    }

    private void DetailPropertyUi()
    {
            GUILayout.Space(5);
            var originLabelWidth = EditorGUIUtility.labelWidth;
            EditorGUIUtility.labelWidth = 135f;

            GUILayout.BeginHorizontal();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("TactFileAngleX"), GUILayout.Width(350f));
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("TactFileOffsetY"), GUILayout.Width(350f));
            GUILayout.EndHorizontal();

            EditorGUIUtility.labelWidth = originLabelWidth;

            GUILayout.Space(5);
    }

}
