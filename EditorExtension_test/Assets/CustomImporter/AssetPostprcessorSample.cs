using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

public class AssetPostprcessorSample : AssetPostprocessor
{
    private void OnPreprocessTexture(){
        
        Debug.Log($"OnPreprocessTexture{assetPath}");
    
        //Importer
        var importer = assetImporter as TextureImporter;
        if (importer == null) return;

        // "Texture/UI"
        if(assetPath.StartsWith("Assets/Texture/UI/")){
            
            importer.textureType = TextureImporterType.Sprite;
            importer.textureShape = TextureImporterShape.Texture2D;
            importer.mipmapEnabled = false;
            importer.wrapMode = TextureWrapMode.Clamp;
            importer.filterMode = FilterMode.Point;
            importer.spriteImportMode = SpriteImportMode.Single;
            return;
        }

        // "Texture/Background"
        if (assetPath.StartsWith("Assets/Texture/Background")){
            importer.textureType = TextureImporterType.Default;
            importer.textureShape = TextureImporterShape.Texture2D;
            importer.mipmapEnabled = false;
            importer.wrapMode = TextureWrapMode.Repeat;
            importer.filterMode = FilterMode.Bilinear;
            return;
        }



    }


    private void OnPostprocessTexture(Texture2D texture){
        Debug.Log($"OnPostProcessTexture{assetPath}");

    }

    




}