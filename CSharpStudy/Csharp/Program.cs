using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        // c# 전용 
        // 언리얼 에서는 어렵게 구현되어 있음.

        class Important : System.Attribute
        {
            string message;

            public Important(string message) { this.message = message; }
        }

        class Monster
        {
            // hp 입니다. 중요한 정보입니다.
            [Important("VeryImportant")]
            public int hp;

            protected int attack;
            private float speed;

            void Attack() { }
        }

        static void Main(string[] args)
        {
            // Reflection : X-Ray
            Monster monster = new Monster();
            
            Type type = monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }

        }
    }
}


