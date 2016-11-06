using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscriptsDNURT.Domain.Entities
{
    [Table("Student")]
    public class Student
    {
        /// <summary>
        /// Свойство таблицы Студенты - уникальный идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Свойство таблицы Студенты - фамилия
        /// </summary>
        [Display(Name = "Студент")]
        [Required(ErrorMessage = "Введите пожалуйста, ФИО студента")]
        public string Name { get; set; }

        /// <summary>
        /// Свойство таблицы Студенты - внешний ключ таблицы Группы
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// Свойство таблицы Студенты - группа
        /// </summary>
        public virtual GroupStudent Group { get; set; }

        /// <summary>
        /// Коллекция успеваемостей
        /// </summary>
        public virtual ICollection<Transcript> Transcripts { get; set; }

        /// <summary>
        /// Коллекция пропусков
        /// </summary>
        public virtual ICollection<Absence> Absences { get; set; }
    }
}
