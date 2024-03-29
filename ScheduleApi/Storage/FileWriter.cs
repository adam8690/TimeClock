﻿using Newtonsoft.Json;
using System.IO;

namespace ScheduleApi.Storage
{
    public class FileWriter
    {
        string PathToFile;
        public FileWriter()
        {
            PathToFile = "schedule.json";
        }
        /// <summary>
        /// Writes the given object instance to a Json file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [JsonIgnore] attribute.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public void WriteToJsonFile(Schedule objectToWrite)
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(PathToFile, false);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an Json file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the Json file.</returns>
        public Schedule ReadFromJsonFile()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(PathToFile);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Schedule>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
