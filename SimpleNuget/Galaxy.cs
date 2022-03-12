using System;

namespace SimpleNuget;
public class Galaxy
{
    public void TakeStar()
    {

    }

    public class Friend
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Root
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
    }

    public class Awesomeobject    {
        public int SomeProps1 { get; set; } 
        public string SomeProps2 { get; set; } 
    }

    public class User    {
        public string id { get; set; } 
        public string name { get; set; } 
        public string created_at { get; set; } 
        public string updated_at { get; set; } 
        public string email { get; set; } 
        public string testanadditionalfield { get; set; } 

    }

    public class Class1    {
        public int id { get; set; } 
        public string user_id { get; set; } 
        public Awesomeobject awesomeobject { get; set; } 
        public string created_at { get; set; } 
        public string updated_at { get; set; } 

    }

    public class Class2    {
        public string SomePropertyOfClass2 { get; set; } 

    }

    public class Root    {
        public Class1 Class1 { get; set; } 
        public Class2 Class2 { get; set; } 

    }

}
