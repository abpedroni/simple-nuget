using System;

namespace SimpleNuget;

public class Friend2
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Root2
{
    public string _id { get; set; }
    public int index { get; set; }
    public string guid { get; set; }
    public bool isActive { get; set; }
    public string balance { get; set; }
    public string picture { get; set; }
    public int age { get; set; }
    public string eyeColor { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public string company { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string address { get; set; }
    public string about { get; set; }
    public string registered { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string greeting { get; set; }
    public string favoriteFruit { get; set; }
    public Class12 Class1 { get; set; } 
    public Class22 Class2 { get; set; } 
}

public class Awesomeobject2    {
    public int SomeProps1 { get; set; } 
    public string SomeProps2 { get; set; } 
}

public class User2   {
    public string id { get; set; } 
    public string name { get; set; } 
    public string created_at { get; set; } 
    public string updated_at { get; set; } 
    public string email { get; set; } 
    public string testanadditionalfield { get; set; } 

}

public class Class12    {
    public int id { get; set; } 
    public string user_id { get; set; } 
    public Awesomeobject2 awesomeobject { get; set; } 
    public string created_at { get; set; } 
    public string updated_at { get; set; } 

}

public class Class22    {
    public string SomePropertyOfClass2 { get; set; } 

}

public static class Constants
{
    public const string RootContextFilePath = "prquantifier.yaml";
    public const string GitHubFolderContextFilePath = ".github/prquantifier.yaml";
}