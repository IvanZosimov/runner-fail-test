namespace FileLoader.Tests
{
    public class MetadataFileLoadTests
    {
        [Theory]
        [InlineData("Model/Metadata/example.json")]
        [InlineData("Model/Metadata/example.metadata.json")] 
        [InlineData("Model/Metadata/new.metadata.json")] 
        public void EmbeddedFile_ShouldExist(string filePath)
        {
            string file = ResourceLoaderHelper.LoadTestDataAsString(filePath);
            Assert.NotNull(file);
        }
    }
}
