using System;
using System.Collections.Generic;

namespace KrasivoeNazvanie.DB;

public partial class ToDoItem
{
    public int Id { get; set; }

    public string? Drscription { get; set; }

    public int StatusId { get; set; }

    public virtual ToDoStatus Status { get; set; } = null!;
}
