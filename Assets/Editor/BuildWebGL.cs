using UnityEngine;
using UnityEditor;
	
	// Output the build size or a failure depending on BuildPlayer.
	
public class BuildWebGL : MonoBehaviour
	
	{
	    public static void MyBuild()
	
	    {
	
	        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
	
	        buildPlayerOptions.scenes = new[] { "Assets/Scenes/Beginning.unity", "Assets/Scenes/End.unity" };
	
	        buildPlayerOptions.locationPathName = "empty";
	
	        buildPlayerOptions.target = BuildTarget.WebGL;
	
	        buildPlayerOptions.options = BuildOptions.None;
	
	        BuildPipeline.BuildPlayer(buildPlayerOptions);
	
	
	    }
	
}
