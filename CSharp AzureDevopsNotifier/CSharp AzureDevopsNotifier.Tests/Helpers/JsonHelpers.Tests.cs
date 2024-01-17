using CSharp_AzureDevopsNotifier.Helpers;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.IO;

namespace CSharp_AzureDevopsNotifier.Tests.Helpers
{
    internal class JsonHelpers
    {
        [Test]
        public void Test_Load_NonExistentFile_ThrowsFileNotFoundException()
        {
            // Arrange
            string path = "nonexistent.json";

            // Act and Assert
            Assert.Throws<FileNotFoundException>(() => JsonHelpers<TypeTest>.Load(path));
        }

        // Loading a valid JSON file returns the deserialized object.
        [Test]
        public void Test_Load_Valid_Json_File_Returns_Deserialized_Object()
        {
            // Arrange
            string path = "Ressources/valid.json";
            TypeTest expected = new();

            // Act
            TypeTest result = JsonHelpers<TypeTest>.Load(path);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        // Loading with a null path throws an ArgumentNullException.
        [TestCase(null)]
        [TestCase("")]
        public void Test_Load_With_Empty_Or_Null_Path_Throws_ArgumentNullException(string path)
        {
            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => JsonHelpers<TypeTest>.Load(path));
        }

        [Test]
        public void Test_Save_Null_Object_To_Valid_Path_Throws_ArgumentNullException()
        {
            // Arrange
            string path = "valid.json";
            TypeTest config = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => JsonHelpers<TypeTest>.Save(path, config));
        }

        [TestCase("valid.json", null)]
        [TestCase(null, "{\"key\":\"value\"}")]
        [TestCase("", "{\"key\":\"value\"}")]
        public void Test_Save_Null_Path_Or_Empty_Json_String_To_Valid_Path_Throws_ArgumentNullException(string path, string json)
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => JsonHelpers<TypeTest>.Save(path, json));
        }

        // Saving to a read-only file throws an UnauthorizedAccessException.
        [Test]
        public void Test_Save_To_Read_Only_File_Throws_UnauthorizedAccessException()
        {
            // Arrange
            string path = "Ressources/readonly.json";
            TypeTest config = new();
            File.WriteAllText(path, "");
            File.SetAttributes(path, FileAttributes.ReadOnly);

            // Act and Assert
            Assert.Throws<UnauthorizedAccessException>(() => JsonHelpers<TypeTest>.Save(path, config));
            File.SetAttributes(path, FileAttributes.Normal);
        }

        [Test]
        public void Test_Save_Valid_Json_String_To_Valid_Path_Saves_String_To_File()
        {
            // Arrange
            string path = "valid.json";
            string json = "{\"key\":\"value\"}";

            // Act
            JsonHelpers<TypeTest>.Save(path, json);
            string result = File.ReadAllText(path);

            // Assert
            Assert.That(json, Is.EqualTo(result));
        }

        // Saving a valid JSON string to a file saves the file successfully.
        [Test]
        public void Test_Save_Valid_Object_Saves_File_Successfully()
        {
            // Arrange
            string path = "Ressources/config.json";
            TypeTest config = new() { Key = "value" };
            string expectedJson = JsonConvert.SerializeObject(config);

            // Act
            JsonHelpers<TypeTest>.Save(path, config);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(File.Exists(path));
                Assert.That(expectedJson, Is.EqualTo(File.ReadAllText(path)));
            });
        }
    }

    internal class TypeTest
    {
        public string Key { get; set; }
    }
}
