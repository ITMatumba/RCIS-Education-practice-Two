﻿using Npgsql;

namespace GarageConsoleApp;

/// Класс DatabaseService
/// отвечает за подключение и открытие соединения с БД
public static class DatabaseService
{ 
    /// Переменная _connection
    /// хранит открытое соединение с БД
    private static NpgsqlConnection? _connection;
    /// Метод GetConnectionString()
    /// возвращает строку подключения к БД
    private static string GetConnectionString()
    {
        return @"Host=10.30.0.137;Port=5432;Database=gr612_yurman;Username=gr612_yurman;Password=(Matvei)";
    }

    /// Метод GetSqlConnection()
    /// проверяет есть ли уже открытое соединение с БД
    /// если нет, то открывает соединение с БД
    public static NpgsqlConnection GetSqlConnection()
    {                                                                      
        if (_connection is null)
        {
            _connection = new NpgsqlConnection(GetConnectionString());
            _connection.Open();
        }
        
        return _connection;
    }
}