using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEngine.Rendering;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;
using UnityEditor.SceneManagement;

public class ArtistToolElements
{
    #region TimedElements
    #region GradientColors
    Gradient skyGradient = new Gradient();
    public Gradient SkyGradient {
        get {
            return skyGradient;
        }
        set {
             skyGradient.mode = value.mode;
             GradientColorKey[] colorKeys= new GradientColorKey [value.colorKeys.Length];
             for (int i = 0; i < colorKeys.Length; i++)
             {
                 colorKeys[i] = value.colorKeys[i]; 
             }

             GradientAlphaKey[] alphaKeys = new GradientAlphaKey[value.alphaKeys.Length];
             for (int i = 0; i < alphaKeys.Length; i++)
             {
                 alphaKeys[i] = value.alphaKeys[i];
             }


             skyGradient.SetKeys(colorKeys, alphaKeys);
           
        }
    }
 
    Gradient ruinsGradient = new Gradient();
    public Gradient RuinsGradient
    {
        get
        {
            return ruinsGradient;
        }

        set
        {
            ruinsGradient.mode = value.mode;
            GradientColorKey[] colorKeys = new GradientColorKey[value.colorKeys.Length];
            for (int i = 0; i < colorKeys.Length; i++)
            {
                colorKeys[i] = value.colorKeys[i];
            }

            GradientAlphaKey[] alphaKeys = new GradientAlphaKey[value.alphaKeys.Length];
            for (int i = 0; i < alphaKeys.Length; i++)
            {
                alphaKeys[i] = value.alphaKeys[i];
            }
            ruinsGradient.SetKeys(colorKeys, alphaKeys);
        }
    }

    Gradient treesGradient = new Gradient(); 
    public Gradient TreesGradient
    {
        get
        {
            return treesGradient;
        }

        set
        {
            treesGradient.mode = value.mode;
            GradientColorKey[] colorKeys = new GradientColorKey[value.colorKeys.Length];
            for (int i = 0; i < colorKeys.Length; i++)
            {
                colorKeys[i] = value.colorKeys[i];
            }

            GradientAlphaKey[] alphaKeys = new GradientAlphaKey[value.alphaKeys.Length];
            for (int i = 0; i < alphaKeys.Length; i++)
            {
                alphaKeys[i] = value.alphaKeys[i];
            }
            treesGradient.SetKeys(colorKeys, alphaKeys);
        }
    }
    Gradient rimGradient = new Gradient(); 
    public Gradient RimGradient
    {
        get
        {
            return rimGradient;
        }

        set
        {
            rimGradient.mode = value.mode;
            GradientColorKey[] colorKeys = new GradientColorKey[value.colorKeys.Length];
            for (int i = 0; i < colorKeys.Length; i++)
            {
                colorKeys[i] = value.colorKeys[i];
            }

            GradientAlphaKey[] alphaKeys = new GradientAlphaKey[value.alphaKeys.Length];
            for (int i = 0; i < alphaKeys.Length; i++)
            {
                alphaKeys[i] = value.alphaKeys[i];
            }
            rimGradient.SetKeys(colorKeys, alphaKeys);
        }
    }

    #endregion
    #region lights
    #region sunlight
    Gradient sunlightGradient = new Gradient(); 
    public Gradient SunlightGradient
    {
        get
        {
            return sunlightGradient;
        }

        set
        {
            sunlightGradient.mode = value.mode;
            GradientColorKey[] colorKeys = new GradientColorKey[value.colorKeys.Length];
            for (int i = 0; i < colorKeys.Length; i++)
            {
                colorKeys[i] = value.colorKeys[i];
            }

            GradientAlphaKey[] alphaKeys = new GradientAlphaKey[value.alphaKeys.Length];
            for (int i = 0; i < alphaKeys.Length; i++)
            {
                alphaKeys[i] = value.alphaKeys[i];
            }
            sunlightGradient.SetKeys(colorKeys, alphaKeys);
        }
    }
    public Sprite SunlightSprite;
    public float SunlightIntencity;
    #endregion
    #region Grass Light
    Gradient grassLightGradient = new Gradient(); 
    public Gradient GrassLightGradient
    {
        get
        {
            return grassLightGradient;
        }

        set
        {
            grassLightGradient.mode = value.mode;
            GradientColorKey[] colorKeys = new GradientColorKey[value.colorKeys.Length];
            for (int i = 0; i < colorKeys.Length; i++)
            {
                colorKeys[i] = value.colorKeys[i];
            }

            GradientAlphaKey[] alphaKeys = new GradientAlphaKey[value.alphaKeys.Length];
            for (int i = 0; i < alphaKeys.Length; i++)
            {
                alphaKeys[i] = value.alphaKeys[i];
            }
            grassLightGradient.SetKeys(colorKeys, alphaKeys);
        }
    }
    public float GrassLightIntensity;
    #endregion
    #region Cave Hole Light
    public float FalloffCaveHole;
    public float FalloffIntensityCaveHole;
    #endregion
    #endregion

    #endregion

    #region Constant Elements
    #region Wind
    public Vector4 WindDirection;
    public float WindScale;
    public MinMaxValue WindStrength;
    public float WindSpeed;
    #endregion
    #region Postprocessing
    #region WhiteBalance
    public float WhiteBalanceTemperature;
    public float WhiteBalanceTint;
    #endregion
    #region Bloom
    public float BloomIntensity;
    Color bloomTint = new Color(); 
    public Color BloomTint
    {
        get
        {
            return bloomTint;
        }

        set
        {
               bloomTint = new Color(value.r, value.g, value.b, value.a); 
        }
    }
    #endregion
    #endregion
    #region VFX
    #region GlowParticles
    public float GlowParticleEmission;
    public ParticleSystemRenderMode GlowParticlesRenderMode;
    public Material GlowParticleRenderMaterial; 
    #endregion
    #endregion
    #endregion

}
public class MinMaxValue
{
    public float minValue;
    public float maxValue;
    public float LowLimit;
    public float HighLimit;
    public MinMaxValue()
    {
      minValue=0;
      maxValue = 0;
      LowLimit = 0;
      HighLimit = 0;

}
    public MinMaxValue(MinMaxValue temp)
    {
        minValue = temp.minValue;
        maxValue =temp.maxValue;
        LowLimit =temp.LowLimit;
        HighLimit = temp.HighLimit;

    }
}
enum toolsType
{
    Full,
    Wind,
    Postprocessing,
Lights,

}
public class ArtistToolControllerEditor : EditorWindow
{

    ArtistToolElements initialSceneValues = new ArtistToolElements();
    LightColorController TimeController;
    #region TimedElements
    #region GradientColors 
    MaterialColorSetter SkyColorSetter;
    MaterialColorSetter RuinsColorSetter;
    LightColorSetter TreesColorSetter;
    MaterialColorSetter RimColorSetter;
    #endregion
    #region lights
    #region sunlight

    LightColorSetter SunSpot_Group;
    Light2D[] SunSpots;
    #endregion
    #region Grass Light
    LightColorSetter GrassLight_Group;
    Light2D GrassLight;
    #endregion
    #region Cave Hole Light
    Light2D CaveHoleLight;
    #endregion
    #endregion

    #endregion

    #region Constant Elements
    #region Wind
    Material[] WindMaterials;
    #endregion
    #region Postprocessing
    #region WhiteBalance
    Volume postprocessingVolume;
    WhiteBalance whiteBalanceProperty;
    Bloom BloomProperty;
    #endregion
    #endregion
    #region VFX
    #region GlowParticles
    ParticleSystem GlowParticleSystem;
    #endregion
    #endregion
    #endregion

    static toolsType CurrentArtistTool = toolsType.Full;
    [MenuItem("Artist Tools/Open Artist Tool")]
    public static void ShowArtistToolWindow()
    {
        CurrentArtistTool = toolsType.Full;
        // Opens the window, otherwise focuses it if it’s already open.
        var window = GetWindow<ArtistToolControllerEditor>();
        window.OnEnable();


        // Adds a title to the window.
        window.titleContent = new GUIContent("Artist Tools");

        // Sets a minimum size to the window.
        window.minSize = new Vector2(250, 50);



    }

  void SetArtistTool()
    {


        VisualElement root = rootVisualElement;

        root.Clear();

        VisualTreeAsset ArtistToolVisualTree = Resources.Load<VisualTreeAsset>("ArtistTool");
        ArtistToolVisualTree.CloneTree(root);
        root.styleSheets.Add(Resources.Load<StyleSheet>("ArtistTool"));

        SerializedObject serialized_TimeController = new SerializedObject(TimeController);
        Slider timeSlider = root.Q<Slider>(name: "Time");

      
        timeSlider.Bind(serialized_TimeController);


        #region SkyColor

        //add a Gradient Editor Setter
        VisualElement gradientVisualElement = root.Q<VisualElement>(name: "SkyGradient");
        if (gradientVisualElement != null)
        {
            GradientField gradientField = gradientVisualElement.Q<GradientField>();
            SerializedObject serialized_MaterialSetter = new SerializedObject(SkyColorSetter);
            gradientField.bindingPath = "gradient";
            gradientField.Bind(serialized_MaterialSetter);

            gradientVisualElement.Q<Label>().text = "Sky Gradient";
        }
            #endregion

            #region Ruins
              GradientEditorSetter("RuinsGradient", "Ruins Gradient", RuinsColorSetter);
            #endregion

            #region Trees
            GradientEditorSetter("TreesGradient", "Trees Gradient", TreesColorSetter);
            #endregion

            #region Rim
             GradientEditorSetter("RimColor", "Rim Gradient", RimColorSetter);
            #endregion


            #region Lights

            #region SunLights
            SerializedObject serialized_SunSpot = new SerializedObject(SunSpot_Group);

        VisualElement sunLightVisualElement = root.Q<VisualElement>(name: "Sunlight");
        FloatField sunLightIntensity = root.Q<FloatField>(name: "Intensity");

        if (sunLightVisualElement.Q<VisualElement>(name: "LightGradient") != null)
        {
            GradientField sunLightGradient = sunLightVisualElement.Q<VisualElement>(name: "LightGradient").Q<GradientField>();
            sunLightGradient.Bind(serialized_SunSpot);
            sunLightGradient.label = "Gradient";
        }

        sunLightIntensity.value = GetSpotLightIntensity();
        sunLightIntensity.RegisterCallback<ChangeEvent<float>>(ChangeIntensitySpotLightsEvent);

        #endregion

        #region GrassLight
        SerializedObject serialized_GrassLight_Group = new SerializedObject(GrassLight_Group);

        VisualElement grassLightVisualElement = root.Q<VisualElement>(name: "GrassLight");
        FloatField grassLightIntensity = root.Q<FloatField>(name: "Intensity");

        if (grassLightVisualElement.Q<VisualElement>(name: "LightGradient") != null)
        {
            GradientField grassLightGradient = grassLightVisualElement.Q<VisualElement>(name: "LightGradient").Q<GradientField>();
            grassLightGradient.Bind(serialized_GrassLight_Group);
            grassLightGradient.label = "Gradient";
        }

        grassLightIntensity.value = GetSpotLightIntensity();

        SerializedObject serialized_GrassLight = new SerializedObject(GrassLight);
        grassLightIntensity.Bind(serialized_GrassLight);

        #endregion

        #region cave Light 
        SerializedObject serialized_CaveHoleLight = new SerializedObject(CaveHoleLight);

        VisualElement caveLightVisualElement = root.Q<VisualElement>(name: "CaveHoleLight");
        caveLightVisualElement.Q<FloatField>(name: "Falloff").Bind(serialized_CaveHoleLight);

        Slider fallOffSlider = caveLightVisualElement.Q<Slider>(name: "FalloffIntencity");
        FloatField fallOffField = fallOffSlider.Q<FloatField>(name: "CurrentValue");
        fallOffSlider.Bind(serialized_CaveHoleLight);

        fallOffField.SetValueWithoutNotify(CaveHoleLight.falloffIntensity);

        fallOffField.RegisterCallback<ChangeEvent<float>>((evt) => fallOffSlider.value = evt.newValue);

        fallOffSlider.RegisterCallback<ChangeEvent<float>>((evt) => fallOffField.SetValueWithoutNotify(evt.newValue));

        #endregion

        #region Visualisers
        var AllGradientElements = root.Query<GradientField>();
        if(AllGradientElements!=null)
        AllGradientElements.ForEach((element) =>
        {
            //registerCallback for Gradient to apply changes on scene
            element.RegisterCallback<ChangeEvent<Gradient>>(ChangeGradientEvent);

            VisualElement visualiser = element.Q<VisualElement>(name: "VisualisationColor"); 

            //Init color of visualisation cube
            float currentTime = TimeController.timeValue;
            visualiser.style.backgroundColor = element.value.Evaluate(currentTime);

            //register Callback for each visualisation cube when gradient Changes 
            element.RegisterCallback<ChangeEvent<Gradient>>((evt) =>
            {
                float timeOfChange = TimeController.timeValue;
                visualiser.style.backgroundColor = evt.newValue.Evaluate(currentTime);
            });

            //register Callback for each visualisation cube when Time Changes 
            timeSlider.RegisterCallback<ChangeEvent<float>>((evt) =>
            {
                visualiser.style.backgroundColor = element.value.Evaluate(evt.newValue);
            });
        });
        #endregion

        #endregion

        #region Wind Shader
        // Set Initial Values
        VisualElement windComponent = root.Q<VisualElement>(name: "Wind");
        if (windComponent != null)
        {
            Vector4Field windDirectionQuaternion = windComponent.Q<Vector4Field>(name: "WindDirection");
            windDirectionQuaternion.value = GetWindDirection();

            FloatField windScaleFloat = windComponent.Q<FloatField>(name: "WindScale");
            windScaleFloat.value = GetWindScale();

            MinMaxValue minMaxStrength = GetWindStrength();

            VisualElement windStrengthHolder = windComponent.Q<VisualElement>(name: "WinStrengthHolder");

            MinMaxSlider windStrengthSlider = windStrengthHolder.Q<MinMaxSlider>(name: "WindStrength");
            windStrengthSlider.highLimit = minMaxStrength.HighLimit;
            windStrengthSlider.lowLimit = minMaxStrength.LowLimit;
            windStrengthSlider.value = new Vector2(minMaxStrength.minValue, minMaxStrength.maxValue);

            windStrengthHolder.Q<Label>(name: "MinValue").text = "Min Value :" + minMaxStrength.minValue;
            windStrengthHolder.Q<Label>(name: "MaxValue").text = "Max Value :" + minMaxStrength.maxValue;

            FloatField windSpeedFloat = windComponent.Q<FloatField>(name: "WindSpeed");
            windSpeedFloat.value = GetWindSpeed();

            //Set Callbacks values
            windDirectionQuaternion.RegisterCallback<ChangeEvent<Vector4>>(ChangeWindDirection);
            windScaleFloat.RegisterCallback<ChangeEvent<float>>(ChangeWindScale);
            windStrengthSlider.RegisterCallback<ChangeEvent<Vector2>>(ChangeWindStrength);
            windSpeedFloat.RegisterCallback<ChangeEvent<float>>(ChangeWindSpeed);
        }

        #endregion

        #region Postprocessing
        #region WhiteBalance
        //serialize White balance property 
        SerializedObject serialized_whiteBalanceProperty = new SerializedObject(whiteBalanceProperty);
        //Get White balance Visual Element 
        VisualElement whiteBalanceVisualElement = root.Q<VisualElement>(name: "WhiteBalance");

        #region Temperature
        //Get White Balance temperature Visual Element 
        VisualElement whiteBalanceTemperatureVE = whiteBalanceVisualElement.Q<VisualElement>(name: "Temperature");

        //Get White Balance temperature Slider 
        Slider whiteBalanceTemperatureSlider = whiteBalanceTemperatureVE.Q<Slider>(name: "SliderValue");

        //Bind Slider to value
        whiteBalanceTemperatureSlider.bindingPath = "temperature.m_Value";
        whiteBalanceTemperatureSlider.Bind(serialized_whiteBalanceProperty);

        //Get White Balance temperature Float Field  
        FloatField whiteBalanceTemperatureFloat = whiteBalanceTemperatureVE.Q<FloatField>(name: "CurrentValue");
        //Set default Temperature
        whiteBalanceTemperatureFloat.SetValueWithoutNotify(whiteBalanceProperty.temperature.value);

        //Register change callback for the float field to change the slider value. Changing slider value will change the values bound with it.
        whiteBalanceTemperatureFloat.RegisterCallback<ChangeEvent<float>>((evt) => whiteBalanceTemperatureSlider.value = evt.newValue);

        //Register change Callback for the slider, to change the float fiel Without notification (to avoid triggering Float field callback) 
        whiteBalanceTemperatureSlider.RegisterCallback<ChangeEvent<float>>((evt) => whiteBalanceTemperatureFloat.SetValueWithoutNotify(evt.newValue));
        #endregion

        #region Tint

        //Get White Balance Tint Visual Element
        VisualElement whiteBalanceTintVE = whiteBalanceVisualElement.Q<VisualElement>(name: "Tint");

        //Get White Balance Tint Slider 
        Slider whiteBalanceTintSlider = whiteBalanceTintVE.Q<Slider>(name: "SliderValue");

        //Bind Slider to value
        whiteBalanceTintSlider.bindingPath = "tint.m_Value";
        whiteBalanceTintSlider.Bind(serialized_whiteBalanceProperty);


        //Get White Balance Tint Float Field  
        FloatField whiteBalanceTintFloat = whiteBalanceTintVE.Q<FloatField>(name: "CurrentValue");
        //Set default Tint
        whiteBalanceTintFloat.SetValueWithoutNotify(whiteBalanceProperty.tint.value);

        //Register change callback for the float field to change the slider value. Changing slider value will change the values bound with it.
        whiteBalanceTintFloat.RegisterCallback<ChangeEvent<float>>((evt) => whiteBalanceTintSlider.value = evt.newValue);

        //Register change Callback for the slider, to change the float fiel Without notification (to avoid triggering Float field callback) 
        whiteBalanceTintSlider.RegisterCallback<ChangeEvent<float>>((evt) => whiteBalanceTintFloat.SetValueWithoutNotify(evt.newValue));
        #endregion

        #endregion

        #region Bloom

        //serialize bloom property 
        SerializedObject serialized_BloomProperty = new SerializedObject(BloomProperty);
        //Get Bloom Visual Element 
        VisualElement bloomVisualElement = root.Q<VisualElement>(name: "Bloom");

        //Get Bloom Tint Color
        ColorField bloomTint = bloomVisualElement.Q<ColorField>(name: "Tint");

        //Bind color to value
        bloomTint.bindingPath = "tint.m_Value";
        bloomTint.Bind(serialized_BloomProperty);

        //Get Bloom Intensity
        FloatField bloomIntensity = bloomVisualElement.Q<FloatField>(name: "Intensity");

        //Bind color to value
        bloomIntensity.bindingPath = "intensity.m_Value";
        bloomIntensity.Bind(serialized_BloomProperty);

        #endregion
        #endregion


        #region VFX

        SerializedObject serialized_GlowParticleSystem = new SerializedObject(GlowParticleSystem);

        VisualElement VFXVisualElement = root.Q<VisualElement>(name: "VFX");

        FloatField VFXEmission = VFXVisualElement.Q<FloatField>(name: "Emission");
        VFXEmission.bindingPath = "EmissionModule.rateOverTime.scalar";
        VFXEmission.Bind(serialized_GlowParticleSystem);

        EnumField VFXRenderMode = VFXVisualElement.Q<EnumField>(name: "RenderMode");
        VFXRenderMode.Init(GlowParticleSystem.GetComponent<ParticleSystemRenderer>().renderMode);
        VFXRenderMode.RegisterCallback<ChangeEvent<string>>(ChangeRenderMode);

        ObjectField VFXMaterial = VFXVisualElement.Q<ObjectField>(name: "Material");
        VFXMaterial.objectType = typeof(Material);
        VFXMaterial.RegisterCallback<ChangeEvent<string>>(ChangeRenderMaterial);

        #endregion

        root.Q<Button>(name: "SaveButton").clicked += SaveButton;
        root.Q<Button>(name: "ResetButton").clicked += ResetToInitialSceneValues;


       

    }
  
    void GradientEditorSetter(string GradientName, string GradientLabel, MaterialColorSetter MaterialSetter)
    {
        VisualElement root = rootVisualElement;
        VisualElement gradientVisualElement = root.Q<VisualElement>(name: GradientName);

        if (gradientVisualElement != null)
        {
            GradientField gradientField = gradientVisualElement.Q<GradientField>();
            SerializedObject serialized_MaterialSetter = new SerializedObject(MaterialSetter);
            gradientField.bindingPath = "gradient";
            gradientField.Bind(serialized_MaterialSetter);
            gradientVisualElement.Q<Label>().text = GradientLabel;
        }


    }
    void GradientEditorSetter(string GradientName, string GradientLabel, LightColorSetter MaterialSetter)
    {
        VisualElement root = rootVisualElement;
        VisualElement gradientVisualElement = root.Q<VisualElement>(name: GradientName);

        if (gradientVisualElement != null)
        {
            GradientField gradientField = gradientVisualElement.Q<GradientField>();
            SerializedObject serialized_MaterialSetter = new SerializedObject(MaterialSetter);
            gradientField.bindingPath = "gradient";
            gradientField.Bind(serialized_MaterialSetter);
            gradientVisualElement.Q<Label>().text = GradientLabel;
        }


    }

    [MenuItem("Artist Tools/Open Wind Artist Tool")]
    public static void ShowWindArtistToolWindow()
    {
        CurrentArtistTool = toolsType.Wind;
        // Opens the window, otherwise focuses it if it’s already open.
        var window = GetWindow<ArtistToolControllerEditor>();
        window.OnEnable();
        // Adds a title to the window.
        window.titleContent = new GUIContent("Wind Artist Tool");

        // Sets a minimum size to the window.
        window.minSize = new Vector2(250, 50);


    }

    void GetInitialSceneValues()
    {

        initialSceneValues.SkyGradient = SkyColorSetter.gradient;
        initialSceneValues.RuinsGradient = RuinsColorSetter.gradient;
        initialSceneValues.TreesGradient = TreesColorSetter.gradient;
        initialSceneValues.RimGradient = RimColorSetter.gradient;


        initialSceneValues.SunlightGradient = SunSpot_Group.gradient;
        initialSceneValues.SunlightIntencity = GetSpotLightIntensity();

        initialSceneValues.GrassLightGradient = GrassLight_Group.gradient;
        initialSceneValues.GrassLightIntensity = GrassLight.intensity;

        initialSceneValues.FalloffCaveHole = CaveHoleLight.shapeLightFalloffSize;
        initialSceneValues.FalloffIntensityCaveHole = CaveHoleLight.falloffIntensity;

        initialSceneValues.WindDirection = GetWindDirection();
        initialSceneValues.WindScale = GetWindScale();
        initialSceneValues.WindStrength = new MinMaxValue(GetWindStrength());
        initialSceneValues.WindSpeed = GetWindSpeed();

        initialSceneValues.WhiteBalanceTemperature = whiteBalanceProperty.temperature.value;
        initialSceneValues.WhiteBalanceTint = whiteBalanceProperty.tint.value;

        initialSceneValues.BloomIntensity = BloomProperty.intensity.value;
        initialSceneValues.BloomTint = BloomProperty.tint.value;

        initialSceneValues.GlowParticleEmission = GlowParticleSystem.emission.rateOverTime.constant;
        initialSceneValues.GlowParticlesRenderMode = GlowParticleSystem.GetComponent<ParticleSystemRenderer>().renderMode;
        initialSceneValues.GlowParticleRenderMaterial = GlowParticleSystem.GetComponent<ParticleSystemRenderer>().sharedMaterial;


    }
    void ResetToInitialSceneValues()
    {
        VisualElement root = rootVisualElement;

        VisualElement SkyGradientVE = root.Q<VisualElement>(name: "SkyGradient"); 
        if (SkyGradientVE != null)
            SkyGradientVE.Q<GradientField>().value = initialSceneValues.SkyGradient;

        VisualElement RuinsGradientVE = root.Q<VisualElement>(name: "RuinsGradient");
        if (RuinsGradientVE != null)
            RuinsGradientVE.Q<GradientField>().value = initialSceneValues.RuinsGradient;

        VisualElement TreesGradientVE = root.Q<VisualElement>(name: "TreesGradient");
        if (TreesGradientVE != null)
            TreesGradientVE.Q<GradientField>().value = initialSceneValues.TreesGradient;

        VisualElement RimColorVE = root.Q<VisualElement>(name: "RimColor");
        if (RimColorVE != null)
            RimColorVE.Q<GradientField>().value = initialSceneValues.RimGradient;

        VisualElement SunlightVE = root.Q<VisualElement>(name: "Sunlight");
        if (SunlightVE != null)
        {if(SunlightVE.Q<VisualElement>(name: "LightGradient")!=null)
            SunlightVE.Q<VisualElement>(name: "LightGradient").Q<GradientField>().value = initialSceneValues.SunlightGradient;
            SunlightVE.Q<FloatField>(name: "Intensity").value = initialSceneValues.SunlightIntencity;
        }

        VisualElement GrassLightVE = root.Q<VisualElement>(name: "GrassLight");
        if (GrassLightVE != null)
        {
            if (GrassLightVE.Q<VisualElement>(name: "LightGradient") != null)
                GrassLightVE.Q<VisualElement>(name: "LightGradient").Q<GradientField>().value = initialSceneValues.GrassLightGradient;
            GrassLightVE.Q<FloatField>(name: "Intensity").value = initialSceneValues.GrassLightIntensity;
        }

        VisualElement CaveHoleLightVE = root.Q<VisualElement>(name: "CaveHoleLight");
        if (CaveHoleLightVE != null)
        {
            CaveHoleLightVE.Q<FloatField>(name: "Falloff").value = initialSceneValues.FalloffCaveHole;
            CaveHoleLightVE.Q<Slider>(name: "FalloffIntencity").value = initialSceneValues.FalloffIntensityCaveHole;
            CaveHoleLightVE.Q<VisualElement>(name: "FalloffIntencity").Q<FloatField>(name: "CurrentValue").value = initialSceneValues.FalloffIntensityCaveHole;
        }

        VisualElement WindVE = root.Q<VisualElement>(name: "Wind");
        if (WindVE != null)
        {
            Vector4Field WindDirection = WindVE.Q<Vector4Field>(name: "WindDirection"); 
            if (WindDirection != null)
                WindDirection.value = initialSceneValues.WindDirection;

            FloatField WindScale = WindVE.Q<FloatField>(name: "WindScale"); 
            if (WindScale != null)
                WindScale.value = initialSceneValues.WindScale;

            MinMaxSlider WindStrength = WindVE.Q<MinMaxSlider>(name: "WindStrength"); 
            if (WindStrength != null)
            {
                WindStrength.minValue = initialSceneValues.WindStrength.minValue;
                WindStrength.maxValue = initialSceneValues.WindStrength.maxValue;
            }
            VisualElement WinStrengthHolder = WindVE.Q<VisualElement>(name: "WinStrengthHolder"); 
            if (WinStrengthHolder != null)
            {
                WinStrengthHolder.Q<Label>(name: "MinValue").text = "Min Value :" + initialSceneValues.WindStrength.minValue;
                WinStrengthHolder.Q<Label>(name: "MaxValue").text = "Max Value :" + initialSceneValues.WindStrength.maxValue;
            }
            FloatField WindSpeed = WindVE.Q<FloatField>(name: "WindSpeed"); 
            if (WindSpeed != null)
                WindSpeed.value = initialSceneValues.WindSpeed;
        }

        VisualElement WhiteBalanceVE = root.Q<VisualElement>(name: "WhiteBalance"); 
        if (WhiteBalanceVE != null)
        {
            VisualElement whiteBalanceTemperature = WhiteBalanceVE.Q<VisualElement>(name: "Temperature");
            whiteBalanceTemperature.Q<Slider>(name: "SliderValue").value = initialSceneValues.WhiteBalanceTemperature;
            whiteBalanceTemperature.Q<FloatField>(name: "CurrentValue").value = initialSceneValues.WhiteBalanceTemperature;

            VisualElement whiteBalanceTint = WhiteBalanceVE.Q<VisualElement>(name: "Tint");
            whiteBalanceTint.Q<Slider>(name: "SliderValue").value = initialSceneValues.WhiteBalanceTint;
            whiteBalanceTint.Q<FloatField>(name: "CurrentValue").value = initialSceneValues.WhiteBalanceTint;
        }

        VisualElement BloomVE = root.Q<VisualElement>(name: "Bloom");
        if (BloomVE != null)
        {
            BloomVE.Q<ColorField>(name: "Tint").value = initialSceneValues.BloomTint;
            BloomVE.Q<FloatField>(name: "Intensity").value = initialSceneValues.BloomIntensity;
        }
        VisualElement VFXVisualElement = root.Q<VisualElement>(name: "VFX"); 
        if (VFXVisualElement != null)
        {
            VFXVisualElement.Q<FloatField>(name: "Emission").value = initialSceneValues.GlowParticleEmission;
            VFXVisualElement.Q<EnumField>(name: "RenderMode").Init(initialSceneValues.GlowParticlesRenderMode);
            SetRenderMaterial(initialSceneValues.GlowParticleRenderMaterial);
        }



    }
    void SaveButton()
    {


        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            GetInitialSceneValues();
        }
    }

    void FindElementsToEdit()
    {
        if (GameObject.Find("Lights Controller"))
        {
            TimeController = GameObject.Find("Lights Controller").GetComponent<LightColorController>();
        }

        if (GameObject.Find("Light - Sky") != null)
        {
            SkyColorSetter = GameObject.Find("Light - Sky").GetComponent<MaterialColorSetter>();
        }

        if (GameObject.Find("Light - Ruin") != null)
        {
            RuinsColorSetter = GameObject.Find("Light - Ruin").GetComponent<MaterialColorSetter>();
        }

        if (GameObject.Find("Light Group - Tree Tops") != null)
        {
            TreesColorSetter = GameObject.Find("Light Group - Tree Tops").GetComponent<LightColorSetter>();
        }
        if (GameObject.Find("Vegetation Setter - Rim Color") != null)
        {
            RimColorSetter = GameObject.Find("Vegetation Setter - Rim Color").GetComponent<MaterialColorSetter>();
        }
        if (GameObject.Find("Light Group - Sun Spots - 1") != null)
        {
            SunSpot_Group = GameObject.Find("Light Group - Sun Spots - 1").GetComponent<LightColorSetter>();
            if (SunSpot_Group.gameObject.GetComponentsInChildren<Light2D>() != null)

                SunSpots = SunSpot_Group.gameObject.GetComponentsInChildren<Light2D>();
        }

        if (GameObject.Find("Light Group - Grass") != null)
        {
            GrassLight_Group = GameObject.Find("Light Group - Grass").GetComponent<LightColorSetter>();
            if (GrassLight_Group.gameObject.GetComponentInChildren<Light2D>() != null)
                GrassLight = GrassLight_Group.gameObject.GetComponentInChildren<Light2D>();

        }

        if (GameObject.Find("Light - Cave Hole - 1") != null)
        {
            CaveHoleLight = GameObject.Find("Light - Cave Hole - 1").GetComponent<Light2D>();

        }

        if (GameObject.Find("Light Group - Sun Spots - 1") != null)
        {
            GameObject SunSpotsHolder = GameObject.Find("Light Group - Sun Spots - 1");
            if (SunSpotsHolder.GetComponentsInChildren<Light2D>() != null)
                SunSpots = SunSpotsHolder.GetComponentsInChildren<Light2D>();
        }
        WindMaterials = Resources.Load<ScriptableWindMaterial>("WindMaterials").WindMaterials;

        if (GameObject.Find("Volume - Global") != null)
        {
            postprocessingVolume = GameObject.Find("Volume - Global").GetComponent<Volume>();

            postprocessingVolume.sharedProfile.TryGet(out whiteBalanceProperty);
            postprocessingVolume.sharedProfile.TryGet(out BloomProperty);
        }
        if (GameObject.Find("Particles_Glow") != null)
        {
            GlowParticleSystem = GameObject.Find("Particles_Glow").GetComponent<ParticleSystem>();

        }

    }

    private void OnEnable()
    {
        FindElementsToEdit();
        GetInitialSceneValues();

        if (CurrentArtistTool == toolsType.Full)
            SetArtistTool();
        else if (CurrentArtistTool == toolsType.Wind)
            SetWindSetArtistTool();

    }
    void SetWindSetArtistTool()
    {
        VisualElement root = rootVisualElement;
        root.Clear();
        //Loads and clones our VisualTree inside the root.
        VisualTreeAsset quickToolVisualTree = Resources.Load<VisualTreeAsset>("WindArtistTool");
        quickToolVisualTree.CloneTree(root);
        root.styleSheets.Add(Resources.Load<StyleSheet>("WindArtistTool"));



        #region Wind Shader
        // Set Initial Values
        VisualElement windComponent = root.Q<VisualElement>(name: "Wind");
        if (windComponent != null)
        {
            Vector4Field windDirectionQuaternion = windComponent.Q<Vector4Field>(name: "WindDirection");
            windDirectionQuaternion.value = GetWindDirection();

            FloatField windScaleFloat = windComponent.Q<FloatField>(name: "WindScale");
            windScaleFloat.value = GetWindScale();

            MinMaxValue minMaxStrength = GetWindStrength();

            VisualElement windStrengthHolder = windComponent.Q<VisualElement>(name: "WinStrengthHolder");

            MinMaxSlider windStrengthSlider = windStrengthHolder.Q<MinMaxSlider>(name: "WindStrength");
            windStrengthSlider.highLimit = minMaxStrength.HighLimit;
            windStrengthSlider.lowLimit = minMaxStrength.LowLimit;
            windStrengthSlider.value = new Vector2(minMaxStrength.minValue, minMaxStrength.maxValue);

            windStrengthHolder.Q<Label>(name: "MinValue").text = "Min Value :" + minMaxStrength.minValue;
            windStrengthHolder.Q<Label>(name: "MaxValue").text = "Max Value :" + minMaxStrength.maxValue;

            FloatField windSpeedFloat = windComponent.Q<FloatField>(name: "WindSpeed");
            windSpeedFloat.value = GetWindSpeed();

            //Set Callbacks values
            windDirectionQuaternion.RegisterCallback<ChangeEvent<Vector4>>(ChangeWindDirection);
            windScaleFloat.RegisterCallback<ChangeEvent<float>>(ChangeWindScale);
            windStrengthSlider.RegisterCallback<ChangeEvent<Vector2>>(ChangeWindStrength);
            windSpeedFloat.RegisterCallback<ChangeEvent<float>>(ChangeWindSpeed);
        }

        #endregion

        root.Q<Button>(name: "SaveButton").clicked += SaveButton;
        root.Q<Button>(name: "ResetButton").clicked += ResetToInitialSceneValues;



    }


    

   

    void ChangeRenderMode(ChangeEvent<string> evt)
    {
        SetRenderMode(evt.newValue);
    }

    void SetRenderMode(string value)
    {

        ParticleSystemRenderMode render = ParticleSystemRenderMode.None;
        if (value == ParticleSystemRenderMode.HorizontalBillboard.ToString())
        {

            render = ParticleSystemRenderMode.HorizontalBillboard;
        }
        else if (value == ParticleSystemRenderMode.VerticalBillboard.ToString())
        {

            render = ParticleSystemRenderMode.VerticalBillboard;
        }
        else if (value == ParticleSystemRenderMode.Stretch.ToString())
        {
            render = ParticleSystemRenderMode.Stretch;

        }
        else if (value == ParticleSystemRenderMode.Mesh.ToString())
        {

            render = ParticleSystemRenderMode.Mesh;
        }
        else if (value == ParticleSystemRenderMode.Billboard.ToString())
        {
            render = ParticleSystemRenderMode.Billboard;
        }


        GlowParticleSystem.GetComponent<ParticleSystemRenderer>().renderMode = render;



    }
    void ChangeRenderMaterial(ChangeEvent<string> evt)
    {
        VisualElement root = rootVisualElement;
        Material material = root.Q<VisualElement>(name: "VFX").Q<ObjectField>(name: "Material").value as Material;

        SetRenderMaterial(material);

    }
    void ChangeGradientEvent(ChangeEvent<Gradient> evt)
    {
        TimeController.UpdateSetters();

    }
    void SetRenderMaterial(Material newMaterial)
    {

        GlowParticleSystem.GetComponent<ParticleSystemRenderer>().sharedMaterial = newMaterial;

    }

    void ChangeIntensitySpotLightsEvent(ChangeEvent<float> evt)
    {
        float SpotlightsIntensity_Value = evt.newValue;
        ChangeIntensitySpotLights(SpotlightsIntensity_Value);
    }
    void ChangeIntensitySpotLights(float SpotlightsIntensity_Value)
    {

        for (int i = 0; i < SunSpots.Length; i++)
        {
            SunSpots[i].intensity = SpotlightsIntensity_Value;
        }
    }
   
    void ChangeWindDirection(ChangeEvent<Vector4> evt)
    {
        SetWindDirection(evt.newValue);


    }
    void SetWindDirection(Vector4 vector)
    {

        for (int i = 0; i < WindMaterials.Length; i++)
        {
            WindMaterials[i].SetVector("Vector2_AB971143", vector);

        }

    }

    void ChangeWindScale(ChangeEvent<float> evt)
    {

        SetWindScale(evt.newValue);

    }
    void SetWindScale(float value)
    {

        for (int i = 0; i < WindMaterials.Length; i++)
        {
            WindMaterials[i].SetFloat("Vector1_52D24AB4", value);

        }

    }
    void ChangeWindSpeed(ChangeEvent<float> evt)
    {
        SetWindSpeed(evt.newValue);

    }
    void SetWindSpeed(float value)
    {

        for (int i = 0; i < WindMaterials.Length; i++)
        {
            WindMaterials[i].SetFloat("Vector1_3AEF5FB5", value);

        }

    }
    void ChangeWindStrength(ChangeEvent<Vector2> evt)
    {
        VisualElement root = rootVisualElement;
        MinMaxSlider minMaxStrength = root.Q<MinMaxSlider>(name: "WindStrength");

        float minValue;
        float maxValue;
        minValue = minMaxStrength.minValue;
        maxValue = minMaxStrength.maxValue;
        SetWindStrength(minValue, maxValue);
        root.Q<VisualElement>(name: "WinStrengthHolder").Q<Label>(name: "MinValue").text = "Min Value :" + minMaxStrength.minValue;
        root.Q<VisualElement>(name: "WinStrengthHolder").Q<Label>(name: "MaxValue").text = "Max Value :" + minMaxStrength.maxValue;


    }
    void SetWindStrength(float minValue, float maxValue)
    {


        for (int i = 0; i < WindMaterials.Length; i++)
        {
            float randomValue = Random.Range(minValue, maxValue);

            WindMaterials[i].SetFloat("Vector1_36BC0FD6", randomValue);

        }

    }

    Vector4 GetWindDirection()
    {
        Vector4 avgVector = Vector4.zero;
        for (int i = 0; i < WindMaterials.Length; i++)
        {
            avgVector += WindMaterials[i].GetVector("Vector2_AB971143");

        }
        return (avgVector / WindMaterials.Length);
    }

    float GetWindScale()
    {
        float avg = 0;


        for (int i = 0; i < WindMaterials.Length; i++)
        {
            avg += WindMaterials[i].GetFloat("Vector1_52D24AB4");

        }
        return avg / WindMaterials.Length;
    }
    float GetWindSpeed()
    {
        float avg = 0;


        for (int i = 0; i < WindMaterials.Length; i++)
        {
            avg += WindMaterials[i].GetFloat("Vector1_3AEF5FB5");

        }
        return avg / WindMaterials.Length;


    }
    MinMaxValue GetWindStrength()
    {
        MinMaxValue minMaxAvgValue = new MinMaxValue();

        minMaxAvgValue.LowLimit = -10;
        minMaxAvgValue.HighLimit = 10;
        float min = 0, max = 0;

        for (int i = 0; i < WindMaterials.Length; i++)
        {
            float StrengthValue = WindMaterials[i].GetFloat("Vector1_36BC0FD6");
            if (min > StrengthValue)
            {
                min = StrengthValue;
            }
            else if (max < StrengthValue)
            {
                max = StrengthValue;


            }

        }

        minMaxAvgValue.minValue = min;
        minMaxAvgValue.maxValue = max;

        return minMaxAvgValue;

    }

    float GetSpotLightIntensity()
    {
        if (SunSpots != null)
        {
            float mean = 0;
            for (int i = 0; i < SunSpots.Length; i++)
            {
                mean += SunSpots[i].intensity;
            }
            return (mean / SunSpots.Length);
        }
        else
            return 0;

    }
    private void OnDisable()
    {

        ResetToInitialSceneValues();

    }

}
