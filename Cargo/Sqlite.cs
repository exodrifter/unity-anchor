using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Exodrifter.Anchor
{
	public class Sqlite
	{
		private string uri;

		public Sqlite(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				throw new ArgumentException("Path cannot be null or empty");
			}

			uri = "URI=file:" + path;
		}

		/// <summary>
		/// Returns all row results from a query.
		/// </summary>
		/// <param name="query">The query to perform.</param>
		/// <returns>All row results from the query.</returns>
		public List<List<object>> Query(string query)
		{
			var conn = OpenConnection();
			conn.Open();

			var ret = new List<List<object>>();
			var reader = Query(conn, query);
			while (reader.Read())
			{
				var values = new object[reader.FieldCount];
				reader.GetValues(values);
				ret.Add(new List<object>(values));
			}

			reader.Close();
			conn.Clone();

			return ret;
		}

		/// <summary>
		/// Returns a single row result from a query.
		/// </summary>
		/// <param name="query">The query to perform.</param>
		/// <returns>A single row result from the query.</returns>
		public List<object> QueryOne(string query)
		{
			var conn = OpenConnection();
			conn.Open();

			var reader = Query(conn, query);
			while (reader.Read())
			{
				var values = new object[reader.FieldCount];
				reader.GetValues(values);

				reader.Close();
				conn.Close();
				return new List<object>(values);
			}

			reader.Close();
			conn.Close();
			return new List<object>();
		}

		public void QueryNone(string query)
		{
			var conn = OpenConnection();
			conn.Open();

			NonQuery(conn, query);

			conn.Close();
		}

		private SqliteConnection OpenConnection()
		{
			return new SqliteConnection(uri);
		}

		private SqliteDataReader Query(SqliteConnection conn, string query)
		{
			var cmd = conn.CreateCommand();
			cmd.CommandText = query;
			var reader = cmd.ExecuteReader();
			cmd.Dispose();
			return reader;
		}

		private int NonQuery(SqliteConnection conn, string query)
		{
			var cmd = conn.CreateCommand();
			cmd.CommandText = query;
			var ret = cmd.ExecuteNonQuery();
			cmd.Dispose();
			return ret;
		}
	}
}