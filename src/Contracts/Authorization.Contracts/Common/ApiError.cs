﻿namespace Authorization.Contracts.Common;

/// <summary>
/// Модель ошибки.
/// </summary>
public class ApiError
{
    /// <summary>
    /// Сообщение об ошибке.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Описание ошибки.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Описание ошибки.
    /// </summary>
    public string TraceId { get; set; }
}