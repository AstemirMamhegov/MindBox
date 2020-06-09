using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    public class MyContextInitializer : DropCreateDatabaseIfModelChanges<CathedraContext>
    {
        protected override void Seed(CathedraContext context)
        {
            base.Seed(context);

            string[] posts = { "Декан", "Доцент", "Преподаватель", "Лаборант", "Старший преподаватель" };
            foreach (var name in posts)
            {
                Post post = new Post();
                post.Name = name;
                context.Posts.Add(post);
            }
            string[] familyStatus = { "Холост,детей нет", "Холост, дети есть", "Женат, детей нет", "Женат, дети есть" };

            string[] countries = { "Россия", "Китай", "Индия", "Африка" };
            foreach (var name in countries)
            {
                Country country = new Country();
                country.Name = name;
                if (name == "Россия")
                    country.IsDefault = true;
                context.Countries.Add(country);
            }

            string[] directions = { "Информационная безопасность", "Информатика и ВТ" };
            foreach (var name in directions)
            {
                Direction direction = new Direction();
                direction.Name = name;
                context.Directions.Add(direction);
            }

            string[] groups = { "ИВТ-1", "ИВТ-2", "ИБ-1", "ИБ-2" };
            foreach (var name in groups)
            {
                Group group = new Group();
                group.Name = name;
                context.Groups.Add(group);
            }

            string[] subjects = { "Английский", "Программирование", "Физика", "Прикладная информатика" };
            foreach (var name in subjects)
            {
                Subject subject = new Subject();
                subject.Name = name;
                context.Subjects.Add(subject);
            }

            context.SaveChanges();
        }
    }
}
