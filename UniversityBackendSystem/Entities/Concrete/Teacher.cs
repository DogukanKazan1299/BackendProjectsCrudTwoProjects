﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Teacher : IEntity
    {
        public int Id { get; set; }

        public string TeacherName { get; set; }

        public string TeacherSurname { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
