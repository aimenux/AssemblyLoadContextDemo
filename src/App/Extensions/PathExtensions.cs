namespace App.Extensions;

public static class PathExtensions
{
    public static string FullPath(this string relativePath)
    {
        ArgumentNullException.ThrowIfNull(relativePath);
        var computedPath = File.Exists(relativePath)
            ? relativePath
            : Path.Combine(GetRootPath(), relativePath);
        return Path.GetFullPath(computedPath);
    }
    
    private static string GetRootPath()
    {
        var binPath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
        var solutionPath = Path.Combine(binPath ?? ".",  @"..\..\..\..");
        return solutionPath;
    }
}