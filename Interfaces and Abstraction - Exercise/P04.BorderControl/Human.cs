﻿namespace BorderControl
{
    public class Human : IIdentificable
    {

        public Human(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }



    }
}
