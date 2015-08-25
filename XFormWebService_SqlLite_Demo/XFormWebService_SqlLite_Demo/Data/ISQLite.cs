using System;

using SQLite;

namespace XFormWebService_SqlLite_Demo
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

        SQLiteAsyncConnection GetAsyncConnection();

    }
}

