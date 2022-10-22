using System.ComponentModel; 

public enum ScriptType{
    [Description("Intro.txt")] 
    Intro,
    [Description("Bathroom.txt")]     
    Bathroom, 
    [Description("Factory.txt")] 
    Factory, 
    [Description("Office.txt")] 
    Office, 
    [Description("Toyroom.txt")] 
    Toyroom
}
