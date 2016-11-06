using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranscriptsDNURT.Domain.Entities
{
    [Table("UniversityTeacher")]
    public class UniversityTeacher
    {
        /// <summary>
        /// Свойство таблицы Преподаватели - уникальный идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Свойство таблицы Преподаватели - фамилия
        /// </summary>
        [Display(Name = "Преподаватель")]
        [Required(ErrorMessage = "Введите пожалуйста, ФИО преподавателя")]
        public string Name { get; set; }

        /// <summary>
        /// Свойство таблицы Преподаватели - внешний ключ таблицы Кафедры
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Свойство таблицы Преподаватели - внешний ключ таблицы Должности
        /// </summary>
        public int? PositionId { get; set; }

        /// <summary>
        /// Свойство таблицы Преподаватели - кафедра
        /// </summary>
        public virtual Department Department { get; set; }

        /// <summary>
        /// Свойство таблицы Преподаватели - должность
        /// </summary>
        public virtual Position Position { get; set; }

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
