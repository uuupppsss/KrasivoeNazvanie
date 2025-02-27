using System;
using System.Collections.Generic;

namespace KrasivoeNazvanie.DB;

public partial class ToDoItem
{
    public int Id { get; set; }

    public string? Drscription { get; set; }

    public bool IsCompleted { get; set; }
}
