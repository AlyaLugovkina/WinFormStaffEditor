using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsStaffEditor;

public partial class Staff
{
    /// <summary>
    /// уникальный id в базе
    /// </summary>
    public uint Id { get; set; }
    [ConcurrencyCheck]
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Фамилия
    /// </summary>
    public string Surname { get; set; } = null!;

    /// <summary>
    /// Отчество
    /// </summary>
    public string Patronymic { get; set; } = null!;

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateOnly BirthDate { get; set; }

    /// <summary>
    /// СНИЛС сотрудника(уникален)
    /// </summary>
    public string Snils { get; set; } = null!;

    /// <summary>
    /// Должность
    /// </summary>
    public string Position { get; set; } = null!;

    /// <summary>
    /// Дата приема на работу
    /// </summary>
    public DateOnly EmploymentDate { get; set; }
}
