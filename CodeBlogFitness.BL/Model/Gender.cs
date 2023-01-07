using System;

namespace CodeBlogFitness.BL.Model
{
    //Пол
    public class Gender
    {
        //Название
        public string Name { get; }
        //Создать новый пол
        public Gender (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя пола не может быть пустым или NULL", nameof(name));
            }

            Name = name;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
