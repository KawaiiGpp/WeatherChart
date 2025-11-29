using System.Reflection;
using System.Text;

namespace WeatherChart.Util
{
    public class EmbeddedFile(string category, string path)
    {
        public static readonly string TEXT = "Text";

        public string FileName { get; } = path;
        public string Path { get; } = $"WeatherChart.Resource.{category}.{path}";

        public List<string> ReadAsText()
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Path)
                ?? throw new IOException($"Manifest resource at {Path} not found.");
            using var reader = new StreamReader(stream, Encoding.UTF8);

            List<string> result = [];
            string? line;

            while ((line = reader.ReadLine()) != null) result.Add(line);
            return result;
        }
    }
}
