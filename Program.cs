using System;
using System.Collections.Generic;

namespace familyDictionary
{

    public class FamilyMember
    { 
        public Dictionary<string, string> member = new Dictionary<string, string>(){
            {"Name", ""},
            {"Age", ""}
        };

        public FamilyMember(string name, string age)
        {
            member["Name"] = name;
            member["Age"] = age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, FamilyMember> familyDict = new Dictionary<string, FamilyMember>();
            familyDict.Add("Mother", new FamilyMember("Tina", "No way Jose"));
            familyDict.Add("Father", new FamilyMember("Kirk", "61"));
            familyDict.Add("Wife", new FamilyMember("Keisha", "32"));
            familyDict.Add("Brother", new FamilyMember("Micah", "29"));
            familyDict.Add("Sister-In-Law", new FamilyMember("Kiersten", "25"));
            familyDict.Add("Brother-In-Law", new FamilyMember("Mack", "21"));

            foreach (KeyValuePair<string, FamilyMember> family in familyDict)
            {
                    System.Console.WriteLine($"My {family.Key} is named {family.Value.member["Name"]} and is {family.Value.member["Age"]} years old.");
            }
        }
    }
}
