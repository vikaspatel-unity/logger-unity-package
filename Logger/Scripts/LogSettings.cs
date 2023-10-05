
using System.IO;
using UnityEditor;
using UnityEngine;
public class LogSettings : ScriptableObject
{
    [SerializeField] private bool canPrintLog;

    private const string MobileAdsSettingsResDir = "Assets/Resources";

    private const string MobileAdsSettingsFile = "LogSetting";

    private const string MobileAdsSettingsFileExtension = ".asset";


    public static LogSettings LoadInstance()
    {
        //Read from resources.
        var instance = Resources.Load<LogSettings>(MobileAdsSettingsFile);

        //Create instance if null.
        if (instance == null)
        {
            Directory.CreateDirectory(MobileAdsSettingsResDir);
            instance = ScriptableObject.CreateInstance<LogSettings>();
            string assetPath = Path.Combine(
                MobileAdsSettingsResDir,
                MobileAdsSettingsFile + MobileAdsSettingsFileExtension);
            AssetDatabase.CreateAsset(instance, assetPath);
            AssetDatabase.SaveAssets();
        }

        return instance;
    }

    public bool CanPrintLog()
    {
        return canPrintLog;
    }
}
