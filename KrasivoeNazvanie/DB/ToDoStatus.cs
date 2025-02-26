using System;
using System.Collections.Generic;

namespace KrasivoeNazvanie.DB;

public partial class ToDoStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();
}
