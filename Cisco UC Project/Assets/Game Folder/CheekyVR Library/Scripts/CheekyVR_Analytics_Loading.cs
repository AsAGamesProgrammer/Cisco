using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using CheekyVR;

namespace CheekyVR
{
    [Serializable]
    public class AnalyticsData
    {
        public string dateStamp;
        public string timeStamp;

        public string userName;
        public string userID;

        public float pollingRate;

        public List<Vector3> cameraRigPosition;

        public List<Vector3> HMD_Position;
        public List<Quaternion> HMD_Rotation;

        public List<Vector3> leftControllerPosition;
        public List<Quaternion> leftControllerRotation;

        public List<Vector3> rightControllerPosition;
        public List<Quaternion> rightControllerRotation;

        public AnalyticsData()
        {
            dateStamp = DateTime.Now.ToString("dd/MM/yyyy");
            timeStamp = DateTime.Now.ToString("hh:mm:ss");

            cameraRigPosition = new List<Vector3>();

            HMD_Position = new List<Vector3>();
            HMD_Rotation = new List<Quaternion>();

            leftControllerPosition = new List<Vector3>();
            leftControllerRotation = new List<Quaternion>();

            rightControllerPosition = new List<Vector3>();
            rightControllerRotation = new List<Quaternion>();
        }

        public void clearCurrentData()
        {
            dateStamp = DateTime.Now.ToString("dd/MM/yyyy");
            timeStamp = DateTime.Now.ToString("hh:mm:ss");

            cameraRigPosition.Clear();

            HMD_Position.Clear();
            HMD_Rotation.Clear();

            leftControllerPosition.Clear();
            leftControllerRotation.Clear();

            rightControllerPosition.Clear();
            rightControllerRotation.Clear();
        }
    }
}

public class CheekyVR_Analytics_Loading : MonoBehaviour
{
    private string filePath = "D:/JSONTEST/30-08-2017_03-55-20_UserTest.json";
    private AnalyticsData dataStore;

    public GameObject graphNode;

    private Color cameraRigEdgeColour = Color.yellow;
    private Color HMD_EdgeColour = Color.green;
    private Color leftControllerEdgeColour = Color.magenta;
    private Color rightControllerEdgeColour = Color.cyan;

    public void LoadJsonInput()
    {
        string jsonSource = File.ReadAllText(filePath);

        dataStore = JsonUtility.FromJson<AnalyticsData>(jsonSource);
    }
}
