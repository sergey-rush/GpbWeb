﻿namespace GpbWeb.Models
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}