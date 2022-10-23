using System.ComponentModel; 

public enum ScriptType{
    [Description("Intro")] 
    Intro,
    [Description("Bathroom")]     
    Bathroom, 
    [Description("Factory")] 
    Factory, 
    [Description("Office")] 
    Office, 
    [Description("Toyroom")] 
    Toyroom
}
