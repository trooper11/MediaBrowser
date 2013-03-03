﻿using System;
using System.IO;

namespace MediaBrowser.Model.Serialization
{
    public interface IXmlSerializer
    {
        /// <summary>
        /// Deserializes from stream.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream">The stream.</param>
        /// <returns>``0.</returns>
        T DeserializeFromStream<T>(Stream stream);

        /// <summary>
        /// Deserializes from stream.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Object.</returns>
        object DeserializeFromStream(Type type, Stream stream);

        /// <summary>
        /// Serializes to stream.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="stream">The stream.</param>
        void SerializeToStream(object obj, Stream stream);

        /// <summary>
        /// Deserializes from file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file">The file.</param>
        /// <returns>``0.</returns>
        T DeserializeFromFile<T>(string file);

        /// <summary>
        /// Serializes to file.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="file">The file.</param>
        void SerializeToFile(object obj, string file);

        /// <summary>
        /// Deserializes from file.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="file">The file.</param>
        /// <returns>System.Object.</returns>
        object DeserializeFromFile(Type type, string file);

        /// <summary>
        /// Deserializes from bytes.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="buffer">The buffer.</param>
        /// <returns>System.Object.</returns>
        object DeserializeFromBytes(Type type, byte[] buffer);

        /// <summary>
        /// Serializes to bytes.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns>System.Byte[][].</returns>
        byte[] SerializeToBytes(object obj);
    }
}