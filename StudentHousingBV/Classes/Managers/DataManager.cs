﻿using StudentHousingBV.Classes.Entities;
using System.Linq.Expressions;
using System.Text.Json;

namespace StudentHousingBV.Classes.Managers
{
    public class DataManager
    {
        #region Fields
        private readonly string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");
        private readonly bool directoryExists = false;
        #endregion

        #region Constructors
        public DataManager()
        {
            Directory.CreateDirectory(storagePath);
            if (Directory.Exists(storagePath))
            {
                directoryExists = true;
            }
            else
            {
                directoryExists = false;
            }
        }
        #endregion

        #region Serialization

        /// <summary>
        /// Load all data from the storage directory
        /// </summary>
        public List<Building> GetAllData()
        {
            List<Building> data = [];
            data = LoadAttribute(() => data) ?? [];
            return data;
        }

        /// <summary>
        /// Save all data to the storage directory
        /// </summary>
        public void SaveAllData(List<Building> buildings)
        {
            SaveAttribute(() => buildings);
        }

        /// <summary>
        /// Load a list from the storage directory
        /// </summary>
        /// <typeparam name="T"> The type of the list </typeparam>
        /// <param name="listExpression"> The list to load </param>
        /// <returns> The list if it exists, otherwise null </returns>
        public List<T>? LoadAttribute<T>(Expression<Func<List<T>>> listExpression)
        {
            string jsonName = GetListName(listExpression);
            string filePath = Path.Combine(storagePath, $"{jsonName}.json");

            if (!directoryExists || !File.Exists(filePath))
            {
                return null;
            }

            try
            {
                string extractedJson = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(extractedJson);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error loading {jsonName}: {ex.Message}");
            }

            return null;
        }


        /// <summary>
        /// Save a list to the storage directory
        /// </summary>
        /// <typeparam name="T"> The type of the list </typeparam>
        /// <param name="listExpression"> The list to save </param>
        public void SaveAttribute<T>(Expression<Func<List<T>>> listExpression)
        {
            string jsonName = GetListName(listExpression);
            string jsonData = JsonSerializer.Serialize(listExpression.Compile().Invoke());

            if (!directoryExists) return;

            string filePath = Path.Combine(storagePath, $"{jsonName}.json");

            File.WriteAllText(filePath, jsonData);
        }


        /// <summary>
        /// Get the name of a list
        /// </summary>
        /// <typeparam name="T"> The type of the list </typeparam>
        /// <param name="expression"> The list to get the name from </param>
        /// <returns> The name of the list </returns>
        /// <exception cref="ArgumentException"> Thrown when the expression is not a member expression </exception>
        public static string GetListName<T>(Expression<Func<List<T>>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }
            throw new ArgumentException("The expression does not specify a valid member.");
        }


        /// <summary>
        /// Get the path of the storage directory
        /// </summary>
        /// <returns> The path of the storage directory </returns>
        public string GetFilePath()
        {
            return storagePath;
        }
    }
    #endregion

}